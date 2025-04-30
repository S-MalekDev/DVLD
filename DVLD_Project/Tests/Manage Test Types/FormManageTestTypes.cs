using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class FormManageTestTypes : Form
    {
        public FormManageTestTypes()
        {
            InitializeComponent();
        }
        private void _LoadTestTypes_dgvTestTypes()
        {
            dgvTestTypes.DataSource = clsTestType.GetAllTestTypes();
        }
        private void _ModifyTheDesignOf_dgvTestTypes()
        {
            dgvTestTypes.Columns[0].Width = 80;
            dgvTestTypes.Columns[1].Width = 230;
            dgvTestTypes.Columns[2].Width = 685;
            dgvTestTypes.Columns[3].Width = 120;
        }
        private void _ShowNumberRows()
        {
            lblNumberRecords.Text = dgvTestTypes.Rows.Count.ToString();
        }
        private void _ShowTestTypesList()
        {
            _LoadTestTypes_dgvTestTypes();
            _ModifyTheDesignOf_dgvTestTypes();
            _ShowNumberRows();
            
        }


        private void FormManageTestTypes_Load(object sender, EventArgs e)
        {
            _ShowTestTypesList();
        }

        private void UpdateToolStrepMenuItme_Click(object sender, EventArgs e)
        {
           FormUpdateTestType frm = new FormUpdateTestType((int)dgvTestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            FormManageTestTypes_Load(null,null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
