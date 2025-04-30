namespace DVLD_Project
{
    partial class FormListTestAppointmerts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListTestAppointmerts));
            this.lblAppointmentTittle = new System.Windows.Forms.Label();
            this.dgvAppointmentsList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNumberRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbTestImage = new System.Windows.Forms.PictureBox();
            this.ctrlLocalDrivingLicenseApplicationInfo1 = new DVLD_Project.ctrlLocalDrivingLicenseApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppointmentTittle
            // 
            this.lblAppointmentTittle.AutoSize = true;
            this.lblAppointmentTittle.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold);
            this.lblAppointmentTittle.ForeColor = System.Drawing.Color.Red;
            this.lblAppointmentTittle.Location = new System.Drawing.Point(212, 223);
            this.lblAppointmentTittle.Name = "lblAppointmentTittle";
            this.lblAppointmentTittle.Size = new System.Drawing.Size(467, 39);
            this.lblAppointmentTittle.TabIndex = 33;
            this.lblAppointmentTittle.Text = "Vision Test Appointments";
            // 
            // dgvAppointmentsList
            // 
            this.dgvAppointmentsList.AllowUserToAddRows = false;
            this.dgvAppointmentsList.AllowUserToDeleteRows = false;
            this.dgvAppointmentsList.AllowUserToResizeRows = false;
            this.dgvAppointmentsList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAppointmentsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointmentsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointmentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmentsList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAppointmentsList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAppointmentsList.Location = new System.Drawing.Point(13, 710);
            this.dgvAppointmentsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAppointmentsList.Name = "dgvAppointmentsList";
            this.dgvAppointmentsList.ReadOnly = true;
            this.dgvAppointmentsList.RowHeadersWidth = 30;
            this.dgvAppointmentsList.RowTemplate.Height = 24;
            this.dgvAppointmentsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointmentsList.ShowCellErrors = false;
            this.dgvAppointmentsList.ShowCellToolTips = false;
            this.dgvAppointmentsList.Size = new System.Drawing.Size(867, 178);
            this.dgvAppointmentsList.TabIndex = 70;
            this.dgvAppointmentsList.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dgvAppointmentsList_RowContextMenuStripNeeded);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Lucida Bright", 8F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 80);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(158, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("takeTestToolStripMenuItem.Image")));
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(158, 38);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // lblNumberRecords
            // 
            this.lblNumberRecords.AutoSize = true;
            this.lblNumberRecords.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNumberRecords.Location = new System.Drawing.Point(115, 896);
            this.lblNumberRecords.Name = "lblNumberRecords";
            this.lblNumberRecords.Size = new System.Drawing.Size(31, 19);
            this.lblNumberRecords.TabIndex = 38;
            this.lblNumberRecords.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 896);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "# Records :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 684);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Appointments:";
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAppointment.Image")));
            this.btnAddAppointment.Location = new System.Drawing.Point(835, 661);
            this.btnAddAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(45, 45);
            this.btnAddAppointment.TabIndex = 41;
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(763, 895);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 48);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbTestImage
            // 
            this.pbTestImage.Image = ((System.Drawing.Image)(resources.GetObject("pbTestImage.Image")));
            this.pbTestImage.Location = new System.Drawing.Point(346, 11);
            this.pbTestImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbTestImage.Name = "pbTestImage";
            this.pbTestImage.Size = new System.Drawing.Size(199, 200);
            this.pbTestImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestImage.TabIndex = 31;
            this.pbTestImage.TabStop = false;
            // 
            // ctrlLocalDrivingLicenseApplicationInfo1
            // 
            this.ctrlLocalDrivingLicenseApplicationInfo1.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.ctrlLocalDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(13, 280);
            this.ctrlLocalDrivingLicenseApplicationInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlLocalDrivingLicenseApplicationInfo1.Name = "ctrlLocalDrivingLicenseApplicationInfo1";
            this.ctrlLocalDrivingLicenseApplicationInfo1.ShowLicenseInfoEnebled = true;
            this.ctrlLocalDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(865, 387);
            this.ctrlLocalDrivingLicenseApplicationInfo1.TabIndex = 34;
            // 
            // FormListTestAppointmerts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 951);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNumberRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAppointmentsList);
            this.Controls.Add(this.ctrlLocalDrivingLicenseApplicationInfo1);
            this.Controls.Add(this.lblAppointmentTittle);
            this.Controls.Add(this.pbTestImage);
            this.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormListTestAppointmerts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vision Test Appointments";
            this.Load += new System.EventHandler(this.FormSechduleTests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTestImage;
        private System.Windows.Forms.Label lblAppointmentTittle;
        private ctrlLocalDrivingLicenseApplicationInfo ctrlLocalDrivingLicenseApplicationInfo1;
        private System.Windows.Forms.DataGridView dgvAppointmentsList;
        private System.Windows.Forms.Label lblNumberRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}