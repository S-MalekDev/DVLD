namespace DVLD_Project
{
    partial class FormScheduleTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScheduleTest));
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlSchedultTest1 = new DVLD_Project.ctrlSchedultTest();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(250, 725);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 48);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlSchedultTest1
            // 
            this.ctrlSchedultTest1.Location = new System.Drawing.Point(3, 3);
            this.ctrlSchedultTest1.Name = "ctrlSchedultTest1";
            this.ctrlSchedultTest1.SelectedTestType = DVLD_BusinessLayer.clsTestType.enTestType.VisionTest;
            this.ctrlSchedultTest1.Size = new System.Drawing.Size(610, 721);
            this.ctrlSchedultTest1.TabIndex = 38;
            // 
            // FormScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 776);
            this.Controls.Add(this.ctrlSchedultTest1);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormScheduleTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shcedule Test.";
            this.Load += new System.EventHandler(this.FormScheduleTest_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private ctrlSchedultTest ctrlSchedultTest1;
    }
}