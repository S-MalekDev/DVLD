namespace DVLD_Project
{
    partial class FormRenewLocalDrivingLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRenewLocalDrivingLicense));
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlDrivingLicenseInfoWithFilter1 = new DVLD_Project.ctrlDrivingLicenseInfoWithFilter();
            this.llblShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.llblShowNewLicneseInfo = new System.Windows.Forms.LinkLabel();
            this.gbAppNewLicenseInfo = new System.Windows.Forms.GroupBox();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCreatedByUserName = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblRenewLicenseID = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblRenewLicenseAppID = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLicenseFees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.pbGender = new System.Windows.Forms.PictureBox();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRenew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbAppNewLicenseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGender)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 39);
            this.label1.TabIndex = 35;
            this.label1.Text = "Renew License Application";
            // 
            // ctrlDrivingLicenseInfoWithFilter1
            // 
            this.ctrlDrivingLicenseInfoWithFilter1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ctrlDrivingLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDrivingLicenseInfoWithFilter1.Location = new System.Drawing.Point(7, 52);
            this.ctrlDrivingLicenseInfoWithFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlDrivingLicenseInfoWithFilter1.Name = "ctrlDrivingLicenseInfoWithFilter1";
            this.ctrlDrivingLicenseInfoWithFilter1.Size = new System.Drawing.Size(955, 408);
            this.ctrlDrivingLicenseInfoWithFilter1.TabIndex = 36;
            this.ctrlDrivingLicenseInfoWithFilter1.OnSelectedLicense += new System.Action<int>(this.ctrlDrivingLicenseInfoWithFilter1_OnSelectedLicense);
            // 
            // llblShowLicensesHistory
            // 
            this.llblShowLicensesHistory.AutoSize = true;
            this.llblShowLicensesHistory.Enabled = false;
            this.llblShowLicensesHistory.Location = new System.Drawing.Point(12, 753);
            this.llblShowLicensesHistory.Name = "llblShowLicensesHistory";
            this.llblShowLicensesHistory.Size = new System.Drawing.Size(199, 20);
            this.llblShowLicensesHistory.TabIndex = 37;
            this.llblShowLicensesHistory.TabStop = true;
            this.llblShowLicensesHistory.Text = "Show Licenses History";
            this.llblShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowLicensesHistory_LinkClicked);
            // 
            // llblShowNewLicneseInfo
            // 
            this.llblShowNewLicneseInfo.AutoSize = true;
            this.llblShowNewLicneseInfo.Enabled = false;
            this.llblShowNewLicneseInfo.Location = new System.Drawing.Point(241, 753);
            this.llblShowNewLicneseInfo.Name = "llblShowNewLicneseInfo";
            this.llblShowNewLicneseInfo.Size = new System.Drawing.Size(200, 20);
            this.llblShowNewLicneseInfo.TabIndex = 38;
            this.llblShowNewLicneseInfo.TabStop = true;
            this.llblShowNewLicneseInfo.Text = "Show New License Info";
            this.llblShowNewLicneseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowNewLicneseInfo_LinkClicked);
            // 
            // gbAppNewLicenseInfo
            // 
            this.gbAppNewLicenseInfo.Controls.Add(this.tbNotes);
            this.gbAppNewLicenseInfo.Controls.Add(this.pictureBox8);
            this.gbAppNewLicenseInfo.Controls.Add(this.pictureBox6);
            this.gbAppNewLicenseInfo.Controls.Add(this.pictureBox4);
            this.gbAppNewLicenseInfo.Controls.Add(this.pictureBox3);
            this.gbAppNewLicenseInfo.Controls.Add(this.pictureBox1);
            this.gbAppNewLicenseInfo.Controls.Add(this.pictureBox19);
            this.gbAppNewLicenseInfo.Controls.Add(this.pictureBox18);
            this.gbAppNewLicenseInfo.Controls.Add(this.pictureBox17);
            this.gbAppNewLicenseInfo.Controls.Add(this.pictureBox13);
            this.gbAppNewLicenseInfo.Controls.Add(this.lblTotalFees);
            this.gbAppNewLicenseInfo.Controls.Add(this.label8);
            this.gbAppNewLicenseInfo.Controls.Add(this.label9);
            this.gbAppNewLicenseInfo.Controls.Add(this.lblExpirationDate);
            this.gbAppNewLicenseInfo.Controls.Add(this.lblOldLicenseID);
            this.gbAppNewLicenseInfo.Controls.Add(this.label12);
            this.gbAppNewLicenseInfo.Controls.Add(this.label13);
            this.gbAppNewLicenseInfo.Controls.Add(this.lblCreatedByUserName);
            this.gbAppNewLicenseInfo.Controls.Add(this.label15);
            this.gbAppNewLicenseInfo.Controls.Add(this.lblRenewLicenseID);
            this.gbAppNewLicenseInfo.Controls.Add(this.label22);
            this.gbAppNewLicenseInfo.Controls.Add(this.lblRenewLicenseAppID);
            this.gbAppNewLicenseInfo.Controls.Add(this.lblAppFees);
            this.gbAppNewLicenseInfo.Controls.Add(this.label6);
            this.gbAppNewLicenseInfo.Controls.Add(this.pictureBox11);
            this.gbAppNewLicenseInfo.Controls.Add(this.label5);
            this.gbAppNewLicenseInfo.Controls.Add(this.lblLicenseFees);
            this.gbAppNewLicenseInfo.Controls.Add(this.label4);
            this.gbAppNewLicenseInfo.Controls.Add(this.lblAppDate);
            this.gbAppNewLicenseInfo.Controls.Add(this.pbGender);
            this.gbAppNewLicenseInfo.Controls.Add(this.lblIssueDate);
            this.gbAppNewLicenseInfo.Controls.Add(this.label2);
            this.gbAppNewLicenseInfo.Controls.Add(this.label3);
            this.gbAppNewLicenseInfo.Location = new System.Drawing.Point(7, 460);
            this.gbAppNewLicenseInfo.Name = "gbAppNewLicenseInfo";
            this.gbAppNewLicenseInfo.Size = new System.Drawing.Size(940, 280);
            this.gbAppNewLicenseInfo.TabIndex = 39;
            this.gbAppNewLicenseInfo.TabStop = false;
            this.gbAppNewLicenseInfo.Text = "Application New License Info";
            this.gbAppNewLicenseInfo.Visible = false;
            // 
            // tbNotes
            // 
            this.tbNotes.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNotes.Location = new System.Drawing.Point(166, 207);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(489, 58);
            this.tbNotes.TabIndex = 281;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(630, 173);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(25, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 280;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(135, 174);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 279;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(135, 78);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 278;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(135, 110);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 277;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 276;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(630, 45);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(25, 25);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox19.TabIndex = 274;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(630, 109);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(25, 25);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox18.TabIndex = 273;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(630, 141);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(25, 25);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox17.TabIndex = 272;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(135, 206);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(25, 25);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 270;
            this.pictureBox13.TabStop = false;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalFees.Location = new System.Drawing.Point(658, 179);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(57, 19);
            this.lblTotalFees.TabIndex = 268;
            this.lblTotalFees.Text = "[ ??? ]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(525, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 19);
            this.label8.TabIndex = 266;
            this.label8.Text = "Total Fees:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(519, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 19);
            this.label9.TabIndex = 265;
            this.label9.Text = "Created By:";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.lblExpirationDate.Location = new System.Drawing.Point(658, 115);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(57, 19);
            this.lblExpirationDate.TabIndex = 269;
            this.lblExpirationDate.Text = "[ ??? ]";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.lblOldLicenseID.Location = new System.Drawing.Point(658, 83);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(57, 19);
            this.lblOldLicenseID.TabIndex = 262;
            this.lblOldLicenseID.Text = "[ ??? ]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(480, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 19);
            this.label12.TabIndex = 261;
            this.label12.Text = "Expiration Date:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(487, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 19);
            this.label13.TabIndex = 260;
            this.label13.Text = "Old License ID:";
            // 
            // lblCreatedByUserName
            // 
            this.lblCreatedByUserName.AutoSize = true;
            this.lblCreatedByUserName.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.lblCreatedByUserName.Location = new System.Drawing.Point(658, 147);
            this.lblCreatedByUserName.Name = "lblCreatedByUserName";
            this.lblCreatedByUserName.Size = new System.Drawing.Size(57, 19);
            this.lblCreatedByUserName.TabIndex = 263;
            this.lblCreatedByUserName.Text = "[ ??? ]";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(438, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(192, 19);
            this.label15.TabIndex = 259;
            this.label15.Text = "Renewed License ID:";
            // 
            // lblRenewLicenseID
            // 
            this.lblRenewLicenseID.AutoSize = true;
            this.lblRenewLicenseID.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.lblRenewLicenseID.Location = new System.Drawing.Point(658, 51);
            this.lblRenewLicenseID.Name = "lblRenewLicenseID";
            this.lblRenewLicenseID.Size = new System.Drawing.Size(57, 19);
            this.lblRenewLicenseID.TabIndex = 264;
            this.lblRenewLicenseID.Text = "[ ??? ]";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(73, 212);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 19);
            this.label22.TabIndex = 252;
            this.label22.Text = "Notes:";
            // 
            // lblRenewLicenseAppID
            // 
            this.lblRenewLicenseAppID.AutoSize = true;
            this.lblRenewLicenseAppID.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.lblRenewLicenseAppID.Location = new System.Drawing.Point(166, 52);
            this.lblRenewLicenseAppID.Name = "lblRenewLicenseAppID";
            this.lblRenewLicenseAppID.Size = new System.Drawing.Size(57, 19);
            this.lblRenewLicenseAppID.TabIndex = 245;
            this.lblRenewLicenseAppID.Text = "[ ??? ]";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppFees.Location = new System.Drawing.Point(166, 148);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(57, 19);
            this.lblAppFees.TabIndex = 246;
            this.lblAppFees.Text = "[ ??? ]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(13, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 19);
            this.label6.TabIndex = 241;
            this.label6.Text = "License Fees:";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(135, 142);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(25, 25);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 244;
            this.pictureBox11.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(44, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 240;
            this.label5.Text = "App Fees:";
            // 
            // lblLicenseFees
            // 
            this.lblLicenseFees.AutoSize = true;
            this.lblLicenseFees.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.lblLicenseFees.Location = new System.Drawing.Point(166, 180);
            this.lblLicenseFees.Name = "lblLicenseFees";
            this.lblLicenseFees.Size = new System.Drawing.Size(57, 19);
            this.lblLicenseFees.TabIndex = 247;
            this.lblLicenseFees.Text = "[ ??? ]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(32, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 239;
            this.label4.Text = "Issue Date:";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAppDate.Location = new System.Drawing.Point(166, 84);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(57, 19);
            this.lblAppDate.TabIndex = 248;
            this.lblAppDate.Text = "[ ??? ]";
            // 
            // pbGender
            // 
            this.pbGender.Image = ((System.Drawing.Image)(resources.GetObject("pbGender.Image")));
            this.pbGender.Location = new System.Drawing.Point(630, 77);
            this.pbGender.Name = "pbGender";
            this.pbGender.Size = new System.Drawing.Size(25, 25);
            this.pbGender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGender.TabIndex = 243;
            this.pbGender.TabStop = false;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.lblIssueDate.Location = new System.Drawing.Point(166, 116);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(57, 19);
            this.lblIssueDate.TabIndex = 249;
            this.lblIssueDate.Text = "[ ??? ]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(31, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 238;
            this.label2.Text = "R.L.App ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(43, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 237;
            this.label3.Text = "App Date:";
            // 
            // btnRenew
            // 
            this.btnRenew.Enabled = false;
            this.btnRenew.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenew.Image = ((System.Drawing.Image)(resources.GetObject("btnRenew.Image")));
            this.btnRenew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenew.Location = new System.Drawing.Point(830, 753);
            this.btnRenew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(117, 48);
            this.btnRenew.TabIndex = 206;
            this.btnRenew.Text = "Renew";
            this.btnRenew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.EnabledChanged += new System.EventHandler(this.btnRenew_EnabledChanged);
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(707, 753);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 48);
            this.btnClose.TabIndex = 205;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormRenewLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 806);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbAppNewLicenseInfo);
            this.Controls.Add(this.llblShowNewLicneseInfo);
            this.Controls.Add(this.llblShowLicensesHistory);
            this.Controls.Add(this.ctrlDrivingLicenseInfoWithFilter1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRenewLocalDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renew License Application";
            this.Activated += new System.EventHandler(this.FormRenewLocalDrivingLicense_Activated);
            this.Load += new System.EventHandler(this.FormRenewLocalDrivingLicense_Load);
            this.gbAppNewLicenseInfo.ResumeLayout(false);
            this.gbAppNewLicenseInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private ctrlDrivingLicenseInfoWithFilter ctrlDrivingLicenseInfoWithFilter1;
        private System.Windows.Forms.LinkLabel llblShowLicensesHistory;
        private System.Windows.Forms.LinkLabel llblShowNewLicneseInfo;
        private System.Windows.Forms.GroupBox gbAppNewLicenseInfo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCreatedByUserName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblRenewLicenseID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblRenewLicenseAppID;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLicenseFees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.PictureBox pbGender;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Button btnClose;
    }
}