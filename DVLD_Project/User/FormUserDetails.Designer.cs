namespace DVLD_Project.User
{
    partial class FormUserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserDetails));
            this.lblUserDetails = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlUserDetails1 = new DVLD_Project.User.ctrlUserDetails();
            this.SuspendLayout();
            // 
            // lblUserDetails
            // 
            this.lblUserDetails.AutoSize = true;
            this.lblUserDetails.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold);
            this.lblUserDetails.ForeColor = System.Drawing.Color.Red;
            this.lblUserDetails.Location = new System.Drawing.Point(394, 46);
            this.lblUserDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserDetails.Name = "lblUserDetails";
            this.lblUserDetails.Size = new System.Drawing.Size(223, 39);
            this.lblUserDetails.TabIndex = 5;
            this.lblUserDetails.Text = "User Details";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(873, 512);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 48);
            this.btnClose.TabIndex = 7;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlUserDetails1
            // 
            this.ctrlUserDetails1.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlUserDetails1.Location = new System.Drawing.Point(13, 89);
            this.ctrlUserDetails1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlUserDetails1.Name = "ctrlUserDetails1";
            this.ctrlUserDetails1.Size = new System.Drawing.Size(984, 416);
            this.ctrlUserDetails1.TabIndex = 6;
            this.ctrlUserDetails1.VisibleEditPerson = true;
            // 
            // FormUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 577);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlUserDetails1);
            this.Controls.Add(this.lblUserDetails);
            this.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUserDetails";
            this.Text = "User Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserDetails;
        private ctrlUserDetails ctrlUserDetails1;
        private System.Windows.Forms.Button btnClose;
    }
}