namespace DVLD_Project.User
{
    partial class FormManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageUsers));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsersList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNumberRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterIsActive = new System.Windows.Forms.ComboBox();
            this.cbFilterType = new System.Windows.Forms.ComboBox();
            this.tbFilterText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(510, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage Users";
            // 
            // dgvUsersList
            // 
            this.dgvUsersList.AllowUserToAddRows = false;
            this.dgvUsersList.AllowUserToDeleteRows = false;
            this.dgvUsersList.AllowUserToResizeRows = false;
            this.dgvUsersList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUsersList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUsersList.Location = new System.Drawing.Point(34, 369);
            this.dgvUsersList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsersList.Name = "dgvUsersList";
            this.dgvUsersList.ReadOnly = true;
            this.dgvUsersList.RowHeadersWidth = 30;
            this.dgvUsersList.RowTemplate.Height = 24;
            this.dgvUsersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsersList.Size = new System.Drawing.Size(1180, 369);
            this.dgvUsersList.TabIndex = 4;
            this.dgvUsersList.TabStop = false;
            this.dgvUsersList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsersList_CellMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Lucida Bright", 8F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addNewUserToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(210, 282);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetailsToolStripMenuItem.Image")));
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(206, 6);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewUserToolStripMenuItem.Image")));
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordToolStripMenuItem.Image")));
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(206, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendEmailToolStripMenuItem.Image")));
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phoneCallToolStripMenuItem.Image")));
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
            // 
            // lblNumberRecords
            // 
            this.lblNumberRecords.AutoSize = true;
            this.lblNumberRecords.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNumberRecords.Location = new System.Drawing.Point(141, 750);
            this.lblNumberRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberRecords.Name = "lblNumberRecords";
            this.lblNumberRecords.Size = new System.Drawing.Size(31, 19);
            this.lblNumberRecords.TabIndex = 8;
            this.lblNumberRecords.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(34, 750);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "# Records :";
            // 
            // cbFilterIsActive
            // 
            this.cbFilterIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterIsActive.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterIsActive.FormattingEnabled = true;
            this.cbFilterIsActive.Items.AddRange(new object[] {
            "No",
            "Yes",
            "All"});
            this.cbFilterIsActive.Location = new System.Drawing.Point(334, 333);
            this.cbFilterIsActive.Margin = new System.Windows.Forms.Padding(4);
            this.cbFilterIsActive.Name = "cbFilterIsActive";
            this.cbFilterIsActive.Size = new System.Drawing.Size(143, 28);
            this.cbFilterIsActive.TabIndex = 1;
            this.cbFilterIsActive.Visible = false;
            this.cbFilterIsActive.SelectedIndexChanged += new System.EventHandler(this.cbFilterIsActive_SelectedIndexChanged);
            // 
            // cbFilterType
            // 
            this.cbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterType.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.cbFilterType.FormattingEnabled = true;
            this.cbFilterType.Items.AddRange(new object[] {
            "None",
            "User ID",
            "Person ID",
            "UserName",
            "Full Name",
            "Is Active"});
            this.cbFilterType.Location = new System.Drawing.Point(124, 333);
            this.cbFilterType.Margin = new System.Windows.Forms.Padding(4);
            this.cbFilterType.Name = "cbFilterType";
            this.cbFilterType.Size = new System.Drawing.Size(202, 28);
            this.cbFilterType.TabIndex = 0;
            this.cbFilterType.SelectedIndexChanged += new System.EventHandler(this.cbFilterType_SelectedIndexChanged);
            // 
            // tbFilterText
            // 
            this.tbFilterText.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.tbFilterText.Location = new System.Drawing.Point(334, 333);
            this.tbFilterText.Margin = new System.Windows.Forms.Padding(4);
            this.tbFilterText.Name = "tbFilterText";
            this.tbFilterText.Size = new System.Drawing.Size(254, 28);
            this.tbFilterText.TabIndex = 2;
            this.tbFilterText.Visible = false;
            this.tbFilterText.TextChanged += new System.EventHandler(this.tbFilterText_TextChanged);
            this.tbFilterText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterText_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 344);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Filter By :";
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.Location = new System.Drawing.Point(1121, 300);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(93, 63);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1097, 750);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 48);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(537, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 817);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFilterText);
            this.Controls.Add(this.cbFilterType);
            this.Controls.Add(this.cbFilterIsActive);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblNumberRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvUsersList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Lucida Bright", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(1121, 300);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.FormManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsersList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNumberRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ComboBox cbFilterIsActive;
        private System.Windows.Forms.ComboBox cbFilterType;
        private System.Windows.Forms.TextBox tbFilterText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
    }
}