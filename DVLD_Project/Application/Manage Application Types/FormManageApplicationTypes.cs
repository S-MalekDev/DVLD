using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;
using DVLD_Project.Manage_Application_Types;

namespace DVLD_Project
{
    public partial class FormManageApplicationTypes : Form
    {
        public FormManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void _GetModiferDisgnForApplicationTypesList()
        {
            if(dgvApplicationTypesList.Rows.Count > 0)
            {
                dgvApplicationTypesList.Columns["ApplicationTypeID"].HeaderText = "ID";
                dgvApplicationTypesList.Columns["ApplicationTypeID"].Width = 100;

                dgvApplicationTypesList.Columns["ApplicationTypeTitle"].HeaderText = "Title";
                dgvApplicationTypesList.Columns["ApplicationTypeTitle"].Width = 450;

                dgvApplicationTypesList.Columns["ApplicationFees"].HeaderText = "Fees";
                dgvApplicationTypesList.Columns["ApplicationFees"].Width = 158;

            }
        }

        private void _ShowNumberRows()
        {
            lblNumberRecords.Text = dgvApplicationTypesList.RowCount.ToString();
        }

        private void FormManageApplicationTypes_Load(object sender, EventArgs e)
        {
            DataTable dtApplicationTypes = clsApplicationTypes.GetAllApplicationTypes();
            dgvApplicationTypesList.DataSource = dtApplicationTypes;
            _GetModiferDisgnForApplicationTypesList();
            _ShowNumberRows();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdateApplicationType frm = new FormUpdateApplicationType
            ((int)dgvApplicationTypesList.CurrentRow.Cells["ApplicationTypeID"].Value);
            frm.ShowDialog();
            FormManageApplicationTypes_Load(null,null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
