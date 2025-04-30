using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class FormManageDrivers : Form
    {
        enum enFilter { None = 0, DriverID = 1, PersonID = 2, NationalNo = 3, FullName = 4 }
        enFilter _SelectedFilter;

        DataTable _dtDrivers;
        public FormManageDrivers()
        {
            InitializeComponent();
            _PrepareTheFormWithTheDefaultValue();
        }

        private string _GetTextOfTheSelectedFilter()
        {
            string[] Filters = { "None", "Driver ID", "Person ID", "National No", "Full Name" };
            return Filters[(byte)_SelectedFilter];
        }
        private void _SelectTheDefaultFilter()
        {
            cbFilter.SelectedIndex = (byte)(_SelectedFilter = enFilter.None);
        }
        private void _PrepareTheFormWithTheDefaultValue()
        {
            _SelectTheDefaultFilter();
        }
        private void _LoadAllDrivers()
        {
            _dtDrivers = clsDrivers.GetAllDrivers();
            dgvDriversList.DataSource = _dtDrivers;
        }
        private void _ShowNumberRecords()
        {
            lblNumberRecords.Text = dgvDriversList.Rows.Count.ToString();
        }
        private void _GetModificationToDesign_dgvDriversList()
        {
            if (dgvDriversList.Rows.Count > 0)
            {
                dgvDriversList.Columns[0].Width = 120;
                dgvDriversList.Columns[1].Width = 120;
                dgvDriversList.Columns[2].Width = 140;
                dgvDriversList.Columns[3].Width = 390;
                dgvDriversList.Columns[4].Width = 180;
                dgvDriversList.Columns[5].Width = 165;

            }
        }
        private void _ShowDriversList()
        {
            _LoadAllDrivers();
            _GetModificationToDesign_dgvDriversList();
            _ShowNumberRecords();
        }
        private void _RefreshDriversList()
        {
            _ShowDriversList();
        }


        private void FormManageDrivers_Load(object sender, EventArgs e)
        {
            _ShowDriversList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectedFilter = (enFilter)cbFilter.SelectedIndex;

            if(tbFilterText.Visible = (_SelectedFilter != enFilter.None))
            {
                errorProvider1.Clear();
                tbFilterText.Clear();
                tbFilterText.Focus();
            }
            else
            {
                _RefreshDriversList();
            }
        }

        private void tbFilterText_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbFilterText.Text))
            {
                _RefreshDriversList();
                return;
            }


            if (_SelectedFilter == enFilter.DriverID || _SelectedFilter == enFilter.PersonID)
            {
                _dtDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", _GetTextOfTheSelectedFilter(), tbFilterText.Text);
            }
            else //if (_SelectedFilter == enFilter.FullName || _SelectedFilter == enFilter.NationalNo)
            {
                _dtDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", _GetTextOfTheSelectedFilter(), tbFilterText.Text);
            }

            _ShowNumberRecords();
        }

        private void tbFilterText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_SelectedFilter == enFilter.PersonID || _SelectedFilter == enFilter.DriverID)
            {
                if (e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
                {
                    errorProvider1.SetError(tbFilterText, "You cann't enter litters, please enter numbers only");
                }
                else
                {
                    errorProvider1.SetError(tbFilterText, null);
                }
            }
        }

        private void ShowPersonDetails_ToolcmsDrivers_Click(object sender, EventArgs e)
        {
            FormPersonDetails frm = new FormPersonDetails((int)dgvDriversList.CurrentRow.Cells["Person ID"].Value);
            frm.ShowDialog();
        }

        private void IssueInternationlLicense_ToolcmsDrivers_Click(object sender, EventArgs e)
        {

        }
        private void ShowPersonLicenseHistory_ToolcmsDrivers_Click(object sender, EventArgs e)
        {
            FormLicensesHistory frm = new FormLicensesHistory((int)dgvDriversList.CurrentRow.Cells["Person ID"].Value, true);
            frm.ShowDialog();
        }


    }
}
