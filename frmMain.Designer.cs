namespace $safeprojectname$
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gpbStoring = new System.Windows.Forms.GroupBox();
            this.btnStore = new System.Windows.Forms.Button();
            this.txtIdx = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.chkStoring = new System.Windows.Forms.CheckBox();
            this.picCam = new System.Windows.Forms.PictureBox();
            this.btnProcessStop = new System.Windows.Forms.Button();
            this.btnProcessStart = new System.Windows.Forms.Button();
            this.btnCamStop = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnCamStart = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtSysMsg = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.picIP1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFacesDetected = new System.Windows.Forms.TextBox();
            this.picIP2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPCAIteration = new System.Windows.Forms.TextBox();
            this.txtPCAThreshold = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.optPCA = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.cmbCOM = new System.Windows.Forms.ComboBox();
            this.Port = new System.IO.Ports.SerialPort(this.components);
            this.lblWelcome = new System.Windows.Forms.Label();
            this.gpbStoring.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbStoring
            // 
            this.gpbStoring.Controls.Add(this.btnStore);
            this.gpbStoring.Controls.Add(this.txtIdx);
            this.gpbStoring.Controls.Add(this.Label6);
            this.gpbStoring.Controls.Add(this.txtName);
            this.gpbStoring.Controls.Add(this.Label5);
            this.gpbStoring.Location = new System.Drawing.Point(338, 482);
            this.gpbStoring.Name = "gpbStoring";
            this.gpbStoring.Size = new System.Drawing.Size(320, 117);
            this.gpbStoring.TabIndex = 119;
            this.gpbStoring.TabStop = false;
            this.gpbStoring.Text = "Storing Parameters";
            // 
            // btnStore
            // 
            this.btnStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStore.Location = new System.Drawing.Point(11, 51);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(295, 60);
            this.btnStore.TabIndex = 105;
            this.btnStore.Text = "Store";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // txtIdx
            // 
            this.txtIdx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdx.Location = new System.Drawing.Point(264, 19);
            this.txtIdx.Name = "txtIdx";
            this.txtIdx.Size = new System.Drawing.Size(42, 26);
            this.txtIdx.TabIndex = 104;
            this.txtIdx.Text = "0";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(226, 23);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(36, 20);
            this.Label6.TabIndex = 103;
            this.Label6.Text = "idx:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(71, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 26);
            this.txtName.TabIndex = 102;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(7, 22);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(60, 20);
            this.Label5.TabIndex = 101;
            this.Label5.Text = "Name:";
            // 
            // chkStoring
            // 
            this.chkStoring.AutoSize = true;
            this.chkStoring.BackColor = System.Drawing.Color.Transparent;
            this.chkStoring.Checked = true;
            this.chkStoring.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStoring.ForeColor = System.Drawing.Color.White;
            this.chkStoring.Location = new System.Drawing.Point(338, 365);
            this.chkStoring.Name = "chkStoring";
            this.chkStoring.Size = new System.Drawing.Size(86, 24);
            this.chkStoring.TabIndex = 118;
            this.chkStoring.Text = "Storing";
            this.chkStoring.UseVisualStyleBackColor = false;
            this.chkStoring.CheckedChanged += new System.EventHandler(this.chkStoring_CheckedChanged);
            // 
            // picCam
            // 
            this.picCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCam.Location = new System.Drawing.Point(12, 86);
            this.picCam.Name = "picCam";
            this.picCam.Size = new System.Drawing.Size(320, 240);
            this.picCam.TabIndex = 117;
            this.picCam.TabStop = false;
            // 
            // btnProcessStop
            // 
            this.btnProcessStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessStop.Location = new System.Drawing.Point(498, 1);
            this.btnProcessStop.Name = "btnProcessStop";
            this.btnProcessStop.Size = new System.Drawing.Size(160, 49);
            this.btnProcessStop.TabIndex = 116;
            this.btnProcessStop.Text = "Stop Process";
            this.btnProcessStop.UseVisualStyleBackColor = true;
            this.btnProcessStop.Click += new System.EventHandler(this.btnProcessStop_Click);
            // 
            // btnProcessStart
            // 
            this.btnProcessStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessStart.Location = new System.Drawing.Point(338, 1);
            this.btnProcessStart.Name = "btnProcessStart";
            this.btnProcessStart.Size = new System.Drawing.Size(160, 49);
            this.btnProcessStart.TabIndex = 115;
            this.btnProcessStart.Text = "Start Process";
            this.btnProcessStart.UseVisualStyleBackColor = true;
            this.btnProcessStart.Click += new System.EventHandler(this.btnProcessStart_Click);
            // 
            // btnCamStop
            // 
            this.btnCamStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamStop.Location = new System.Drawing.Point(172, 1);
            this.btnCamStop.Name = "btnCamStop";
            this.btnCamStop.Size = new System.Drawing.Size(160, 49);
            this.btnCamStop.TabIndex = 114;
            this.btnCamStop.Text = "Stop  Cam";
            this.btnCamStop.UseVisualStyleBackColor = true;
            this.btnCamStop.Click += new System.EventHandler(this.btnCamStop_Click);
            // 
            // btnCamStart
            // 
            this.btnCamStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamStart.Location = new System.Drawing.Point(6, 1);
            this.btnCamStart.Name = "btnCamStart";
            this.btnCamStart.Size = new System.Drawing.Size(160, 49);
            this.btnCamStart.TabIndex = 111;
            this.btnCamStart.Text = "Start camera";
            this.btnCamStart.UseVisualStyleBackColor = true;
            this.btnCamStart.Click += new System.EventHandler(this.btnCamStart_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(8, 336);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(169, 20);
            this.Label3.TabIndex = 110;
            this.Label3.Text = "System Messages...";
            // 
            // txtSysMsg
            // 
            this.txtSysMsg.BackColor = System.Drawing.Color.DimGray;
            this.txtSysMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSysMsg.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSysMsg.Location = new System.Drawing.Point(12, 359);
            this.txtSysMsg.Multiline = true;
            this.txtSysMsg.Name = "txtSysMsg";
            this.txtSysMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSysMsg.Size = new System.Drawing.Size(320, 172);
            this.txtSysMsg.TabIndex = 109;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(337, 63);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(112, 20);
            this.Label2.TabIndex = 108;
            this.Label2.Text = "Processing...";
            // 
            // picIP1
            // 
            this.picIP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picIP1.Location = new System.Drawing.Point(341, 86);
            this.picIP1.Name = "picIP1";
            this.picIP1.Size = new System.Drawing.Size(157, 114);
            this.picIP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIP1.TabIndex = 107;
            this.picIP1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(8, 63);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(86, 20);
            this.Label1.TabIndex = 106;
            this.Label1.Text = "Camera...";
            // 
            // ToolStrip
            // 
            this.ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1002, 25);
            this.ToolStrip.TabIndex = 104;
            this.ToolStrip.Text = "ToolStrip";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1002, 24);
            this.MenuStrip.TabIndex = 103;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(338, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 126;
            this.label4.Text = "Faces Detected:";
            // 
            // txtFacesDetected
            // 
            this.txtFacesDetected.BackColor = System.Drawing.Color.DimGray;
            this.txtFacesDetected.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacesDetected.ForeColor = System.Drawing.SystemColors.Info;
            this.txtFacesDetected.Location = new System.Drawing.Point(386, 424);
            this.txtFacesDetected.Name = "txtFacesDetected";
            this.txtFacesDetected.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFacesDetected.Size = new System.Drawing.Size(53, 49);
            this.txtFacesDetected.TabIndex = 125;
            // 
            // picIP2
            // 
            this.picIP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picIP2.Location = new System.Drawing.Point(504, 86);
            this.picIP2.Name = "picIP2";
            this.picIP2.Size = new System.Drawing.Size(156, 114);
            this.picIP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIP2.TabIndex = 128;
            this.picIP2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(666, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 135;
            this.label7.Text = "No of Iterations";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(666, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 137;
            this.label8.Text = "Threshold";
            // 
            // txtPCAIteration
            // 
            this.txtPCAIteration.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.txtPCAIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPCAIteration.Location = new System.Drawing.Point(835, 115);
            this.txtPCAIteration.Name = "txtPCAIteration";
            this.txtPCAIteration.Size = new System.Drawing.Size(149, 26);
            this.txtPCAIteration.TabIndex = 141;
            this.txtPCAIteration.Text = "80";
            // 
            // txtPCAThreshold
            // 
            this.txtPCAThreshold.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.txtPCAThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPCAThreshold.Location = new System.Drawing.Point(835, 150);
            this.txtPCAThreshold.Name = "txtPCAThreshold";
            this.txtPCAThreshold.Size = new System.Drawing.Size(149, 26);
            this.txtPCAThreshold.TabIndex = 143;
            this.txtPCAThreshold.Text = "2000";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 191;
            // 
            // picFace
            // 
            this.picFace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFace.Location = new System.Drawing.Point(558, 359);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(100, 100);
            this.picFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFace.TabIndex = 149;
            this.picFace.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(666, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 20);
            this.label12.TabIndex = 153;
            this.label12.Text = "PCA Parameters:";
            // 
            // optPCA
            // 
            this.optPCA.AutoSize = true;
            this.optPCA.BackColor = System.Drawing.Color.Transparent;
            this.optPCA.Checked = true;
            this.optPCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optPCA.Location = new System.Drawing.Point(917, 78);
            this.optPCA.Name = "optPCA";
            this.optPCA.Size = new System.Drawing.Size(69, 28);
            this.optPCA.TabIndex = 155;
            this.optPCA.TabStop = true;
            this.optPCA.Text = "PCA";
            this.optPCA.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(668, 502);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(316, 97);
            this.btnReset.TabIndex = 159;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmdConnect
            // 
            this.cmdConnect.BackColor = System.Drawing.Color.LightSeaGreen;
            this.cmdConnect.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdConnect.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConnect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdConnect.Location = new System.Drawing.Point(835, 0);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdConnect.Size = new System.Drawing.Size(149, 48);
            this.cmdConnect.TabIndex = 182;
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.UseVisualStyleBackColor = false;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // cmbCOM
            // 
            this.cmbCOM.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmbCOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCOM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCOM.ForeColor = System.Drawing.Color.Black;
            this.cmbCOM.FormattingEnabled = true;
            this.cmbCOM.Location = new System.Drawing.Point(679, 13);
            this.cmbCOM.Name = "cmbCOM";
            this.cmbCOM.Size = new System.Drawing.Size(150, 26);
            this.cmbCOM.TabIndex = 181;
            this.cmbCOM.Text = "Select COM Port";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Blue;
            this.lblWelcome.Location = new System.Drawing.Point(335, 262);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(132, 37);
            this.lblWelcome.TabIndex = 183;
            this.lblWelcome.Text = "ACPCE";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1002, 618);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.cmdConnect);
            this.Controls.Add(this.cmbCOM);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.optPCA);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.picFace);
            this.Controls.Add(this.txtPCAThreshold);
            this.Controls.Add(this.txtPCAIteration);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.picIP2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFacesDetected);
            this.Controls.Add(this.gpbStoring);
            this.Controls.Add(this.chkStoring);
            this.Controls.Add(this.picCam);
            this.Controls.Add(this.btnProcessStop);
            this.Controls.Add(this.btnProcessStart);
            this.Controls.Add(this.btnCamStop);
            this.Controls.Add(this.btnCamStart);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtSysMsg);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.picIP1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.label11);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$safeprojectname$";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gpbStoring.ResumeLayout(false);
            this.gpbStoring.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        internal System.Windows.Forms.GroupBox gpbStoring;
        internal System.Windows.Forms.Button btnStore;
        internal System.Windows.Forms.TextBox txtIdx;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.CheckBox chkStoring;
        internal System.Windows.Forms.PictureBox picCam;
        internal System.Windows.Forms.Button btnProcessStop;
        internal System.Windows.Forms.Button btnProcessStart;
        internal System.Windows.Forms.Button btnCamStop;
        internal System.Windows.Forms.ToolTip ToolTip;
        internal System.Windows.Forms.Button btnCamStart;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtSysMsg;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.PictureBox picIP1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ToolStrip ToolStrip;
        internal System.Windows.Forms.MenuStrip MenuStrip;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtFacesDetected;
        internal System.Windows.Forms.PictureBox picIP2;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtPCAIteration;
        internal System.Windows.Forms.TextBox txtPCAThreshold;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txtHAARSaleFactor;
        internal System.Windows.Forms.PictureBox picFace;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton optPCA;
        internal System.Windows.Forms.Button btnReset;
        public System.Windows.Forms.Button cmdConnect;
        internal System.Windows.Forms.ComboBox cmbCOM;
        internal System.IO.Ports.SerialPort Port;
        internal System.Windows.Forms.Label lblWelcome;

    }
}



