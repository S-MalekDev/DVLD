namespace DVLD_Project
{
    partial class FormManageTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageTestTypes));
            this.lblNumberRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTestTypes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsTestTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.UpdateToolStrepMenuItme = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).BeginInit();
            this.cmsTestTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberRecords
            // 
            this.lblNumberRecords.AutoSize = true;
            this.lblNumberRecords.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNumberRecords.Location = new System.Drawing.Point(118, 617);
            this.lblNumberRecords.Name = "lblNumberRecords";
            this.lblNumberRecords.Size = new System.Drawing.Size(31, 19);
            this.lblNumberRecords.TabIndex = 51;
            this.lblNumberRecords.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 617);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 50;
            this.label2.Text = "# Records :";
            // 
            // dgvTestTypes
            // 
            this.dgvTestTypes.AllowUserToAddRows = false;
            this.dgvTestTypes.AllowUserToDeleteRows = false;
            this.dgvTestTypes.AllowUserToResizeRows = false;
            this.dgvTestTypes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTestTypes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestTypes.ContextMenuStrip = this.cmsTestTypes;
            this.dgvTestTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTestTypes.Location = new System.Drawing.Point(12, 302);
            this.dgvTestTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTestTypes.Name = "dgvTestTypes";
            this.dgvTestTypes.ReadOnly = true;
            this.dgvTestTypes.RowHeadersWidth = 30;
            this.dgvTestTypes.RowTemplate.Height = 24;
            this.dgvTestTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestTypes.ShowCellErrors = false;
            this.dgvTestTypes.ShowCellToolTips = false;
            this.dgvTestTypes.Size = new System.Drawing.Size(1152, 305);
            this.dgvTestTypes.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(414, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 39);
            this.label1.TabIndex = 47;
            this.label1.Text = "Manage Test Types";
            // 
            // cmsTestTypes
            // 
            this.cmsTestTypes.Font = new System.Drawing.Font("Lucida Bright", 8F);
            this.cmsTestTypes.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsTestTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateToolStrepMenuItme});
            this.cmsTestTypes.Name = "contextMenuStrip1";
            this.cmsTestTypes.Size = new System.Drawing.Size(141, 42);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1047, 622);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 48);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // UpdateToolStrepMenuItme
            // 
            this.UpdateToolStrepMenuItme.Image = ((System.Drawing.Image)(resources.GetObject("UpdateToolStrepMenuItme.Image")));
            this.UpdateToolStrepMenuItme.Name = "UpdateToolStrepMenuItme";
            this.UpdateToolStrepMenuItme.Size = new System.Drawing.Size(140, 38);
            this.UpdateToolStrepMenuItme.Text = "Update";
            this.UpdateToolStrepMenuItme.Click += new System.EventHandler(this.UpdateToolStrepMenuItme_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(489, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // FormManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 682);
            this.Controls.Add(this.lblNumberRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvTestTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormManageTestTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Test Types";
            this.Load += new System.EventHandler(this.FormManageTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).EndInit();
            this.cmsTestTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvTestTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmsTestTypes;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStrepMenuItme;
    }
}