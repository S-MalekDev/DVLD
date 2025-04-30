namespace DVLD_Project
{
    partial class ctrlDriverLicensesHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlDriverLicensesHistory));
            this.gbDriverLicenses = new System.Windows.Forms.GroupBox();
            this.TbDriverLicenses = new System.Windows.Forms.TabControl();
            this.tpLocalLicenses = new System.Windows.Forms.TabPage();
            this.lblNumberRecordsLocalLicenses = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLocalLicensesHistory = new System.Windows.Forms.DataGridView();
            this.tpInternationalLicenses = new System.Windows.Forms.TabPage();
            this.lblNumberRecordsInternationalLicenses = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvInternationalLicenseHistory = new System.Windows.Forms.DataGridView();
            this.cmsDriversLocalLicenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowLicenseInfo_Tool_cmsLocalLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDriversInternationalLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowLicenseInfo_Tool_cmsInternationalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.gbDriverLicenses.SuspendLayout();
            this.TbDriverLicenses.SuspendLayout();
            this.tpLocalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesHistory)).BeginInit();
            this.tpInternationalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenseHistory)).BeginInit();
            this.cmsDriversLocalLicenses.SuspendLayout();
            this.cmsDriversInternationalLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDriverLicenses
            // 
            this.gbDriverLicenses.Controls.Add(this.TbDriverLicenses);
            this.gbDriverLicenses.Location = new System.Drawing.Point(5, 5);
            this.gbDriverLicenses.Name = "gbDriverLicenses";
            this.gbDriverLicenses.Size = new System.Drawing.Size(970, 259);
            this.gbDriverLicenses.TabIndex = 39;
            this.gbDriverLicenses.TabStop = false;
            this.gbDriverLicenses.Text = "Driver Licenses";
            // 
            // TbDriverLicenses
            // 
            this.TbDriverLicenses.Controls.Add(this.tpLocalLicenses);
            this.TbDriverLicenses.Controls.Add(this.tpInternationalLicenses);
            this.TbDriverLicenses.Location = new System.Drawing.Point(22, 27);
            this.TbDriverLicenses.Name = "TbDriverLicenses";
            this.TbDriverLicenses.SelectedIndex = 0;
            this.TbDriverLicenses.Size = new System.Drawing.Size(942, 226);
            this.TbDriverLicenses.TabIndex = 37;
            // 
            // tpLocalLicenses
            // 
            this.tpLocalLicenses.BackColor = System.Drawing.SystemColors.Control;
            this.tpLocalLicenses.Controls.Add(this.lblNumberRecordsLocalLicenses);
            this.tpLocalLicenses.Controls.Add(this.label2);
            this.tpLocalLicenses.Controls.Add(this.label1);
            this.tpLocalLicenses.Controls.Add(this.dgvLocalLicensesHistory);
            this.tpLocalLicenses.ForeColor = System.Drawing.Color.Black;
            this.tpLocalLicenses.Location = new System.Drawing.Point(4, 29);
            this.tpLocalLicenses.Name = "tpLocalLicenses";
            this.tpLocalLicenses.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocalLicenses.Size = new System.Drawing.Size(934, 193);
            this.tpLocalLicenses.TabIndex = 0;
            this.tpLocalLicenses.Text = "Local";
            // 
            // lblNumberRecordsLocalLicenses
            // 
            this.lblNumberRecordsLocalLicenses.AutoSize = true;
            this.lblNumberRecordsLocalLicenses.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNumberRecordsLocalLicenses.Location = new System.Drawing.Point(108, 161);
            this.lblNumberRecordsLocalLicenses.Name = "lblNumberRecordsLocalLicenses";
            this.lblNumberRecordsLocalLicenses.Size = new System.Drawing.Size(31, 19);
            this.lblNumberRecordsLocalLicenses.TabIndex = 74;
            this.lblNumberRecordsLocalLicenses.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 73;
            this.label2.Text = "# Records :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 72;
            this.label1.Text = "Local Licenses History:";
            // 
            // dgvLocalLicensesHistory
            // 
            this.dgvLocalLicensesHistory.AllowUserToAddRows = false;
            this.dgvLocalLicensesHistory.AllowUserToDeleteRows = false;
            this.dgvLocalLicensesHistory.AllowUserToResizeRows = false;
            this.dgvLocalLicensesHistory.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLocalLicensesHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalLicensesHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocalLicensesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicensesHistory.ContextMenuStrip = this.cmsDriversLocalLicenses;
            this.dgvLocalLicensesHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLocalLicensesHistory.Location = new System.Drawing.Point(10, 35);
            this.dgvLocalLicensesHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLocalLicensesHistory.Name = "dgvLocalLicensesHistory";
            this.dgvLocalLicensesHistory.ReadOnly = true;
            this.dgvLocalLicensesHistory.RowHeadersWidth = 30;
            this.dgvLocalLicensesHistory.RowTemplate.Height = 24;
            this.dgvLocalLicensesHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalLicensesHistory.ShowCellErrors = false;
            this.dgvLocalLicensesHistory.ShowCellToolTips = false;
            this.dgvLocalLicensesHistory.Size = new System.Drawing.Size(922, 122);
            this.dgvLocalLicensesHistory.TabIndex = 71;
            // 
            // tpInternationalLicenses
            // 
            this.tpInternationalLicenses.BackColor = System.Drawing.SystemColors.Control;
            this.tpInternationalLicenses.Controls.Add(this.lblNumberRecordsInternationalLicenses);
            this.tpInternationalLicenses.Controls.Add(this.label4);
            this.tpInternationalLicenses.Controls.Add(this.label5);
            this.tpInternationalLicenses.Controls.Add(this.dgvInternationalLicenseHistory);
            this.tpInternationalLicenses.Location = new System.Drawing.Point(4, 29);
            this.tpInternationalLicenses.Name = "tpInternationalLicenses";
            this.tpInternationalLicenses.Padding = new System.Windows.Forms.Padding(3);
            this.tpInternationalLicenses.Size = new System.Drawing.Size(934, 193);
            this.tpInternationalLicenses.TabIndex = 1;
            this.tpInternationalLicenses.Text = "International";
            // 
            // lblNumberRecordsInternationalLicenses
            // 
            this.lblNumberRecordsInternationalLicenses.AutoSize = true;
            this.lblNumberRecordsInternationalLicenses.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNumberRecordsInternationalLicenses.Location = new System.Drawing.Point(108, 161);
            this.lblNumberRecordsInternationalLicenses.Name = "lblNumberRecordsInternationalLicenses";
            this.lblNumberRecordsInternationalLicenses.Size = new System.Drawing.Size(31, 19);
            this.lblNumberRecordsInternationalLicenses.TabIndex = 78;
            this.lblNumberRecordsInternationalLicenses.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 77;
            this.label4.Text = "# Records :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 20);
            this.label5.TabIndex = 76;
            this.label5.Text = "International Licenses History:";
            // 
            // dgvInternationalLicenseHistory
            // 
            this.dgvInternationalLicenseHistory.AllowUserToAddRows = false;
            this.dgvInternationalLicenseHistory.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenseHistory.AllowUserToResizeRows = false;
            this.dgvInternationalLicenseHistory.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInternationalLicenseHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternationalLicenseHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInternationalLicenseHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenseHistory.ContextMenuStrip = this.cmsDriversInternationalLicense;
            this.dgvInternationalLicenseHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInternationalLicenseHistory.Location = new System.Drawing.Point(6, 35);
            this.dgvInternationalLicenseHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInternationalLicenseHistory.Name = "dgvInternationalLicenseHistory";
            this.dgvInternationalLicenseHistory.ReadOnly = true;
            this.dgvInternationalLicenseHistory.RowHeadersWidth = 30;
            this.dgvInternationalLicenseHistory.RowTemplate.Height = 24;
            this.dgvInternationalLicenseHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternationalLicenseHistory.ShowCellErrors = false;
            this.dgvInternationalLicenseHistory.ShowCellToolTips = false;
            this.dgvInternationalLicenseHistory.Size = new System.Drawing.Size(922, 122);
            this.dgvInternationalLicenseHistory.TabIndex = 75;
            // 
            // cmsDriversLocalLicenses
            // 
            this.cmsDriversLocalLicenses.Font = new System.Drawing.Font("Lucida Bright", 8F);
            this.cmsDriversLocalLicenses.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsDriversLocalLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowLicenseInfo_Tool_cmsLocalLicenses});
            this.cmsDriversLocalLicenses.Name = "contextMenuStrip1";
            this.cmsDriversLocalLicenses.Size = new System.Drawing.Size(215, 42);
            // 
            // ShowLicenseInfo_Tool_cmsLocalLicenses
            // 
            this.ShowLicenseInfo_Tool_cmsLocalLicenses.Image = ((System.Drawing.Image)(resources.GetObject("ShowLicenseInfo_Tool_cmsLocalLicenses.Image")));
            this.ShowLicenseInfo_Tool_cmsLocalLicenses.Name = "ShowLicenseInfo_Tool_cmsLocalLicenses";
            this.ShowLicenseInfo_Tool_cmsLocalLicenses.Size = new System.Drawing.Size(214, 38);
            this.ShowLicenseInfo_Tool_cmsLocalLicenses.Text = "Show License Info";
            this.ShowLicenseInfo_Tool_cmsLocalLicenses.Click += new System.EventHandler(this.ShowLicenseInfo_Tool_cmsLocalLicenses_Click);
            // 
            // cmsDriversInternationalLicense
            // 
            this.cmsDriversInternationalLicense.Font = new System.Drawing.Font("Lucida Bright", 8F);
            this.cmsDriversInternationalLicense.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsDriversInternationalLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowLicenseInfo_Tool_cmsInternationalLicense});
            this.cmsDriversInternationalLicense.Name = "contextMenuStrip1";
            this.cmsDriversInternationalLicense.Size = new System.Drawing.Size(215, 42);
            // 
            // ShowLicenseInfo_Tool_cmsInternationalLicense
            // 
            this.ShowLicenseInfo_Tool_cmsInternationalLicense.Image = ((System.Drawing.Image)(resources.GetObject("ShowLicenseInfo_Tool_cmsInternationalLicense.Image")));
            this.ShowLicenseInfo_Tool_cmsInternationalLicense.Name = "ShowLicenseInfo_Tool_cmsInternationalLicense";
            this.ShowLicenseInfo_Tool_cmsInternationalLicense.Size = new System.Drawing.Size(214, 38);
            this.ShowLicenseInfo_Tool_cmsInternationalLicense.Text = "Show License Info";
            this.ShowLicenseInfo_Tool_cmsInternationalLicense.Click += new System.EventHandler(this.ShowLicenseInfo_Tool_cmsInternationalLicense_Click);
            // 
            // ctrlDriverLicensesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDriverLicenses);
            this.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlDriverLicensesHistory";
            this.Size = new System.Drawing.Size(979, 273);
            this.gbDriverLicenses.ResumeLayout(false);
            this.TbDriverLicenses.ResumeLayout(false);
            this.tpLocalLicenses.ResumeLayout(false);
            this.tpLocalLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesHistory)).EndInit();
            this.tpInternationalLicenses.ResumeLayout(false);
            this.tpInternationalLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenseHistory)).EndInit();
            this.cmsDriversLocalLicenses.ResumeLayout(false);
            this.cmsDriversInternationalLicense.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDriverLicenses;
        private System.Windows.Forms.TabControl TbDriverLicenses;
        private System.Windows.Forms.TabPage tpLocalLicenses;
        private System.Windows.Forms.Label lblNumberRecordsLocalLicenses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLocalLicensesHistory;
        private System.Windows.Forms.TabPage tpInternationalLicenses;
        private System.Windows.Forms.Label lblNumberRecordsInternationalLicenses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvInternationalLicenseHistory;
        private System.Windows.Forms.ContextMenuStrip cmsDriversLocalLicenses;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseInfo_Tool_cmsLocalLicenses;
        private System.Windows.Forms.ContextMenuStrip cmsDriversInternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseInfo_Tool_cmsInternationalLicense;
    }
}
