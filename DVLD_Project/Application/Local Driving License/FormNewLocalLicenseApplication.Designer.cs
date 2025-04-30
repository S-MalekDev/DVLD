namespace DVLD_Project
{
    partial class FormNewLocalLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewLocalLicenseApplication));
            this.lblTitleForm = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tcAddLocalDrivingLicenseApplication = new System.Windows.Forms.TabControl();
            this.pPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonCartWithFilter1 = new DVLD_Project.ctrlPersonCartWithFilter();
            this.pApplicationInfo = new System.Windows.Forms.TabPage();
            this.lblNameOfUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.cbLicenseClasses = new System.Windows.Forms.ComboBox();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tcAddLocalDrivingLicenseApplication.SuspendLayout();
            this.pPersonalInfo.SuspendLayout();
            this.pApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.AutoSize = true;
            this.lblTitleForm.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitleForm.ForeColor = System.Drawing.Color.Red;
            this.lblTitleForm.Location = new System.Drawing.Point(194, 35);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.Size = new System.Drawing.Size(683, 39);
            this.lblTitleForm.TabIndex = 3;
            this.lblTitleForm.Text = "New Local Driving License Application";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(928, 686);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 48);
            this.btnSave.TabIndex = 5;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(805, 686);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 48);
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tcAddLocalDrivingLicenseApplication
            // 
            this.tcAddLocalDrivingLicenseApplication.Controls.Add(this.pPersonalInfo);
            this.tcAddLocalDrivingLicenseApplication.Controls.Add(this.pApplicationInfo);
            this.tcAddLocalDrivingLicenseApplication.Location = new System.Drawing.Point(26, 87);
            this.tcAddLocalDrivingLicenseApplication.Name = "tcAddLocalDrivingLicenseApplication";
            this.tcAddLocalDrivingLicenseApplication.SelectedIndex = 0;
            this.tcAddLocalDrivingLicenseApplication.Size = new System.Drawing.Size(1019, 586);
            this.tcAddLocalDrivingLicenseApplication.TabIndex = 4;
            // 
            // pPersonalInfo
            // 
            this.pPersonalInfo.BackColor = System.Drawing.SystemColors.Control;
            this.pPersonalInfo.Controls.Add(this.btnNext);
            this.pPersonalInfo.Controls.Add(this.ctrlPersonCartWithFilter1);
            this.pPersonalInfo.Location = new System.Drawing.Point(4, 29);
            this.pPersonalInfo.Name = "pPersonalInfo";
            this.pPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.pPersonalInfo.Size = new System.Drawing.Size(1011, 553);
            this.pPersonalInfo.TabIndex = 0;
            this.pPersonalInfo.Text = "Personal Info";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(871, 491);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(117, 48);
            this.btnNext.TabIndex = 1;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonCartWithFilter1
            // 
            this.ctrlPersonCartWithFilter1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ctrlPersonCartWithFilter1.EditPersonVisibled = true;
            this.ctrlPersonCartWithFilter1.FilterEnabled = true;
            this.ctrlPersonCartWithFilter1.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlPersonCartWithFilter1.Location = new System.Drawing.Point(-24, 22);
            this.ctrlPersonCartWithFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPersonCartWithFilter1.Name = "ctrlPersonCartWithFilter1";
            this.ctrlPersonCartWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCartWithFilter1.Size = new System.Drawing.Size(1021, 462);
            this.ctrlPersonCartWithFilter1.TabIndex = 0;
            this.ctrlPersonCartWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrlPersonCartWithFilter1_OnPersonSelected);
            // 
            // pApplicationInfo
            // 
            this.pApplicationInfo.BackColor = System.Drawing.SystemColors.Control;
            this.pApplicationInfo.Controls.Add(this.lblNameOfUser);
            this.pApplicationInfo.Controls.Add(this.pictureBox1);
            this.pApplicationInfo.Controls.Add(this.lblApplicationFees);
            this.pApplicationInfo.Controls.Add(this.cbLicenseClasses);
            this.pApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.pApplicationInfo.Controls.Add(this.label2);
            this.pApplicationInfo.Controls.Add(this.pictureBox4);
            this.pApplicationInfo.Controls.Add(this.pictureBox5);
            this.pApplicationInfo.Controls.Add(this.pictureBox6);
            this.pApplicationInfo.Controls.Add(this.pictureBox7);
            this.pApplicationInfo.Controls.Add(this.lblApplicationID);
            this.pApplicationInfo.Controls.Add(this.label7);
            this.pApplicationInfo.Controls.Add(this.label8);
            this.pApplicationInfo.Controls.Add(this.label9);
            this.pApplicationInfo.Controls.Add(this.label10);
            this.pApplicationInfo.Location = new System.Drawing.Point(4, 29);
            this.pApplicationInfo.Name = "pApplicationInfo";
            this.pApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.pApplicationInfo.Size = new System.Drawing.Size(1011, 553);
            this.pApplicationInfo.TabIndex = 1;
            this.pApplicationInfo.Text = "Application Info";
            // 
            // lblNameOfUser
            // 
            this.lblNameOfUser.AutoSize = true;
            this.lblNameOfUser.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.lblNameOfUser.ForeColor = System.Drawing.Color.Black;
            this.lblNameOfUser.Location = new System.Drawing.Point(302, 242);
            this.lblNameOfUser.Name = "lblNameOfUser";
            this.lblNameOfUser.Size = new System.Drawing.Size(131, 19);
            this.lblNameOfUser.TabIndex = 106;
            this.lblNameOfUser.Text = "Name Of User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(274, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.lblApplicationFees.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationFees.Location = new System.Drawing.Point(302, 198);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(31, 19);
            this.lblApplicationFees.TabIndex = 104;
            this.lblApplicationFees.Text = "00";
            // 
            // cbLicenseClasses
            // 
            this.cbLicenseClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClasses.FormattingEnabled = true;
            this.cbLicenseClasses.Location = new System.Drawing.Point(302, 145);
            this.cbLicenseClasses.Name = "cbLicenseClasses";
            this.cbLicenseClasses.Size = new System.Drawing.Size(338, 28);
            this.cbLicenseClasses.TabIndex = 103;
            this.cbLicenseClasses.SelectedIndexChanged += new System.EventHandler(this.cbLicenseClasses_SelectedIndexChanged);
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.lblApplicationDate.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationDate.Location = new System.Drawing.Point(302, 110);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(115, 19);
            this.lblApplicationDate.TabIndex = 102;
            this.lblApplicationDate.Text = "00/00/0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(157, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 101;
            this.label2.Text = "Created By :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(274, 104);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 100;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(274, 192);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 99;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(274, 60);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 98;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(274, 148);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(25, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 97;
            this.pictureBox7.TabStop = false;
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.lblApplicationID.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationID.Location = new System.Drawing.Point(302, 66);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(33, 19);
            this.lblApplicationID.TabIndex = 96;
            this.lblApplicationID.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(92, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 19);
            this.label7.TabIndex = 94;
            this.label7.Text = "D.L.Application ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(107, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 19);
            this.label8.TabIndex = 95;
            this.label8.Text = "Application Fees :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(106, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 19);
            this.label9.TabIndex = 93;
            this.label9.Text = "Application Date :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(136, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 19);
            this.label10.TabIndex = 92;
            this.label10.Text = "License Class :";
            // 
            // FormNewLocalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 760);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcAddLocalDrivingLicenseApplication);
            this.Controls.Add(this.lblTitleForm);
            this.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNewLocalLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Local Driving License Application.";
            this.Activated += new System.EventHandler(this.FormNewLocalLicenseApplication_Activated);
            this.Load += new System.EventHandler(this.FormNewLocalLicenseApplication_Load);
            this.tcAddLocalDrivingLicenseApplication.ResumeLayout(false);
            this.pPersonalInfo.ResumeLayout(false);
            this.pApplicationInfo.ResumeLayout(false);
            this.pApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitleForm;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tcAddLocalDrivingLicenseApplication;
        private System.Windows.Forms.TabPage pPersonalInfo;
        private System.Windows.Forms.Button btnNext;
        private ctrlPersonCartWithFilter ctrlPersonCartWithFilter1;
        private System.Windows.Forms.TabPage pApplicationInfo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNameOfUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.ComboBox cbLicenseClasses;
    }
}