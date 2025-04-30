namespace DVLD_Project
{
    partial class FormShowDetailsLocalDrivingLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowDetailsLocalDrivingLicenseApplication));
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlLocalDrivingLicenseApplicationInfo1 = new DVLD_Project.ctrlLocalDrivingLicenseApplicationInfo();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(770, 447);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 48);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlLocalDrivingLicenseApplicationInfo1
            // 
            this.ctrlLocalDrivingLicenseApplicationInfo1.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.ctrlLocalDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(22, 42);
            this.ctrlLocalDrivingLicenseApplicationInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlLocalDrivingLicenseApplicationInfo1.Name = "ctrlLocalDrivingLicenseApplicationInfo1";
            this.ctrlLocalDrivingLicenseApplicationInfo1.ShowLicenseInfoEnebled = true;
            this.ctrlLocalDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(865, 387);
            this.ctrlLocalDrivingLicenseApplicationInfo1.TabIndex = 5;
            // 
            // FormShowDetailsLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 507);
            this.Controls.Add(this.ctrlLocalDrivingLicenseApplicationInfo1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormShowDetailsLocalDrivingLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Details Local Driving SelectedLicense Application.";
            this.Load += new System.EventHandler(this.FormShowDetailsLocalDrivingLicenseApplication_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private ctrlLocalDrivingLicenseApplicationInfo ctrlLocalDrivingLicenseApplicationInfo1;
    }
}