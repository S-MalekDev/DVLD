namespace DVLD_Project
{
    partial class FormLicensesHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLicensesHistory));
            this.lblAppointmentTittle = new System.Windows.Forms.Label();
            this.pbTestImage = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlDriverLicensesHistory1 = new DVLD_Project.ctrlDriverLicensesHistory();
            this.ctrlPersonCartWithFilter1 = new DVLD_Project.ctrlPersonCartWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppointmentTittle
            // 
            this.lblAppointmentTittle.AutoSize = true;
            this.lblAppointmentTittle.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold);
            this.lblAppointmentTittle.ForeColor = System.Drawing.Color.Red;
            this.lblAppointmentTittle.Location = new System.Drawing.Point(351, 150);
            this.lblAppointmentTittle.Name = "lblAppointmentTittle";
            this.lblAppointmentTittle.Size = new System.Drawing.Size(304, 39);
            this.lblAppointmentTittle.TabIndex = 34;
            this.lblAppointmentTittle.Text = "Licenses History";
            // 
            // pbTestImage
            // 
            this.pbTestImage.Image = ((System.Drawing.Image)(resources.GetObject("pbTestImage.Image")));
            this.pbTestImage.Location = new System.Drawing.Point(415, -2);
            this.pbTestImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbTestImage.Name = "pbTestImage";
            this.pbTestImage.Size = new System.Drawing.Size(177, 153);
            this.pbTestImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestImage.TabIndex = 35;
            this.pbTestImage.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(871, 903);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 48);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlDriverLicensesHistory1
            // 
            this.ctrlDriverLicensesHistory1.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.ctrlDriverLicensesHistory1.Location = new System.Drawing.Point(9, 622);
            this.ctrlDriverLicensesHistory1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlDriverLicensesHistory1.Name = "ctrlDriverLicensesHistory1";
            this.ctrlDriverLicensesHistory1.Size = new System.Drawing.Size(979, 273);
            this.ctrlDriverLicensesHistory1.TabIndex = 41;
            // 
            // ctrlPersonCartWithFilter1
            // 
            this.ctrlPersonCartWithFilter1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ctrlPersonCartWithFilter1.EditPersonVisibled = true;
            this.ctrlPersonCartWithFilter1.FilterEnabled = true;
            this.ctrlPersonCartWithFilter1.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlPersonCartWithFilter1.Location = new System.Drawing.Point(-25, 166);
            this.ctrlPersonCartWithFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPersonCartWithFilter1.Name = "ctrlPersonCartWithFilter1";
            this.ctrlPersonCartWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCartWithFilter1.Size = new System.Drawing.Size(1057, 470);
            this.ctrlPersonCartWithFilter1.TabIndex = 36;
            // 
            // FormLicensesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 964);
            this.Controls.Add(this.lblAppointmentTittle);
            this.Controls.Add(this.ctrlDriverLicensesHistory1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlPersonCartWithFilter1);
            this.Controls.Add(this.pbTestImage);
            this.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLicensesHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licenses History";
            this.Load += new System.EventHandler(this.FormLicensesHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppointmentTittle;
        private System.Windows.Forms.PictureBox pbTestImage;
        private ctrlPersonCartWithFilter ctrlPersonCartWithFilter1;
        private System.Windows.Forms.Button btnClose;
        private ctrlDriverLicensesHistory ctrlDriverLicensesHistory1;
    }
}