using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class FormLocalDrivingLicenseApplication : Form
    {
        private DataTable dtLocalDrivingLicenseApplications;
        private enum enFilterType { None = 0, LDL_AppID = 1, NationalNo = 2, FullName = 3, Status = 4 };
        private enFilterType _SelectedFilter;

        private enum enAppStatus { All = 0, New = 1, Cancelled = 2, Completed = 3 }
        private enAppStatus _SelectedStatus;


        public FormLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void _LoadDefaultFiltertype()
        {
            cbFilter.SelectedIndex = (byte)enFilterType.None;
        }
        private void _LoadDefaultApplicationStatus()
        {
            cbApplicationStatus.SelectedIndex = (byte)enAppStatus.All;
        }
        private void _LoadDataLocalDrivingLicenseApplicationsList()
        {
            dtLocalDrivingLicenseApplications = clsLocalLicenseApplication.GetAllLocalDrivingLicenseApplication();
            dgvLocalDrivingLicenseApplicationList.DataSource = dtLocalDrivingLicenseApplications;
        }
        private void _GetModifierDesign_dgvLocalDrivingLicenseApplicationList()
        {
            if(dgvLocalDrivingLicenseApplicationList.Rows.Count > 0)
            {
                dgvLocalDrivingLicenseApplicationList.Columns["L.D.L.App ID"].Width = 135;
                dgvLocalDrivingLicenseApplicationList.Columns["Class Name"].Width = 320;
                dgvLocalDrivingLicenseApplicationList.Columns["National No"].Width = 135;
                dgvLocalDrivingLicenseApplicationList.Columns["Full Name"].Width = 400;
                dgvLocalDrivingLicenseApplicationList.Columns["Application Date"].Width = 220;
                dgvLocalDrivingLicenseApplicationList.Columns["Passed Tests"].Width = 150;
                dgvLocalDrivingLicenseApplicationList.Columns["Status"].Width = 120;

            }
        }
        private void _ShowNumberRows()
        {
            lblNumberRecords.Text = dgvLocalDrivingLicenseApplicationList.Rows.Count.ToString();
        }
        private void _ShowLocalDrivingLicenseApplicationsList()
        {
            _LoadDataLocalDrivingLicenseApplicationsList();
            _GetModifierDesign_dgvLocalDrivingLicenseApplicationList();
            _ShowNumberRows();
        }
        private void _RefreshLocalDrivingLicenseApplicationList()
        {
            _ShowLocalDrivingLicenseApplicationsList();
            _ShowNumberRows();
        }
        private string _GetTestFilterType()
        {
            string[] ArrFilters = { "None","L.D.L.App ID", "National No", "Full Name", "Status" };
            return ArrFilters[(byte)_SelectedFilter];
        }
        private void _HandlingScheduledTests_ContextMenuStrip()
        {
            int NumberPassedTests = (int)dgvLocalDrivingLicenseApplicationList.CurrentRow.Cells["Passed Tests"].Value;

            if (!(sechduleToolStripMenuItem.Enabled = !(NumberPassedTests == 3
                ||
                clsLocalLicenseApplication.IsLocalDrivingLicenseAppCanceled((int)dgvLocalDrivingLicenseApplicationList.CurrentRow.Cells[0].Value))))
                return;


            scheduleVisionTestToolStripMenuItem.Enabled = (NumberPassedTests == 0);
            scheduleWrittenTestToolStripMenuItem.Enabled = (NumberPassedTests == 1);
            scheduleStreetTestToolStripMenuItem.Enabled = (NumberPassedTests == 2);
        }
        private bool _IsShowLicenseToolEnabeled_ContextMenuStrip()
        {
           return (showLicenseToolStripMenuItem.Enabled = clsLicenses.IsLicenseExistWithLocalDrivingLicenseAppID
                ((int)dgvLocalDrivingLicenseApplicationList.CurrentRow.Cells[0].Value));
        }
        private void _HandlingIssueDrivingLicenseFirstTime_ContextMenuStrip()
        {
            clsLocalLicenseApplication LocalDrivingLicenseApp = clsLocalLicenseApplication.Find((int)dgvLocalDrivingLicenseApplicationList.CurrentRow.Cells[0].Value);
            int NumberTestsPassed = LocalDrivingLicenseApp.GetTheNumberOfTestsTheApplicantHasPassed();
            bool IsLicenseIssued = LocalDrivingLicenseApp.IsLicenseIssued();
            IssueToolStripMenuItem.Enabled = ((NumberTestsPassed == 3) && !IsLicenseIssued);
            
        }
        private void _HandlingCancelTool_ContextMenuStrip()
        {
            CancelToolStripMenuItem.Enabled = !clsLocalLicenseApplication.IsLocalDrivingLicenseAppCanceled((int)dgvLocalDrivingLicenseApplicationList.CurrentRow.Cells[0].Value);
        }
        private void _HandilingEditTool_ContextMenuStrip()
        {
            editToolStripMenuItem.Enabled = (0==clsTests.GetNumberTestsPassedWithLocalDrivingLicenseAppID((int)dgvLocalDrivingLicenseApplicationList.CurrentRow.Cells[0].Value)
                && 
                !clsLocalLicenseApplication.IsLocalDrivingLicenseAppCanceled((int)dgvLocalDrivingLicenseApplicationList.CurrentRow.Cells[0].Value));
        }


        private void FormLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _ShowLocalDrivingLicenseApplicationsList();
            _LoadDefaultFiltertype();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectedFilter = (enFilterType)cbFilter.SelectedIndex;

            switch (_SelectedFilter)
            {
                case enFilterType.None:
                    {
                        cbApplicationStatus.Visible = false;
                        tbTextFilter.Visible = false;
                        _RefreshLocalDrivingLicenseApplicationList();
                        break;
                    }
                case enFilterType.Status:
                    {
                        cbApplicationStatus.Visible = true;
                        tbTextFilter.Visible = false;
                        break;
                    }
                default:
                    {
                        cbApplicationStatus.Visible = false;
                        tbTextFilter.Visible = true;
                        tbTextFilter.Focus();
                        break;
                    }
            }

        }

        private void cbApplicationStatus_VisibleChanged(object sender, EventArgs e)
        {
            if(cbApplicationStatus.Visible)
                _LoadDefaultApplicationStatus();
        }

        private void cbApplicationStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectedStatus = (enAppStatus)cbApplicationStatus.SelectedIndex;

            if(_SelectedStatus == enAppStatus.All)
            {
                _RefreshLocalDrivingLicenseApplicationList();
                return;
            }

            string[] ArrStatus = { "","New", "Cancelled", "Completed" };//New = 1, Cancelled = 2, Completed = 3
            dtLocalDrivingLicenseApplications.DefaultView.RowFilter =
                    string.Format("[{0}] LIKE '{1}%'", _GetTestFilterType(), ArrStatus[(byte)_SelectedStatus]);

            _ShowNumberRows();

        }

        private void btnAddNewLocalLicenseApplication_Click(object sender, EventArgs e)
        {
            FormNewLocalLicenseApplication frm = new FormNewLocalLicenseApplication();
            frm.ShowDialog();
            _RefreshLocalDrivingLicenseApplicationList();
        }

        private void tbTextFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(_SelectedFilter == enFilterType.LDL_AppID)
            {
                e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));

                if (e.Handled)
                    errorProvider1.SetError(tbTextFilter, "You Can Not Entered Latters!!");
                else
                    errorProvider1.SetError(tbTextFilter, null);
            }
        }

        private void tbTextFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTextFilter.Text))
            {
                _RefreshLocalDrivingLicenseApplicationList();
                return;
            }


            if (_SelectedFilter == enFilterType.LDL_AppID)
                dtLocalDrivingLicenseApplications.DefaultView.RowFilter =
                    string.Format("[{0}] = {1}", _GetTestFilterType(), tbTextFilter.Text);
            else 
                dtLocalDrivingLicenseApplications.DefaultView.RowFilter =
                    string.Format("[{0}] LIKE '{1}%'", _GetTestFilterType(), tbTextFilter.Text);

            _ShowNumberRows();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FormNewLocalLicenseApplication frm = new FormNewLocalLicenseApplication((int)dgvLocalDrivingLicenseApplicationList.CurrentRow.Cells[0].Value);
           frm.ShowDialog();
           _RefreshLocalDrivingLicenseApplicationList();
        }

        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseAppID = (int)dgvLocalDrivingLicenseApplicationList.CurrentRow.Cells[0].Value;
            if (MessageBox.Show($"Are You Sure You Want To Cancel The Local Driving SelectedLicense With ID [{LocalDrivingLicenseAppID}].", "Confirm cancellation.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if(clsLocalLicenseApplication.CancelWithLocalDrivingLicenseAppID(LocalDrivingLicenseAppID))
            {
                MessageBox.Show("Application Cancelled Successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshLocalDrivingLicenseApplicationList();
            }
            else
            {
                MessageBox.Show("Error: Application No Cancelled!", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _RefreshLocalDrivingLicenseApplicationList();
            }
 
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseAppID = (int)dgvLocalDrivingLicenseApplicationList.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are You Sure You Want Deleted The Local Driving SelectedLicense With ID [ {LocalDrivingLicenseAppID} ] ?", "Conferme Deleted.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;


            if (clsLocalLicenseApplication.DeleteLocalDrivingLicenseApp(LocalDrivingLicenseAppID))
            {
                MessageBox.Show($"The Local Driving SelectedLicense Is Deleted Successfully."
            , "Successfully"
            , MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshLocalDrivingLicenseApplicationList();
            }
            else
            {
                MessageBox.Show($"Error: Faild Deleted."
            , "Faild"
            , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShowDetailsLocalDrivingLicenseApplication frm =
                new FormShowDetailsLocalDrivingLicenseApplication((int)dgvLocalDrivingLicenseApplicationList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListTestAppointmerts frm = new FormListTestAppointmerts
                ((int)dgvLocalDrivingLicenseApplicationList.CurrentRow.Cells[0].Value,clsTestType.enTestType.VisionTest);
            frm.ShowDialog();
            _RefreshLocalDrivingLicenseApplicationList();
        }
        
        private void dgvLocalDrivingLicenseApplicationList_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            _HandlingScheduledTests_ContextMenuStrip();
            _HandlingIssueDrivingLicenseFirstTime_ContextMenuStrip();

            if(!_IsShowLicenseToolEnabeled_ContextMenuStrip())
            {
                _HandlingCancelTool_ContextMenuStrip();
                _HandilingEditTool_ContextMenuStrip();
            }
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListTestAppointmerts frm = new FormListTestAppointmerts
                ((int)dgvLocalDrivingLicenseApplicationList.CurrentRow.Cells[0].Value, clsTestType.enTestType.WrittenTest);
            frm.ShowDialog();
            _RefreshLocalDrivingLicenseApplicationList();
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListTestAppointmerts frm = new FormListTestAppointmerts
                ((int)dgvLocalDrivingLicenseApplicationList.CurrentRow.Cells[0].Value, clsTestType.enTestType.PracticalTest);
            frm.ShowDialog();
            _RefreshLocalDrivingLicenseApplicationList();
        }

        private void IssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIssueDriverLicenseFirstTime frm = new FormIssueDriverLicenseFirstTime((int)dgvLocalDrivingLicenseApplicationList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshLocalDrivingLicenseApplicationList();
        }

        private void showLicenseToolStripMenuItem_EnabledChanged(object sender, EventArgs e)
        {
            CancelToolStripMenuItem.Enabled = deleteToolStripMenuItem.Enabled = editToolStripMenuItem.Enabled = !showLicenseToolStripMenuItem.Enabled;
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLocalDrivingLicenseInfo frm = new FormLocalDrivingLicenseInfo((int)dgvLocalDrivingLicenseApplicationList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLicensesHistory frm = new FormLicensesHistory((int)dgvLocalDrivingLicenseApplicationList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }


    }
}
