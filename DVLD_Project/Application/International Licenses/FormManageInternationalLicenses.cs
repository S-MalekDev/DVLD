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
    public partial class FormManageInternationalLicenses : Form
    {
        public FormManageInternationalLicenses()
        {
            InitializeComponent();
            _PrepareTheFormWithTheDefaultValue();
        }
        enum enFilterStatus { All = 0, Yes = 1, No = 2 };
        enFilterStatus _SelectedFilterStatus;
        enum enFilter { None = 0, IntLicenseID = 1, ApplicationID = 2, DriverID = 3, LocalLicenseID = 4, IsActive = 5 }
        enFilter _SelectedFilter;

        DataTable _dtInternationalLicenses;

        private string _GetTextOfTheSelectedFilter()
        {
            string[] Filters = { "None", "Int.License ID", "Application ID", "Driver ID", "L.License ID", "Is Active" };
            return Filters[(byte)_SelectedFilter];
        }
        private void _SelectTheDefaultFilters()
        {
            cbFilter.SelectedIndex = (byte)(_SelectedFilter = enFilter.None);
            cbFilterStatus.SelectedIndex = (byte)(_SelectedFilterStatus = enFilterStatus.All);
        }
        private void _PrepareTheFormWithTheDefaultValue()
        {
            _SelectTheDefaultFilters();
        }
        private void _LoadAllInternationalLicenses()
        {
            _dtInternationalLicenses = clsInternationalLicenses.GetAllInternationalLicensesList();
            dgvInternaiontlLicensesList.DataSource = _dtInternationalLicenses;
        }
        private void _ShowNumberRecords()
        {
            lblNumberRecords.Text = dgvInternaiontlLicensesList.Rows.Count.ToString();
        }
        private void _GetModificationToDesign_dgvInternaiontlLicensesList()
        {
            if (dgvInternaiontlLicensesList.Rows.Count > 0)
            {
                dgvInternaiontlLicensesList.Columns[0].Width = 125;
                dgvInternaiontlLicensesList.Columns[1].Width = 125;
                dgvInternaiontlLicensesList.Columns[2].Width = 125;
                dgvInternaiontlLicensesList.Columns[3].Width = 125;
                dgvInternaiontlLicensesList.Columns[4].Width = 200;
                dgvInternaiontlLicensesList.Columns[5].Width = 200;
                dgvInternaiontlLicensesList.Columns[6].Width = 125;

            }
        }
        private void _ShowInternationalLicensesList()
        {
            _LoadAllInternationalLicenses();
            _GetModificationToDesign_dgvInternaiontlLicensesList();
            _ShowNumberRecords();
        }
        private void _RefreshInternationalLicensesList()
        {
            _ShowInternationalLicensesList();
        }



        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectedFilter = (enFilter)cbFilter.SelectedIndex;

            cbFilterStatus.Visible = (_SelectedFilter == enFilter.IsActive);

            if (tbFilterText.Visible = (_SelectedFilter != enFilter.None&& _SelectedFilter != enFilter.IsActive))
            {
                _RefreshInternationalLicensesList();
                errorProvider1.Clear();
                tbFilterText.Clear();
                tbFilterText.Focus();
            }
            else
            {
                _RefreshInternationalLicensesList();
            }
        }

        private void tbFilterText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilterText.Text))
            {
                _RefreshInternationalLicensesList();
                return;
            }


            if (_SelectedFilter != enFilter.IsActive)
            {
                _dtInternationalLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", _GetTextOfTheSelectedFilter(), tbFilterText.Text);
            }
            else //if (_SelectedFilter == enFilter.IsActive)
            {
                _dtInternationalLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", _GetTextOfTheSelectedFilter(), tbFilterText.Text);
            }

            _ShowNumberRecords();
        }

        private void tbFilterText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_SelectedFilter != enFilter.IsActive)
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

        private void FormManageInternationalLicenses_Load(object sender, EventArgs e)
        {
            _ShowInternationalLicensesList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            FormIssueInternationalLicense frm = new FormIssueInternationalLicense();
            frm.ShowDialog();
            _RefreshInternationalLicensesList();
        }

        private void ShowPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDrivers Driver = clsDrivers.Find((int)dgvInternaiontlLicensesList.CurrentRow.Cells["Driver ID"].Value);
            FormPersonDetails frm = new FormPersonDetails(Driver.PersonID);
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShowInternationalLicenseDetails frm = new FormShowInternationalLicenseDetails
                ((int)dgvInternaiontlLicensesList.CurrentRow.Cells["Int.License ID"].Value);
            frm.ShowDialog();
        }

        private void ShowPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDrivers Driver = clsDrivers.Find((int)dgvInternaiontlLicensesList.CurrentRow.Cells["Driver ID"].Value);
            FormLicensesHistory frm = new FormLicensesHistory(Driver.PersonID, true);
            frm.ShowDialog();
        }

        private void cbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectedFilterStatus = (enFilterStatus)cbFilterStatus.SelectedIndex;

            switch(_SelectedFilterStatus)
            {
                case enFilterStatus.All:
                    {
                        _RefreshInternationalLicensesList();
                        break;
                    }
                case enFilterStatus.Yes:
                    {
                        _dtInternationalLicenses.DefaultView.RowFilter = string.Format("[{0}] = 1", "Is Active");
                        break;
                    }
                case enFilterStatus.No:
                    {
                        _dtInternationalLicenses.DefaultView.RowFilter = string.Format("[{0}] = 0", "Is Active");
                        break;
                    }
                default:
                    {
                        _RefreshInternationalLicensesList();
                        break;
                    }
            }
        }
    }
}
