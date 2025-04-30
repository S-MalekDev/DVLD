namespace DVLD_Project
{
    partial class FormAddEditPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditPerson));
            this.lblAddEditPerson = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.tbThirdName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbNationalNo = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.llblSetImage = new System.Windows.Forms.LinkLabel();
            this.llblRemove = new System.Windows.Forms.LinkLabel();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddEditPerson
            // 
            this.lblAddEditPerson.AutoSize = true;
            this.lblAddEditPerson.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold);
            this.lblAddEditPerson.ForeColor = System.Drawing.Color.Red;
            this.lblAddEditPerson.Location = new System.Drawing.Point(382, 37);
            this.lblAddEditPerson.Name = "lblAddEditPerson";
            this.lblAddEditPerson.Size = new System.Drawing.Size(305, 39);
            this.lblAddEditPerson.TabIndex = 3;
            this.lblAddEditPerson.Text = "Add New Person";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(28, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 19);
            this.label14.TabIndex = 82;
            this.label14.Text = "Person ID :";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.lblPersonID.ForeColor = System.Drawing.Color.Black;
            this.lblPersonID.Location = new System.Drawing.Point(158, 120);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(49, 19);
            this.lblPersonID.TabIndex = 83;
            this.lblPersonID.Text = "[ ?? ]";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(127, 114);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(25, 25);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 84;
            this.pictureBox11.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(62, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 19);
            this.label13.TabIndex = 44;
            this.label13.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "National No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(45, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "Gendor :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(62, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(484, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 48;
            this.label5.Text = "Country :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(503, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 49;
            this.label6.Text = "Phone :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(441, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 19);
            this.label7.TabIndex = 50;
            this.label7.Text = "Date Of Birth :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(38, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 19);
            this.label8.TabIndex = 51;
            this.label8.Text = "Address :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(127, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(127, 250);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(127, 307);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(127, 364);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 55;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(127, 421);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 56;
            this.pictureBox5.TabStop = false;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.tbFirstName.Location = new System.Drawing.Point(158, 191);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(195, 27);
            this.tbFirstName.TabIndex = 0;
            this.tbFirstName.Tag = "The First Name";
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidaton);
            // 
            // tbSecondName
            // 
            this.tbSecondName.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.tbSecondName.Location = new System.Drawing.Point(379, 191);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(195, 27);
            this.tbSecondName.TabIndex = 1;
            this.tbSecondName.Tag = "The Second Name";
            this.tbSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidaton);
            // 
            // tbThirdName
            // 
            this.tbThirdName.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.tbThirdName.Location = new System.Drawing.Point(600, 191);
            this.tbThirdName.Name = "tbThirdName";
            this.tbThirdName.Size = new System.Drawing.Size(195, 27);
            this.tbThirdName.TabIndex = 2;
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.tbLastName.Location = new System.Drawing.Point(821, 191);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(195, 27);
            this.tbLastName.TabIndex = 3;
            this.tbLastName.Tag = "The Last Name";
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidaton);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(242, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 61;
            this.label9.Text = "First";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(453, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 62;
            this.label10.Text = "Second";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(680, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 63;
            this.label11.Text = "Third";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(908, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 20);
            this.label12.TabIndex = 64;
            this.label12.Text = "Last";
            // 
            // tbNationalNo
            // 
            this.tbNationalNo.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.tbNationalNo.Location = new System.Drawing.Point(158, 248);
            this.tbNationalNo.Name = "tbNationalNo";
            this.tbNationalNo.Size = new System.Drawing.Size(195, 27);
            this.tbNationalNo.TabIndex = 4;
            this.tbNationalNo.Tag = "The National No";
            this.tbNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.tbNationalNo_Validating);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.tbEmail.Location = new System.Drawing.Point(158, 362);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(195, 27);
            this.tbEmail.TabIndex = 9;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(571, 250);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 67;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(571, 307);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(25, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 68;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(571, 364);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(25, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 69;
            this.pictureBox8.TabStop = false;
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPersonImage.Location = new System.Drawing.Point(821, 248);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(195, 217);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 70;
            this.pbPersonImage.TabStop = false;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(600, 248);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(195, 27);
            this.dtpDateOfBirth.TabIndex = 5;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.rbMale.Location = new System.Drawing.Point(158, 307);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(69, 24);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.rbFemale.Location = new System.Drawing.Point(263, 307);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(90, 24);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(233, 307);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(25, 25);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 74;
            this.pictureBox10.TabStop = false;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.tbAddress.Location = new System.Drawing.Point(158, 421);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(637, 96);
            this.tbAddress.TabIndex = 11;
            this.tbAddress.Tag = "The Address";
            this.tbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidaton);
            // 
            // llblSetImage
            // 
            this.llblSetImage.AutoSize = true;
            this.llblSetImage.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.llblSetImage.Location = new System.Drawing.Point(873, 480);
            this.llblSetImage.Name = "llblSetImage";
            this.llblSetImage.Size = new System.Drawing.Size(91, 20);
            this.llblSetImage.TabIndex = 12;
            this.llblSetImage.TabStop = true;
            this.llblSetImage.Text = "Set Image";
            this.llblSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSetImage_LinkClicked);
            // 
            // llblRemove
            // 
            this.llblRemove.AutoSize = true;
            this.llblRemove.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.llblRemove.Location = new System.Drawing.Point(879, 480);
            this.llblRemove.Name = "llblRemove";
            this.llblRemove.Size = new System.Drawing.Size(78, 20);
            this.llblRemove.TabIndex = 13;
            this.llblRemove.TabStop = true;
            this.llblRemove.Text = "Remove";
            this.llblRemove.Visible = false;
            this.llblRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRemove_LinkClicked);
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(600, 361);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(195, 28);
            this.cbCountry.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(533, 523);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 48);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(678, 523);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 48);
            this.btnSave.TabIndex = 81;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mtbPhone
            // 
            this.mtbPhone.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.mtbPhone.Location = new System.Drawing.Point(600, 305);
            this.mtbPhone.Mask = "0000 00 00 00";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(195, 27);
            this.mtbPhone.TabIndex = 8;
            this.mtbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.mtbPhone_Validating);
            // 
            // FormAddEditPerson
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1061, 606);
            this.Controls.Add(this.mtbPhone);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.llblRemove);
            this.Controls.Add(this.llblSetImage);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNationalNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbThirdName);
            this.Controls.Add(this.tbSecondName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblAddEditPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddEditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "(AddNew / Update) Person Information";
            this.Load += new System.EventHandler(this.FormAddEditPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddEditPerson;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.LinkLabel llblRemove;
        private System.Windows.Forms.LinkLabel llblSetImage;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNationalNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbThirdName;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
    }
}