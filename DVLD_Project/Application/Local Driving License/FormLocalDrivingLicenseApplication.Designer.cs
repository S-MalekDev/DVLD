namespace DVLD_Project
{
    partial class FormLocalDrivingLicenseApplication
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLocalDrivingLicenseApplication));
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.tbTextFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumberRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLocalDrivingLicenseApplicationList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.sechduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.IssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbApplicationStatus = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddNewLocalLicenseApplication = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenseApplicationList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "L.D.LApp ID",
            "National No",
            "Full Name",
            "Status"});
            this.cbFilter.Location = new System.Drawing.Point(115, 306);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(202, 28);
            this.cbFilter.TabIndex = 39;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // tbTextFilter
            // 
            this.tbTextFilter.Location = new System.Drawing.Point(322, 306);
            this.tbTextFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTextFilter.Name = "tbTextFilter";
            this.tbTextFilter.Size = new System.Drawing.Size(254, 28);
            this.tbTextFilter.TabIndex = 38;
            this.tbTextFilter.Visible = false;
            this.tbTextFilter.TextChanged += new System.EventHandler(this.tbTextFilter_TextChanged);
            this.tbTextFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTextFilter_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(22, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "Filter By :";
            // 
            // lblNumberRecords
            // 
            this.lblNumberRecords.AutoSize = true;
            this.lblNumberRecords.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNumberRecords.Location = new System.Drawing.Point(125, 718);
            this.lblNumberRecords.Name = "lblNumberRecords";
            this.lblNumberRecords.Size = new System.Drawing.Size(31, 19);
            this.lblNumberRecords.TabIndex = 36;
            this.lblNumberRecords.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(22, 718);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "# Records :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(481, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 39);
            this.label1.TabIndex = 32;
            this.label1.Text = "Local Driving License Applications";
            // 
            // dgvLocalDrivingLicenseApplicationList
            // 
            this.dgvLocalDrivingLicenseApplicationList.AllowUserToAddRows = false;
            this.dgvLocalDrivingLicenseApplicationList.AllowUserToDeleteRows = false;
            this.dgvLocalDrivingLicenseApplicationList.AllowUserToResizeRows = false;
            this.dgvLocalDrivingLicenseApplicationList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLocalDrivingLicenseApplicationList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalDrivingLicenseApplicationList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocalDrivingLicenseApplicationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalDrivingLicenseApplicationList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLocalDrivingLicenseApplicationList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLocalDrivingLicenseApplicationList.Location = new System.Drawing.Point(22, 347);
            this.dgvLocalDrivingLicenseApplicationList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLocalDrivingLicenseApplicationList.Name = "dgvLocalDrivingLicenseApplicationList";
            this.dgvLocalDrivingLicenseApplicationList.ReadOnly = true;
            this.dgvLocalDrivingLicenseApplicationList.RowHeadersWidth = 30;
            this.dgvLocalDrivingLicenseApplicationList.RowTemplate.Height = 24;
            this.dgvLocalDrivingLicenseApplicationList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalDrivingLicenseApplicationList.ShowCellErrors = false;
            this.dgvLocalDrivingLicenseApplicationList.ShowCellToolTips = false;
            this.dgvLocalDrivingLicenseApplicationList.Size = new System.Drawing.Size(1514, 355);
            this.dgvLocalDrivingLicenseApplicationList.TabIndex = 31;
            this.dgvLocalDrivingLicenseApplicationList.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dgvLocalDrivingLicenseApplicationList_RowContextMenuStripNeeded);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Lucida Bright", 8F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.CancelToolStripMenuItem,
            this.toolStripMenuItem4,
            this.sechduleToolStripMenuItem,
            this.toolStripMenuItem1,
            this.IssueToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(319, 354);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetailsToolStripMenuItem.Image")));
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(318, 38);
            this.showDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(315, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(318, 38);
            this.editToolStripMenuItem.Text = "Edit Application";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(318, 38);
            this.deleteToolStripMenuItem.Text = "Delete Application";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // CancelToolStripMenuItem
            // 
            this.CancelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CancelToolStripMenuItem.Image")));
            this.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem";
            this.CancelToolStripMenuItem.Size = new System.Drawing.Size(318, 38);
            this.CancelToolStripMenuItem.Text = "Cancel Application";
            this.CancelToolStripMenuItem.Click += new System.EventHandler(this.CancelToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(315, 6);
            // 
            // sechduleToolStripMenuItem
            // 
            this.sechduleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionTestToolStripMenuItem,
            this.scheduleWrittenTestToolStripMenuItem,
            this.scheduleStreetTestToolStripMenuItem});
            this.sechduleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sechduleToolStripMenuItem.Image")));
            this.sechduleToolStripMenuItem.Name = "sechduleToolStripMenuItem";
            this.sechduleToolStripMenuItem.Size = new System.Drawing.Size(318, 38);
            this.sechduleToolStripMenuItem.Text = "Sechdule Tests";
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            this.scheduleVisionTestToolStripMenuItem.Enabled = false;
            this.scheduleVisionTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("scheduleVisionTestToolStripMenuItem.Image")));
            this.scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            this.scheduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(275, 38);
            this.scheduleVisionTestToolStripMenuItem.Text = "Schedule VisionTest Test";
            this.scheduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleVisionTestToolStripMenuItem_Click);
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            this.scheduleWrittenTestToolStripMenuItem.Enabled = false;
            this.scheduleWrittenTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("scheduleWrittenTestToolStripMenuItem.Image")));
            this.scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            this.scheduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(275, 38);
            this.scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            this.scheduleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleWrittenTestToolStripMenuItem_Click);
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            this.scheduleStreetTestToolStripMenuItem.Enabled = false;
            this.scheduleStreetTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("scheduleStreetTestToolStripMenuItem.Image")));
            this.scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            this.scheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(275, 38);
            this.scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            this.scheduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleStreetTestToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(315, 6);
            // 
            // IssueToolStripMenuItem
            // 
            this.IssueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("IssueToolStripMenuItem.Image")));
            this.IssueToolStripMenuItem.Name = "IssueToolStripMenuItem";
            this.IssueToolStripMenuItem.Size = new System.Drawing.Size(318, 38);
            this.IssueToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.IssueToolStripMenuItem.Click += new System.EventHandler(this.IssueToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Enabled = false;
            this.showLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseToolStripMenuItem.Image")));
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(318, 38);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            this.showLicenseToolStripMenuItem.EnabledChanged += new System.EventHandler(this.showLicenseToolStripMenuItem_EnabledChanged);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonLicenseHistoryToolStripMenuItem.Image")));
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(318, 38);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // cbApplicationStatus
            // 
            this.cbApplicationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApplicationStatus.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbApplicationStatus.FormattingEnabled = true;
            this.cbApplicationStatus.Items.AddRange(new object[] {
            "All",
            "New",
            "Cancelled",
            "Completed"});
            this.cbApplicationStatus.Location = new System.Drawing.Point(322, 306);
            this.cbApplicationStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbApplicationStatus.Name = "cbApplicationStatus";
            this.cbApplicationStatus.Size = new System.Drawing.Size(155, 28);
            this.cbApplicationStatus.TabIndex = 40;
            this.cbApplicationStatus.Visible = false;
            this.cbApplicationStatus.SelectedIndexChanged += new System.EventHandler(this.cbApplicationStatus_SelectedIndexChanged);
            this.cbApplicationStatus.VisibleChanged += new System.EventHandler(this.cbApplicationStatus_VisibleChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAddNewLocalLicenseApplication
            // 
            this.btnAddNewLocalLicenseApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewLocalLicenseApplication.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewLocalLicenseApplication.Image")));
            this.btnAddNewLocalLicenseApplication.Location = new System.Drawing.Point(1442, 281);
            this.btnAddNewLocalLicenseApplication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNewLocalLicenseApplication.Name = "btnAddNewLocalLicenseApplication";
            this.btnAddNewLocalLicenseApplication.Size = new System.Drawing.Size(94, 62);
            this.btnAddNewLocalLicenseApplication.TabIndex = 34;
            this.btnAddNewLocalLicenseApplication.UseVisualStyleBackColor = true;
            this.btnAddNewLocalLicenseApplication.Click += new System.EventHandler(this.btnAddNewLocalLicenseApplication_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1419, 718);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 48);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(680, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // FormLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 793);
            this.Controls.Add(this.cbApplicationStatus);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.tbTextFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumberRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNewLocalLicenseApplication);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLocalDrivingLicenseApplicationList);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLocalDrivingLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Driving License Applications";
            this.Load += new System.EventHandler(this.FormLocalDrivingLicenseApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenseApplicationList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox tbTextFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumberRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewLocalLicenseApplication;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLocalDrivingLicenseApplicationList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbApplicationStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sechduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
    }
}