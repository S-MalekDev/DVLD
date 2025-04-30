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
    public partial class FormManageReleaseAndDetainLicenses : Form
    {
        enum enStatusReleased { All = 0, Yes = 1, No = 2};
        enStatusReleased _SelectedStatusReleased;
        enum enFilter { None = 0, DetainID = 1, NationalNo = 2, FullName = 3, ReleaseApplicationID = 4, IsReleased = 5 }
        enFilter _SelectedFilter;

        public FormManageReleaseAndDetainLicenses()
        {
            InitializeComponent();
            _PrepareTheFormWithTheDefaultValue();
        }
        

        DataTable _dtDetainedLicenses;
    
        private string _GetTextOfTheSelectedFilter()
        {
            string[] Filters = { "None", "ID", "National No", "Full Name", "Release App ID", "Is Released" };
            return Filters[(byte)_SelectedFilter];
        }
        private void _SelectTheDefaultFilter()
        {
            cbFilter.SelectedIndex = (byte)(_SelectedFilter = enFilter.None);
            cbStatusReleased.SelectedIndex = (byte)(_SelectedStatusReleased = enStatusReleased.All);
        }
        private void _PrepareTheFormWithTheDefaultValue()
        {
            _SelectTheDefaultFilter();
        }
        private void _LoadAllDetainedLicenses()
        {
            _dtDetainedLicenses = clsDetainedLicenses.GetAllDetainedLicenses();
            dgvDetainedLicensesList.DataSource = _dtDetainedLicenses;
        }
        private void _ShowNumberRecords()
        {
            lblNumberRecords.Text = dgvDetainedLicensesList.Rows.Count.ToString();
        }
        private void _GetModificationToDesign_dgvDetainedLicensesList()
        {
            if (dgvDetainedLicensesList.Rows.Count > 0)
            {
                dgvDetainedLicensesList.Columns[0].Width = 40;
                dgvDetainedLicensesList.Columns[1].Width = 120;
                dgvDetainedLicensesList.Columns[2].Width = 177;
                dgvDetainedLicensesList.Columns[3].Width = 140;
                dgvDetainedLicensesList.Columns[4].Width = 150;
                dgvDetainedLicensesList.Columns[5].Width = 160;
                dgvDetainedLicensesList.Columns[6].Width = 400;
                dgvDetainedLicensesList.Columns[7].Width = 160;
                dgvDetainedLicensesList.Columns[8].Width = 120;

            }
        }
        private void _ShowDetainedLicensesList()
        {
            _LoadAllDetainedLicenses();
            _GetModificationToDesign_dgvDetainedLicensesList();
            _ShowNumberRecords();
        }
        private void _RefreshDetainedLicensesList()
        {
            _ShowDetainedLicensesList();
        }

        private void FormManageReleaseAndDetainLicenses_Load(object sender, EventArgs e)
        {
            _ShowDetainedLicensesList();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _RefreshDetainedLicensesList();
            _SelectedFilter = (enFilter)cbFilter.SelectedIndex;

            cbStatusReleased.Visible = (_SelectedFilter == enFilter.IsReleased);
                

            if (tbFilterText.Visible = (_SelectedFilter != enFilter.None && _SelectedFilter != enFilter.IsReleased))
            {
                tbFilterText.Clear();
                tbFilterText.Focus();
            }
            
            
        }

        private void cbStatusReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectedStatusReleased = (enStatusReleased) cbStatusReleased.SelectedIndex;

            switch (_SelectedStatusReleased)
            {
                case enStatusReleased.Yes:
                    {
                        _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = 1", "Is Released");
                        break;
                    }
                case enStatusReleased.No:
                    {
                        _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = 0", "Is Released");
                        break;
                    }
                case enStatusReleased.All:
                    {
                        _RefreshDetainedLicensesList();
                        break;
                    }
            }
            _ShowNumberRecords();




        }

        private void tbFilterText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_SelectedFilter == enFilter.DetainID || _SelectedFilter == enFilter.ReleaseApplicationID)
                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void tbFilterText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilterText.Text))
            {
                _RefreshDetainedLicensesList();
                return;
            }


            if (_SelectedFilter == enFilter.DetainID || _SelectedFilter == enFilter.ReleaseApplicationID)
                _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", _GetTextOfTheSelectedFilter(),tbFilterText.Text);
            else //if(_SelectedFilter == enFilter.FullName || _SelectedFilter == enFilter.NationalNo)
                _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", _GetTextOfTheSelectedFilter(), tbFilterText.Text);

            _ShowNumberRecords();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRetainLicense_Click(object sender, EventArgs e)
        {
            FormReleaseDetainedLicense frm = new FormReleaseDetainedLicense();
            frm.ShowDialog();
            _RefreshDetainedLicensesList();
        }

        private void btnReleaseLicense_Click(object sender, EventArgs e)
        {
            FormDetainLocalDrivingLicense frm = new FormDetainLocalDrivingLicense();
            frm.ShowDialog();
            _RefreshDetainedLicensesList();
        }

        private void cmsDetainedLicenses_Opening(object sender, CancelEventArgs e)
        {
            clsLicenses License = clsLicenses.Find((int)dgvDetainedLicensesList.CurrentRow.Cells["License ID"].Value);
            releaseDetainedLicenseToolStripMenuItem.Enabled = License.IsDetain();
        }

        private void ShowPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPersonDetails frm = new FormPersonDetails((string)dgvDetainedLicensesList.CurrentRow.Cells["National No"].Value);
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormLocalDrivingLicenseInfo frm = new FormLocalDrivingLicenseInfo((int)dgvDetainedLicensesList.CurrentRow.Cells["License ID"].Value, true);
            frm.ShowDialog();
        }

        private void ShowPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLicenses License = clsLicenses.Find((int)dgvDetainedLicensesList.CurrentRow.Cells["License ID"].Value);
            FormLicensesHistory frm = new FormLicensesHistory(License.DriverInfo.PersonID, true);
            frm.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReleaseDetainedLicense frm = new FormReleaseDetainedLicense((int)dgvDetainedLicensesList.CurrentRow.Cells["License ID"].Value);
            frm.ShowDialog();
            _RefreshDetainedLicensesList();
        }
    }
}
