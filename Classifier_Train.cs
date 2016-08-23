using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Emgu.CV.UI;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

using System.IO;
using System.Xml;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Drawing.Imaging;
using System.Drawing;

/// <summary>
/// Desingned to remove the training a EigenObjectRecognizer code from the main form
/// </summary>
class Classifier_Train: IDisposable
{
    #region Variables

    public string Recognizer_Type = "EMGU.CV.EigenFaceRecognizer";

    public int PCAIteration = 80;
    public int PCAThreshold = 2000;

    public int LDAIteration = 80;
    public int LDAThreshold = 2000;

    public int LBPHRadius = 1;
    public int LBPHNeighbors = 8;
    public int LBPHGridX = 8;
    public int LBPHGridY = 8;
    public int LBPHThreshold = 35;
    
    FaceRecognizer recognizer;

    //training variables
    List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();//Images
    //TODO: see if this can be combined in Ditionary format this will remove support for old data
    List<string> Names_List = new List<string>(); //labels
    List<int> Names_List_ID = new List<int>();
    int ContTrain, NumLabels;

    float Eigen_Distance = 0;
    string Eigen_label;

    //Class Variables
    string Error;
    bool _IsTrained = false;
        
    #endregion

    #region Constructors
    /// <summary>
    /// Default Constructor, Looks in (Application.StartupPath + "\\TrainedObjects") for traing data.
    /// </summary>
    public Classifier_Train()
    {
        _IsTrained = LoadTrainingData(Application.StartupPath + "\\TrainedObjects");
    }
    #endregion

    #region Public
    /// <summary>
    /// Retrains the recognizer witout resetting variables like recognizer type.
    /// </summary>
    /// <returns></returns>
    public bool Retrain()
    {
        return _IsTrained = LoadTrainingData(Application.StartupPath + "\\TrainedObjects");
    }
   
    /// <summary>
    /// <para>Return(True): If Training data has been located and Eigen Recogniser has been trained</para>
    /// <para>Return(False): If NO Training data has been located of error in training has occured</para>
    /// </summary>
    public bool IsTrained
    {
        get { return _IsTrained; }
    }

    /// <summary>
    /// Recognise a Grayscale Image using the trained Eigen Recogniser
    /// </summary>
    /// <param name="Input_image"></param>
    /// <returns></returns>
    public string Recognise(Image<Gray, byte> Input_image, int Eigen_Thresh = -1)
    {
        if (_IsTrained)
        {
            FaceRecognizer.PredictionResult ER = recognizer.Predict(Input_image);

            if (ER.Label == -1)
            {
                Eigen_label = "Unknown";
                Eigen_Distance = 0;
                return Eigen_label;
            }
            else
            {
                Eigen_label = Names_List[ER.Label];
                Eigen_Distance = (float)ER.Distance;
                if (Eigen_Thresh > -1) PCAThreshold = Eigen_Thresh;

                return Eigen_label; //the threshold set in training controls unknowns
            }
        }
        else return "";
    }

    /// <summary>
    /// Returns a string containg the recognised persons name
    /// </summary>
    public string Get_Eigen_Label
    {
        get
        {
            return Eigen_label;
        }
    }

    /// <summary>
    /// Returns a float confidence value for potential false clasifications
    /// </summary>
    public float Get_Eigen_Distance
    {
        get
        {
            return Eigen_Distance;
        }
    }

    /// <summary>
    /// Returns a string contatining any error that has occured
    /// </summary>
    public string Get_Error
    {
        get { return Error; }
    }

    /// <summary>
    /// Dispose of Class call Garbage Collector
    /// </summary>
    public void Dispose()
    {
        recognizer = null;
        trainingImages = null;
        Names_List = null;
        Error = null;
        GC.Collect();
    }

    #endregion

    #region Private
    /// <summary>
    /// Loads the traing data given a (string) folder location
    /// </summary>
    /// <param name="Folder_location"></param>
    /// <returns></returns>
    private bool LoadTrainingData(string Folder_location)
    {
        if (File.Exists(Folder_location +"\\TrainedLabels.xml"))
        {
            try
            {
                Names_List.Clear();
                Names_List_ID.Clear();
                trainingImages.Clear();

                FileStream filestream = File.OpenRead(Folder_location + "\\TrainedLabels.xml");

                long filelength = filestream.Length;
                byte[] xmlBytes = new byte[filelength];
                filestream.Read(xmlBytes, 0, (int)filelength);
                filestream.Close();

                MemoryStream xmlStream = new MemoryStream(xmlBytes);

                using (XmlReader xmlreader = XmlTextReader.Create(xmlStream))
                {
                    while (xmlreader.Read())
                    {
                        if (xmlreader.IsStartElement())
                        {
                            switch (xmlreader.Name)
                            {
                                case "NAME":
                                    if (xmlreader.Read())
                                    {
                                        Names_List_ID.Add(Names_List.Count); //0, 1, 2, 3....
                                        Names_List.Add(xmlreader.Value.Trim());
                                        NumLabels += 1;
                                    }
                                    break;
                                case "FILE":
                                    if (xmlreader.Read())
                                    {
                                        //PROBLEM HERE IF TRAININGG MOVED
                                        trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "\\TrainedObjects\\" + xmlreader.Value.Trim()));
                                    }
                                    break;
                            }
                        }
                    }
                }
                ContTrain = NumLabels;

                if (trainingImages.ToArray().Length != 0)
                {

                    //Eigen face recognizer
                    //Parameters:	
                    //      num_components – The number of components (read: Eigenfaces) kept for this Prinicpal 
                    //          Component Analysis. As a hint: There’s no rule how many components (read: Eigenfaces) 
                    //          should be kept for good reconstruction capabilities. It is based on your input data, 
                    //          so experiment with the number. Keeping 80 components should almost always be sufficient.
                    //
                    //      threshold – The threshold applied in the prediciton. This still has issues as it work inversly to LBH and Fisher Methods.
                    //          if you use 0.0 recognizer.Predict will always return -1 or unknown if you use 5000 for example unknow won't be reconised.
                    //
                    //NOTE: The following causes the confusion, sinc two rules are used. 
                    //--------------------------------------------------------------------------------------------------------------------------------------
                    //Eigen Uses
                    //          0 - X = unknown
                    //          > X = Recognised
                    //
                    //Fisher and LBPH Use
                    //          0 - X = Recognised
                    //          > X = Unknown
                    //
                    // Where X = Threshold value


                    switch (Recognizer_Type)
                    {
                        case ("EMGU.CV.LBPHFaceRecognizer"):
                            recognizer = new LBPHFaceRecognizer(LBPHRadius, LBPHNeighbors, LBPHGridX, LBPHGridY, LBPHThreshold);//50
                            break;
                        case ("EMGU.CV.FisherFaceRecognizer"):
                            recognizer = new FisherFaceRecognizer(LDAIteration, LDAThreshold);//4000
                            break;
                        case("EMGU.CV.EigenFaceRecognizer"):
                        default:
                            recognizer = new EigenFaceRecognizer(PCAIteration, PCAThreshold);
                            break;
                    }

                    recognizer.Train(trainingImages.ToArray(), Names_List_ID.ToArray());

                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                Error = ex.ToString();
                return false;
            }
        }
        else return false;
    }

    #endregion
}

