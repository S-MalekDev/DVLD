namespace DVLD_Project
{
    partial class FormFindPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFindPerson));
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlPersonCartWithFilter1 = new DVLD_Project.ctrlPersonCartWithFilter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(430, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "FindByUserID Person";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(907, 542);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 48);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlPersonCartWithFilter1
            // 
            this.ctrlPersonCartWithFilter1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ctrlPersonCartWithFilter1.FilterEnabled = true;
            this.ctrlPersonCartWithFilter1.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlPersonCartWithFilter1.Location = new System.Drawing.Point(13, 65);
            this.ctrlPersonCartWithFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPersonCartWithFilter1.Name = "ctrlPersonCartWithFilter1";
            this.ctrlPersonCartWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCartWithFilter1.Size = new System.Drawing.Size(1057, 470);
            this.ctrlPersonCartWithFilter1.TabIndex = 5;
            this.ctrlPersonCartWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrlPersonCartWithFilter1_OnPersonSelected);
            // 
            // FormFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 615);
            this.Controls.Add(this.ctrlPersonCartWithFilter1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFindPerson";
            this.Text = "FindByUserID Person.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private ctrlPersonCartWithFilter ctrlPersonCartWithFilter1;
    }
}