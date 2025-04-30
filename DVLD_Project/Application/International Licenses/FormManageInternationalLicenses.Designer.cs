namespace DVLD_Project
{
    partial class FormManageInternationalLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageInternationalLicenses));
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.tbFilterText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumberRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvInternaiontlLicensesList = new System.Windows.Forms.DataGridView();
            this.cmsInternationalLicenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.cbFilterStatus = new System.Windows.Forms.ComboBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternaiontlLicensesList)).BeginInit();
            this.cmsInternationalLicenses.SuspendLayout();
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
            "Int License ID",
            "Application ID",
            "Driver ID",
            "L.License ID",
            "Is Active"});
            this.cbFilter.Location = new System.Drawing.Point(103, 280);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(202, 28);
            this.cbFilter.TabIndex = 57;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // tbFilterText
            // 
            this.tbFilterText.Location = new System.Drawing.Point(310, 280);
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
            this.label3.Location = new System.Drawing.Point(9, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 55;
            this.label3.Text = "Filter By :";
            // 
            // lblNumberRecords
            // 
            this.lblNumberRecords.AutoSize = true;
            this.lblNumberRecords.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNumberRecords.Location = new System.Drawing.Point(115, 624);
            this.lblNumberRecords.Name = "lblNumberRecords";
            this.lblNumberRecords.Size = new System.Drawing.Size(31, 19);
            this.lblNumberRecords.TabIndex = 54;
            this.lblNumberRecords.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 624);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "# Records :";
            // 
            // dgvInternaiontlLicensesList
            // 
            this.dgvInternaiontlLicensesList.AllowUserToAddRows = false;
            this.dgvInternaiontlLicensesList.AllowUserToDeleteRows = false;
            this.dgvInternaiontlLicensesList.AllowUserToResizeRows = false;
            this.dgvInternaiontlLicensesList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInternaiontlLicensesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternaiontlLicensesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInternaiontlLicensesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternaiontlLicensesList.ContextMenuStrip = this.cmsInternationalLicenses;
            this.dgvInternaiontlLicensesList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInternaiontlLicensesList.Location = new System.Drawing.Point(9, 312);
            this.dgvInternaiontlLicensesList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInternaiontlLicensesList.Name = "dgvInternaiontlLicensesList";
            this.dgvInternaiontlLicensesList.ReadOnly = true;
            this.dgvInternaiontlLicensesList.RowHeadersWidth = 30;
            this.dgvInternaiontlLicensesList.RowTemplate.Height = 24;
            this.dgvInternaiontlLicensesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternaiontlLicensesList.ShowCellErrors = false;
            this.dgvInternaiontlLicensesList.ShowCellToolTips = false;
            this.dgvInternaiontlLicensesList.Size = new System.Drawing.Size(1068, 305);
            this.dgvInternaiontlLicensesList.TabIndex = 51;
            // 
            // cmsInternationalLicenses
            // 
            this.cmsInternationalLicenses.Font = new System.Drawing.Font("Lucida Bright", 8F);
            this.cmsInternationalLicenses.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsInternationalLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowPersonDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.showLicenseDetailsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.ShowPersonLicenseHistoryToolStripMenuItem});
            this.cmsInternationalLicenses.Name = "contextMenuStrip1";
            this.cmsInternationalLicenses.Size = new System.Drawing.Size(286, 130);
            // 
            // ShowPersonDetailsToolStripMenuItem
            // 
            this.ShowPersonDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ShowPersonDetailsToolStripMenuItem.Image")));
            this.ShowPersonDetailsToolStripMenuItem.Name = "ShowPersonDetailsToolStripMenuItem";
            this.ShowPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(285, 38);
            this.ShowPersonDetailsToolStripMenuItem.Text = "Show Person Info";
            this.ShowPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseDetailsToolStripMenuItem.Image")));
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(285, 38);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // ShowPersonLicenseHistoryToolStripMenuItem
            // 
            this.ShowPersonLicenseHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ShowPersonLicenseHistoryToolStripMenuItem.Image")));
            this.ShowPersonLicenseHistoryToolStripMenuItem.Name = "ShowPersonLicenseHistoryToolStripMenuItem";
            this.ShowPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(285, 38);
            this.ShowPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License HIstory";
            this.ShowPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.ShowPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(240, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 39);
            this.label1.TabIndex = 50;
            this.label1.Text = "International License Applications";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(960, 635);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 48);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(444, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPerson.Image")));
            this.btnAddPerson.Location = new System.Drawing.Point(1007, 246);
            this.btnAddPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(70, 62);
            this.btnAddPerson.TabIndex = 58;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // cbFilterStatus
            // 
            this.cbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterStatus.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterStatus.FormattingEnabled = true;
            this.cbFilterStatus.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbFilterStatus.Location = new System.Drawing.Point(310, 280);
            this.cbFilterStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilterStatus.Name = "cbFilterStatus";
            this.cbFilterStatus.Size = new System.Drawing.Size(121, 28);
            this.cbFilterStatus.TabIndex = 59;
            this.cbFilterStatus.Visible = false;
            this.cbFilterStatus.SelectedIndexChanged += new System.EventHandler(this.cbFilterStatus_SelectedIndexChanged);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(282, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(282, 6);
            // 
            // FormManageInternationalLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 688);
            this.Controls.Add(this.cbFilterStatus);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.tbFilterText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumberRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvInternaiontlLicensesList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormManageInternationalLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List International Licenses";
            this.Load += new System.EventHandler(this.FormManageInternationalLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternaiontlLicensesList)).EndInit();
            this.cmsInternationalLicenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvInternaiontlLicensesList;
        private System.Windows.Forms.ContextMenuStrip cmsInternationalLicenses;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.ComboBox cbFilterStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}