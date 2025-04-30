namespace DVLD_Project
{
    partial class FormManageReleaseAndDetainLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageReleaseAndDetainLicenses));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.tbFilterText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumberRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvDetainedLicensesList = new System.Windows.Forms.DataGridView();
            this.cmsDetainedLicenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRetainLicense = new System.Windows.Forms.Button();
            this.btnReleaseLicense = new System.Windows.Forms.Button();
            this.cbStatusReleased = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicensesList)).BeginInit();
            this.cmsDetainedLicenses.SuspendLayout();
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
            "Detain ID",
            "National No",
            "Full Name",
            "Release Application ID",
            "Is Released"});
            this.cbFilter.Location = new System.Drawing.Point(102, 289);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(202, 28);
            this.cbFilter.TabIndex = 57;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // tbFilterText
            // 
            this.tbFilterText.Location = new System.Drawing.Point(309, 289);
            this.tbFilterText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFilterText.Name = "tbFilterText";
            this.tbFilterText.Size = new System.Drawing.Size(254, 28);
            this.tbFilterText.TabIndex = 56;
            this.tbFilterText.Visible = false;
            this.tbFilterText.TextChanged += new System.EventHandler(this.tbFilterText_TextChanged);
            this.tbFilterText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterText_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(8, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 55;
            this.label3.Text = "Filter By :";
            // 
            // lblNumberRecords
            // 
            this.lblNumberRecords.AutoSize = true;
            this.lblNumberRecords.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNumberRecords.Location = new System.Drawing.Point(114, 680);
            this.lblNumberRecords.Name = "lblNumberRecords";
            this.lblNumberRecords.Size = new System.Drawing.Size(31, 19);
            this.lblNumberRecords.TabIndex = 54;
            this.lblNumberRecords.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 680);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "# Records :";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1404, 691);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 48);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvDetainedLicensesList
            // 
            this.dgvDetainedLicensesList.AllowUserToAddRows = false;
            this.dgvDetainedLicensesList.AllowUserToDeleteRows = false;
            this.dgvDetainedLicensesList.AllowUserToResizeRows = false;
            this.dgvDetainedLicensesList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDetainedLicensesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetainedLicensesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetainedLicensesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetainedLicensesList.ContextMenuStrip = this.cmsDetainedLicenses;
            this.dgvDetainedLicensesList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDetainedLicensesList.Location = new System.Drawing.Point(21, 321);
            this.dgvDetainedLicensesList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDetainedLicensesList.Name = "dgvDetainedLicensesList";
            this.dgvDetainedLicensesList.ReadOnly = true;
            this.dgvDetainedLicensesList.RowHeadersWidth = 30;
            this.dgvDetainedLicensesList.RowTemplate.Height = 24;
            this.dgvDetainedLicensesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetainedLicensesList.ShowCellErrors = false;
            this.dgvDetainedLicensesList.ShowCellToolTips = false;
            this.dgvDetainedLicensesList.Size = new System.Drawing.Size(1500, 357);
            this.dgvDetainedLicensesList.TabIndex = 51;
            // 
            // cmsDetainedLicenses
            // 
            this.cmsDetainedLicenses.Font = new System.Drawing.Font("Lucida Bright", 8F);
            this.cmsDetainedLicenses.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsDetainedLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem1,
            this.ShowPersonLicenseHistoryToolStripMenuItem,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.cmsDetainedLicenses.Name = "contextMenuStrip1";
            this.cmsDetainedLicenses.Size = new System.Drawing.Size(286, 156);
            this.cmsDetainedLicenses.Opening += new System.ComponentModel.CancelEventHandler(this.cmsDetainedLicenses_Opening);
            // 
            // ShowPersonDetailsToolStripMenuItem
            // 
            this.ShowPersonDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ShowPersonDetailsToolStripMenuItem.Image")));
            this.ShowPersonDetailsToolStripMenuItem.Name = "ShowPersonDetailsToolStripMenuItem";
            this.ShowPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(285, 38);
            this.ShowPersonDetailsToolStripMenuItem.Text = "Show Person Info";
            this.ShowPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem1
            // 
            this.showLicenseDetailsToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseDetailsToolStripMenuItem1.Image")));
            this.showLicenseDetailsToolStripMenuItem1.Name = "showLicenseDetailsToolStripMenuItem1";
            this.showLicenseDetailsToolStripMenuItem1.Size = new System.Drawing.Size(285, 38);
            this.showLicenseDetailsToolStripMenuItem1.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem1.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem1_Click);
            // 
            // ShowPersonLicenseHistoryToolStripMenuItem
            // 
            this.ShowPersonLicenseHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ShowPersonLicenseHistoryToolStripMenuItem.Image")));
            this.ShowPersonLicenseHistoryToolStripMenuItem.Name = "ShowPersonLicenseHistoryToolStripMenuItem";
            this.ShowPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(285, 38);
            this.ShowPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License HIstory";
            this.ShowPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.ShowPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("releaseDetainedLicenseToolStripMenuItem.Image")));
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(285, 38);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            this.releaseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(537, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 39);
            this.label1.TabIndex = 50;
            this.label1.Text = "Manage Detained Licenses";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(672, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // btnRetainLicense
            // 
            this.btnRetainLicense.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetainLicense.Image = ((System.Drawing.Image)(resources.GetObject("btnRetainLicense.Image")));
            this.btnRetainLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetainLicense.Location = new System.Drawing.Point(1369, 253);
            this.btnRetainLicense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetainLicense.Name = "btnRetainLicense";
            this.btnRetainLicense.Size = new System.Drawing.Size(73, 64);
            this.btnRetainLicense.TabIndex = 58;
            this.btnRetainLicense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRetainLicense.UseVisualStyleBackColor = true;
            this.btnRetainLicense.Click += new System.EventHandler(this.btnRetainLicense_Click);
            // 
            // btnReleaseLicense
            // 
            this.btnReleaseLicense.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReleaseLicense.Image = ((System.Drawing.Image)(resources.GetObject("btnReleaseLicense.Image")));
            this.btnReleaseLicense.Location = new System.Drawing.Point(1448, 253);
            this.btnReleaseLicense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReleaseLicense.Name = "btnReleaseLicense";
            this.btnReleaseLicense.Size = new System.Drawing.Size(73, 64);
            this.btnReleaseLicense.TabIndex = 59;
            this.btnReleaseLicense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReleaseLicense.UseVisualStyleBackColor = true;
            this.btnReleaseLicense.Click += new System.EventHandler(this.btnReleaseLicense_Click);
            // 
            // cbStatusReleased
            // 
            this.cbStatusReleased.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusReleased.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusReleased.FormattingEnabled = true;
            this.cbStatusReleased.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbStatusReleased.Location = new System.Drawing.Point(310, 289);
            this.cbStatusReleased.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatusReleased.Name = "cbStatusReleased";
            this.cbStatusReleased.Size = new System.Drawing.Size(143, 28);
            this.cbStatusReleased.TabIndex = 60;
            this.cbStatusReleased.Visible = false;
            this.cbStatusReleased.SelectedIndexChanged += new System.EventHandler(this.cbStatusReleased_SelectedIndexChanged);
            // 
            // FormManageReleaseAndDetainLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 755);
            this.Controls.Add(this.cbStatusReleased);
            this.Controls.Add(this.btnReleaseLicense);
            this.Controls.Add(this.btnRetainLicense);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.tbFilterText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumberRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvDetainedLicensesList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormManageReleaseAndDetainLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Detained Licenses";
            this.Load += new System.EventHandler(this.FormManageReleaseAndDetainLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicensesList)).EndInit();
            this.cmsDetainedLicenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox tbFilterText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumberRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvDetainedLicensesList;
        private System.Windows.Forms.ContextMenuStrip cmsDetainedLicenses;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReleaseLicense;
        private System.Windows.Forms.Button btnRetainLicense;
        private System.Windows.Forms.ComboBox cbStatusReleased;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
    }
}