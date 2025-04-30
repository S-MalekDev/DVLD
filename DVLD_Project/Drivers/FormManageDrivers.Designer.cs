namespace DVLD_Project
{
    partial class FormManageDrivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageDrivers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.tbFilterText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumberRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvDriversList = new System.Windows.Forms.DataGridView();
            this.cmsDrivers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriversList)).BeginInit();
            this.cmsDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(441, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 39);
            this.label1.TabIndex = 34;
            this.label1.Text = "Manage Drivers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(485, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Driver ID",
            "Person ID",
            "National No",
            "Full Name"});
            this.cbFilter.Location = new System.Drawing.Point(102, 298);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(202, 28);
            this.cbFilter.TabIndex = 48;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // tbFilterText
            // 
            this.tbFilterText.Location = new System.Drawing.Point(309, 298);
            this.tbFilterText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFilterText.Name = "tbFilterText";
            this.tbFilterText.Size = new System.Drawing.Size(254, 28);
            this.tbFilterText.TabIndex = 47;
            this.tbFilterText.Visible = false;
            this.tbFilterText.TextChanged += new System.EventHandler(this.tbFilterText_TextChanged);
            this.tbFilterText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterText_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(8, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "Filter By :";
            // 
            // lblNumberRecords
            // 
            this.lblNumberRecords.AutoSize = true;
            this.lblNumberRecords.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNumberRecords.Location = new System.Drawing.Point(114, 642);
            this.lblNumberRecords.Name = "lblNumberRecords";
            this.lblNumberRecords.Size = new System.Drawing.Size(31, 19);
            this.lblNumberRecords.TabIndex = 45;
            this.lblNumberRecords.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 642);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "# Records :";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1043, 653);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 48);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvDriversList
            // 
            this.dgvDriversList.AllowUserToAddRows = false;
            this.dgvDriversList.AllowUserToDeleteRows = false;
            this.dgvDriversList.AllowUserToResizeRows = false;
            this.dgvDriversList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDriversList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDriversList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDriversList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriversList.ContextMenuStrip = this.cmsDrivers;
            this.dgvDriversList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDriversList.Location = new System.Drawing.Point(8, 330);
            this.dgvDriversList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDriversList.Name = "dgvDriversList";
            this.dgvDriversList.ReadOnly = true;
            this.dgvDriversList.RowHeadersWidth = 30;
            this.dgvDriversList.RowTemplate.Height = 24;
            this.dgvDriversList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDriversList.ShowCellErrors = false;
            this.dgvDriversList.ShowCellToolTips = false;
            this.dgvDriversList.Size = new System.Drawing.Size(1152, 305);
            this.dgvDriversList.TabIndex = 41;
            // 
            // cmsDrivers
            // 
            this.cmsDrivers.Font = new System.Drawing.Font("Lucida Bright", 8F);
            this.cmsDrivers.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsDrivers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowPersonDetailsToolStripMenuItem,
            this.ShowPersonLicenseHistoryToolStripMenuItem});
            this.cmsDrivers.Name = "contextMenuStrip1";
            this.cmsDrivers.Size = new System.Drawing.Size(286, 108);
            // 
            // ShowPersonDetailsToolStripMenuItem
            // 
            this.ShowPersonDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ShowPersonDetailsToolStripMenuItem.Image")));
            this.ShowPersonDetailsToolStripMenuItem.Name = "ShowPersonDetailsToolStripMenuItem";
            this.ShowPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(285, 38);
            this.ShowPersonDetailsToolStripMenuItem.Text = "Show Person Info";
            this.ShowPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowPersonDetails_ToolcmsDrivers_Click);
            // 
            // ShowPersonLicenseHistoryToolStripMenuItem
            // 
            this.ShowPersonLicenseHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ShowPersonLicenseHistoryToolStripMenuItem.Image")));
            this.ShowPersonLicenseHistoryToolStripMenuItem.Name = "ShowPersonLicenseHistoryToolStripMenuItem";
            this.ShowPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(285, 38);
            this.ShowPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License HIstory";
            this.ShowPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.ShowPersonLicenseHistory_ToolcmsDrivers_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormManageDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 712);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.tbFilterText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumberRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvDriversList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormManageDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Drivers";
            this.Load += new System.EventHandler(this.FormManageDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriversList)).EndInit();
            this.cmsDrivers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox tbFilterText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumberRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvDriversList;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip cmsDrivers;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonLicenseHistoryToolStripMenuItem;
    }
}