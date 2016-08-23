using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Xml;
using System.Runtime.InteropServices;
using System.Security.Principal;
using Microsoft.Win32.SafeHandles;
using System.Threading;

using Emgu.CV.UI;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

using System.IO.Ports;

namespace $safeprojectname$
{
    public partial class frmMain : Form
    {
        #region variables
        //$safeprojectname$ Variables-------------------------------------------------------------------------
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.5, 0.5);
        Capture vidCapture;
        Image<Bgr, Byte> imgLive;
        Image<Bgr, Byte> imgMain;

        CascadeClassifier faceHaar = new CascadeClassifier("haarcascade_frontalface_default.xml");
        Boolean fFaceDetected = false; 
        Image<Gray, byte>[] CroppedFaces;
        //Classifier with default training location
        Classifier_Train Eigen_Recog = new Classifier_Train();
        //Application Variables--------------------------------------------------------------------
        XmlDocument docu = new XmlDocument();

        #endregion
        
		public frmMain()
        {
            InitializeComponent();
            chkStoring.Checked = false;  
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            GetComList();
        }
        //Cam//////////////////////////////////////////////////////////////////////////////////////
        private void btnCamStart_Click(object sender, EventArgs e)
        {
            vidCapture = new Capture();
            vidCapture.QueryFrame();
            Application.Idle += new EventHandler(LiveCam);
        }
        //-----------------------------------------------------------------------------------------
        private void btnCamStop_Click(object sender, EventArgs e)
        {
            Application.Idle -= new EventHandler(LiveCam);
            if (vidCapture != null)
            {
                vidCapture.Dispose();
            }
        }
        //-----------------------------------------------------------------------------------------
        void LiveCam(object sender, EventArgs e)
        {
            //Get the current frame form capture device
            imgLive = vidCapture.QuerySmallFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC).Flip(FLIP.HORIZONTAL);
            if (imgLive != null)
            {
                picCam.Image = imgLive.ToBitmap();
            }
        }
        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        //Processing///////////////////////////////////////////////////////////////////////////////
        private void btnProcessStart_Click(object sender, EventArgs e)
        {
            if (chkStoring.Checked == false)
            {
                Retrain();
            }
            
            txtSysMsg.Text = "Processing Started..." + Environment.NewLine + txtSysMsg.Text;

            Application.Idle += new EventHandler(ImageProcessing);
        }
        //-----------------------------------------------------------------------------------------
        private void btnProcessStop_Click(object sender, EventArgs e)
        {
            Application.Idle -= new EventHandler(ImageProcessing);
            txtSysMsg.Text = "Processing Stopped." + Environment.NewLine + txtSysMsg.Text;
        }
        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        //Haar Processing//////////////////////////////////////////////////////////////////////////
        void ImageProcessing(object sender, EventArgs e)
        {
            CroppedFaces = null;

            imgMain = imgLive.Copy();

            Image<Gray, Byte> imgGray = imgMain.Convert<Gray, Byte>();
            picIP1.Image = imgGray.ToBitmap();

            imgGray._EqualizeHist();    //normalizes brightness and increases contrast of the image
            picIP2.Image = imgGray.ToBitmap();
            
            //DETECTION PROCESS#######################################################################################################

            //Face Detection-----------------------------------------------------------------------
            //Detect the faces from the gray scale image and store the locations as rectangle
            Rectangle[] facesDetected = faceHaar.DetectMultiScale(imgGray, float.Parse(txtHAARSaleFactor.Text), int.Parse(txtHAARMinNei.Text), new Size(50, 50),Size.Empty);
            txtFacesDetected.Text = facesDetected.Length.ToString();
            //--------------------------------------------------------------------------------------
            if (facesDetected.Length <= 0)
            {
                //face not detected
                fFaceDetected = false;
                txtSysMsg.Text = "NO Face(s) Found!!!" + Environment.NewLine + txtSysMsg.Text;
                return;
            }
            //---------------------------------------------------------------------------------------
            
            //mark & crop all the detected faces
            CroppedFaces = new Image<Gray, byte>[facesDetected.Length];
            for (int i = 0; i < facesDetected.Length; i++)
            {
                //This will focus in on the face from the haar results its not perfect but it will remove a majoriy
                //of the background noise
                facesDetected[i].X += (int)(facesDetected[i].Height * 0.15);
                facesDetected[i].Y += (int)(facesDetected[i].Width * 0.20);
                facesDetected[i].Height -= (int)(facesDetected[i].Height * 0.30);
                facesDetected[i].Width -= (int)(facesDetected[i].Width * 0.30);

                CroppedFaces[i] = imgGray.Copy(facesDetected[i]).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                imgMain.Draw(facesDetected[i], new Bgr(Color.GreenYellow), 1);
            }

            picCam.Image = imgMain.ToBitmap();  //update the image on screen

            picFace.Image = CroppedFaces[0].ToBitmap(); //display the oth image on screen for saving purpose
            fFaceDetected = true;

            if (chkStoring.Checked == true) return;
            
            //RECOGNITION PROCESS ###############################################################################################

            if (Eigen_Recog.IsTrained)
            {
                for (int i = 0; i < facesDetected.Length; i++)
                {
                    string Name = Eigen_Recog.Recognise(CroppedFaces[i]);

                    int match_value = (int)Eigen_Recog.Get_Eigen_Distance;
                    //Draw the label for each face detected and recognized
                    imgMain.Draw(Name + " " + match_value, ref font, new Point(facesDetected[i].X - 2, facesDetected[i].Y - 2), new Bgr(Color.LightGreen));


                    if ((Name != "")&&(Name != "Unknown"))
                    {
                        //user Recognized------------------------------------------------------------
                        lblWelcome.Text = "Welcome " + Name;
                        Port.Write("O");
                    }
                    else
                    {
                        //user NOT Recognized--------------------------------------------------------
                        lblWelcome.Text = "Unauthorized User!!!";
                    }
                    
                }

                picCam.Image = imgMain.ToBitmap();  //update the image on screen
            }
           
        }
        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        //-----------------------------------------------------------------------------------------
        public void Retrain()
        {
            Eigen_Recog = new Classifier_Train();
 
            if (Eigen_Recog.IsTrained)
            {
                txtSysMsg.Text = "Training Data Loaded" + Environment.NewLine + txtSysMsg.Text;
            }
            else
            {
                txtSysMsg.Text = "No Training Data Found !!!" + Environment.NewLine + txtSysMsg.Text;
            }
        }
        //-----------------------------------------------------------------------------------------
        private void chkStoring_CheckedChanged(object sender, EventArgs e)
        {
            gpbStoring.Enabled = chkStoring.Checked;
        }
        //-----------------------------------------------------------------------------------------
        private void btnStore_Click(object sender, EventArgs e)
        {
            if (fFaceDetected)
            {
                string FaceFileName = txtName.Text + "_" + txtIdx.Text + ".jpg";

                picFace.Image.Save(Application.StartupPath + "\\TrainedObjects\\" + FaceFileName);
                txtIdx.Text = Convert.ToString(int.Parse(txtIdx.Text) + 1);

                if (File.Exists(Application.StartupPath + "/TrainedObjects/TrainedLabels.xml"))
                {
                    bool loading = true;
                    while (loading)
                    {
                        try
                        {
                            docu.Load(Application.StartupPath + "/TrainedObjects/TrainedLabels.xml");
                            loading = false;
                        }
                        catch
                        {
                            docu = null;
                            docu = new XmlDocument();
                            Thread.Sleep(10);
                        }
                    }

                    //Get the root element
                    XmlElement root = docu.DocumentElement;

                    XmlElement face_D = docu.CreateElement("FACE");
                    XmlElement name_D = docu.CreateElement("NAME");
                    XmlElement file_D = docu.CreateElement("FILE");

                    //Add the values for each nodes
                    name_D.InnerText = txtName.Text;
                    file_D.InnerText = FaceFileName;

                    //Construct the Person element
                    //person.Attributes.Append(name);
                    face_D.AppendChild(name_D);
                    face_D.AppendChild(file_D);

                    //Add the New person element to the end of the root element
                    root.AppendChild(face_D);

                    //Save the document
                    docu.Save(Application.StartupPath + "/TrainedObjects/TrainedLabels.xml");
                }
                else
                {
                    FileStream FS_Face = File.OpenWrite(Application.StartupPath + "/TrainedObjects/TrainedLabels.xml");
                    using (XmlWriter writer = XmlWriter.Create(FS_Face))
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement("Faces_For_Training");

                        writer.WriteStartElement("FACE");
                        writer.WriteElementString("NAME", txtName.Text);
                        writer.WriteElementString("FILE", FaceFileName);
                        writer.WriteEndElement();

                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                    }
                    FS_Face.Close();
                }
            }
            else
            {
                txtSysMsg.Text = "No Face Detected!" + Environment.NewLine + txtSysMsg.Text;
            }
        }
        //-----------------------------------------------------------------------------------------
        private void btnReset_Click(object sender, EventArgs e)
        {
            Eigen_Recog.PCAIteration = int.Parse(txtPCAIteration.Text);
            Eigen_Recog.PCAThreshold = int.Parse(txtPCAThreshold.Text);

           Eigen_Recog.LDAIteration = int.Parse(txtLDAIteration.Text);
          Eigen_Recog.LDAThreshold = int.Parse(txtLDAThreshold.Text);

            //Eigen_Recog.LBPHRadius = int.Parse(txtLBPHThreshold.Text);
            //Eigen_Recog.LBPHNeighbors = int.Parse(txtLBPHNeighbors.Text);
           // Eigen_Recog.LBPHGridX = int.Parse(txtLBPHGridX.Text);
           // Eigen_Recog.LBPHGridY = int.Parse(txtLBPHGridY.Text);
           // Eigen_Recog.LBPHThreshold = int.Parse(txtLBPHThreshold.Text);

            if (optPCA.Checked == true) Eigen_Recog.Recognizer_Type = "EMGU.CV.EigenFaceRecognizer";
            if (optLDA.Checked == true) Eigen_Recog.Recognizer_Type = "EMGU.CV.FisherFaceRecognizer";
           // if (optLBPH.Checked == true) Eigen_Recog.Recognizer_Type = "EMGU.CV.LBPHFaceRecognizer";

            Eigen_Recog.Retrain(); 
        }
        //-----------------------------------------------------------------------------------------
        //Serial communication/////////////////////////////////////////////////////////////////////
        void GetComList()
        {
            // Get a list of serial port names.
            string[] ports;
            ports = SerialPort.GetPortNames();
            // Display each port name to the console.
            foreach (string port in ports)
            {
                cmbCOM.Items.Add(port);
            }
        }
        //-----------------------------------------------------------------------------------------
        private void cmdConnect_Click(object sender, EventArgs e)
        {
            Port.Close();
            Port.PortName = cmbCOM.Text;
            Port.BaudRate = 9600;
            Port.Parity = Parity.None;
            Port.DataBits = 8;

            Port.StopBits = StopBits.One;
            Port.Handshake = Handshake.None;
            Port.Open();

            MessageBox.Show("Port is Reconfigured.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
