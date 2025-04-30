namespace DVLD_Project
{
    partial class ctrlPersonCartWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPersonCartWithFilter));
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbTextSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterType = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonDetails1 = new DVLD_Project.ctrlPersonDetails();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnAddNew);
            this.gbFilter.Controls.Add(this.btnFind);
            this.gbFilter.Controls.Add(this.tbTextSearch);
            this.gbFilter.Controls.Add(this.label2);
            this.gbFilter.Controls.Add(this.cbFilterType);
            this.gbFilter.Location = new System.Drawing.Point(40, 16);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(971, 115);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(751, 32);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 60);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnFind
            // 
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(662, 32);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 60);
            this.btnFind.TabIndex = 2;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbTextSearch
            // 
            this.tbTextSearch.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.tbTextSearch.Location = new System.Drawing.Point(378, 49);
            this.tbTextSearch.Name = "tbTextSearch";
            this.tbTextSearch.Size = new System.Drawing.Size(256, 27);
            this.tbTextSearch.TabIndex = 1;
            this.tbTextSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTextSearch_KeyPress);
            this.tbTextSearch.Validating += new System.ComponentModel.CancelEventHandler(this.tbTextSearch_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(52, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 107;
            this.label2.Text = "Find By :";
            // 
            // cbFilterType
            // 
            this.cbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbFilterType.FormattingEnabled = true;
            this.cbFilterType.Items.AddRange(new object[] {
            "Person ID",
            "National Number"});
            this.cbFilterType.Location = new System.Drawing.Point(139, 48);
            this.cbFilterType.Name = "cbFilterType";
            this.cbFilterType.Size = new System.Drawing.Size(229, 28);
            this.cbFilterType.TabIndex = 0;
            this.cbFilterType.SelectedIndexChanged += new System.EventHandler(this.cbFilterType_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonDetails1
            // 
            this.ctrlPersonDetails1.AccessibleDescription = "";
            this.ctrlPersonDetails1.AccessibleName = "";
            this.ctrlPersonDetails1.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.ctrlPersonDetails1.Location = new System.Drawing.Point(40, 138);
            this.ctrlPersonDetails1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
            this.ctrlPersonDetails1.Size = new System.Drawing.Size(971, 316);
            this.ctrlPersonDetails1.TabIndex = 4;
            this.ctrlPersonDetails1.VisibleEditPerson = true;
            // 
            // ctrlPersonCartWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlPersonDetails1);
            this.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlPersonCartWithFilter";
            this.Size = new System.Drawing.Size(1057, 470);
            this.Load += new System.EventHandler(this.ctrlPersonCartWithFilter_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonDetails ctrlPersonDetails1;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.ComboBox cbFilterType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbTextSearch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
