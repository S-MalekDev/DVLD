namespace DVLD_Project
{
    partial class ctrlDrivingLicenseInfoWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlDrivingLicenseInfoWithFilter));
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlShowLicneseInfo1 = new DVLD_Project.ctrlShowLicneseInfo();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnFilter);
            this.gbFilter.Controls.Add(this.tbFilter);
            this.gbFilter.Controls.Add(this.label2);
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(908, 59);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFilter.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.Location = new System.Drawing.Point(489, 19);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(39, 35);
            this.btnFilter.TabIndex = 175;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.tbFilter.Location = new System.Drawing.Point(133, 23);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(324, 27);
            this.tbFilter.TabIndex = 174;
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            this.tbFilter.Validating += new System.ComponentModel.CancelEventHandler(this.tbFilter_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(16, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 173;
            this.label2.Text = "License ID :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlShowLicneseInfo1
            // 
            this.ctrlShowLicneseInfo1.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlShowLicneseInfo1.Location = new System.Drawing.Point(0, 69);
            this.ctrlShowLicneseInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlShowLicneseInfo1.Name = "ctrlShowLicneseInfo1";
            this.ctrlShowLicneseInfo1.Size = new System.Drawing.Size(943, 328);
            this.ctrlShowLicneseInfo1.TabIndex = 0;
            // 
            // ctrlDrivingLicenseInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlShowLicneseInfo1);
            this.Name = "ctrlDrivingLicenseInfoWithFilter";
            this.Size = new System.Drawing.Size(955, 408);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlShowLicneseInfo ctrlShowLicneseInfo1;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
