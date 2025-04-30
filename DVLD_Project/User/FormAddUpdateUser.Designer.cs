namespace DVLD_Project.User
{
    partial class FormAddUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUpdateUser));
            this.lblAddUpdateUser = new System.Windows.Forms.Label();
            this.tcAddNewUser = new System.Windows.Forms.TabControl();
            this.PersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonCartWithFilter1 = new DVLD_Project.ctrlPersonCartWithFilter();
            this.LoginInfo = new System.Windows.Forms.TabPage();
            this.plLoginInfo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.chbIsActive = new System.Windows.Forms.CheckBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tcAddNewUser.SuspendLayout();
            this.PersonalInfo.SuspendLayout();
            this.LoginInfo.SuspendLayout();
            this.plLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddUpdateUser
            // 
            this.lblAddUpdateUser.AutoSize = true;
            this.lblAddUpdateUser.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold);
            this.lblAddUpdateUser.ForeColor = System.Drawing.Color.Red;
            this.lblAddUpdateUser.Location = new System.Drawing.Point(416, 46);
            this.lblAddUpdateUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddUpdateUser.Name = "lblAddUpdateUser";
            this.lblAddUpdateUser.Size = new System.Drawing.Size(264, 39);
            this.lblAddUpdateUser.TabIndex = 4;
            this.lblAddUpdateUser.Text = "Add New User";
            // 
            // tcAddNewUser
            // 
            this.tcAddNewUser.Controls.Add(this.PersonalInfo);
            this.tcAddNewUser.Controls.Add(this.LoginInfo);
            this.tcAddNewUser.Location = new System.Drawing.Point(39, 101);
            this.tcAddNewUser.Name = "tcAddNewUser";
            this.tcAddNewUser.SelectedIndex = 0;
            this.tcAddNewUser.Size = new System.Drawing.Size(1019, 586);
            this.tcAddNewUser.TabIndex = 0;
            // 
            // PersonalInfo
            // 
            this.PersonalInfo.BackColor = System.Drawing.SystemColors.Control;
            this.PersonalInfo.Controls.Add(this.btnNext);
            this.PersonalInfo.Controls.Add(this.ctrlPersonCartWithFilter1);
            this.PersonalInfo.Location = new System.Drawing.Point(4, 29);
            this.PersonalInfo.Name = "PersonalInfo";
            this.PersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.PersonalInfo.Size = new System.Drawing.Size(1011, 553);
            this.PersonalInfo.TabIndex = 0;
            this.PersonalInfo.Text = "Personal Info";
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
            // LoginInfo
            // 
            this.LoginInfo.BackColor = System.Drawing.SystemColors.Control;
            this.LoginInfo.Controls.Add(this.plLoginInfo);
            this.LoginInfo.Location = new System.Drawing.Point(4, 29);
            this.LoginInfo.Name = "LoginInfo";
            this.LoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.LoginInfo.Size = new System.Drawing.Size(1011, 553);
            this.LoginInfo.TabIndex = 1;
            this.LoginInfo.Text = "Login Info";
            // 
            // plLoginInfo
            // 
            this.plLoginInfo.Controls.Add(this.pictureBox3);
            this.plLoginInfo.Controls.Add(this.pictureBox2);
            this.plLoginInfo.Controls.Add(this.pictureBox1);
            this.plLoginInfo.Controls.Add(this.pictureBox11);
            this.plLoginInfo.Controls.Add(this.chbIsActive);
            this.plLoginInfo.Controls.Add(this.tbUsername);
            this.plLoginInfo.Controls.Add(this.lblUserID);
            this.plLoginInfo.Controls.Add(this.label3);
            this.plLoginInfo.Controls.Add(this.label4);
            this.plLoginInfo.Controls.Add(this.tbConfirmPassword);
            this.plLoginInfo.Controls.Add(this.label1);
            this.plLoginInfo.Controls.Add(this.label2);
            this.plLoginInfo.Controls.Add(this.tbPassword);
            this.plLoginInfo.Location = new System.Drawing.Point(12, 32);
            this.plLoginInfo.Name = "plLoginInfo";
            this.plLoginInfo.Size = new System.Drawing.Size(561, 288);
            this.plLoginInfo.TabIndex = 55;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(216, 64);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 88;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(216, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 87;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(216, 111);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(25, 25);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 85;
            this.pictureBox11.TabStop = false;
            // 
            // chbIsActive
            // 
            this.chbIsActive.AutoSize = true;
            this.chbIsActive.Checked = true;
            this.chbIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsActive.Location = new System.Drawing.Point(307, 225);
            this.chbIsActive.Name = "chbIsActive";
            this.chbIsActive.Size = new System.Drawing.Size(104, 24);
            this.chbIsActive.TabIndex = 55;
            this.chbIsActive.Text = "Is Active";
            this.chbIsActive.UseVisualStyleBackColor = true;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.tbUsername.Location = new System.Drawing.Point(244, 62);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(195, 27);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.Tag = "";
            this.tbUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tbUsername_Validating);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.lblUserID.ForeColor = System.Drawing.Color.Black;
            this.lblUserID.Location = new System.Drawing.Point(244, 23);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(33, 19);
            this.lblUserID.TabIndex = 54;
            this.lblUserID.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(131, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "User ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(34, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "Confirm Password :";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.tbConfirmPassword.Location = new System.Drawing.Point(244, 156);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(195, 27);
            this.tbConfirmPassword.TabIndex = 2;
            this.tbConfirmPassword.Tag = "";
            this.tbConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbConfirmPassword_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(109, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(112, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "Password :";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.tbPassword.Location = new System.Drawing.Point(244, 109);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(195, 27);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Tag = "";
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(941, 700);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 48);
            this.btnSave.TabIndex = 2;
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
            this.btnClose.Location = new System.Drawing.Point(818, 700);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 48);
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormAddUpdateUser
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1100, 760);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcAddNewUser);
            this.Controls.Add(this.lblAddUpdateUser);
            this.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.FormAddUpdateUser_Load);
            this.tcAddNewUser.ResumeLayout(false);
            this.PersonalInfo.ResumeLayout(false);
            this.LoginInfo.ResumeLayout(false);
            this.plLoginInfo.ResumeLayout(false);
            this.plLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddUpdateUser;
        private System.Windows.Forms.TabControl tcAddNewUser;
        private System.Windows.Forms.TabPage PersonalInfo;
        private System.Windows.Forms.TabPage LoginInfo;
        private ctrlPersonCartWithFilter ctrlPersonCartWithFilter1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Panel plLoginInfo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox chbIsActive;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}