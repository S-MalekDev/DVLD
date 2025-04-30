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
    public partial class FormIssueInternationalLicense : Form
    {

        private clsInternationalLicenses InternationalLicense = null;
        private clsLicenses SelectedLicense = null;
        public FormIssueInternationalLicense()
        {
            InitializeComponent();
        }

        private void ctrlDrivingLicenseInfoWithFilter1_OnSelectedLicense(int obj)
        {
            SelectedLicense = ctrlDrivingLicenseInfoWithFilter1.SelectedLicenseInfo;
            llblShowLicensesHistory.Enabled = (obj != -1);

            if (!(btnIssue.Enabled = SelectedLicense.IsActive))
            {
                MessageBox.Show($"Selected license is not Active, choose an other license id.", "Not allowed."
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!(btnIssue.Enabled = (SelectedLicense.LicenseClass == (byte)clsLicenseClasses.enLicenseClass.OrdinaryDrivingLicense)))
            {
                MessageBox.Show($"You cannot using this selected license to issue an international license because is not from type ordinary driving license", "Not allowed."
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!(btnIssue.Enabled = !clsInternationalLicenses.IsInternationalLicenseExistAndActivebyPersonID(SelectedLicense.DriverInfo.PersonID)))
            {
                MessageBox.Show($"Person already have an active international license with " +
                    $"id = {clsInternationalLicenses.GetInternationalLicenseIdByPersonID(SelectedLicense.DriverInfo.PersonID)}", "Not allowed."
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _PrepareApplicationNewLicenseForm();
        }


        private void _PrepareApplicationNewLicenseForm()
        {
            lblAppDate.Text = lblIssueDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            lblAppFees.Text = clsApplicationTypes.GetFeesApplicationType(clsApplicationTypes.enApplicationType.NewInternationalLicense).ToString();
            lblLocalDrivingLicenseID.Text = SelectedLicense.LicenseID.ToString();
            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToString("dd/MMM/yyyy");
            lblCreatedByUserName.Text = clsGlobal.CurrentUser.UserName;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {

            InternationalLicense = SelectedLicense.IssueInternationalLicense(clsGlobal.CurrentUser.UserID);

            if (llblShowInternationalLicenseInfo.Enabled = (InternationalLicense != null))
            {
                MessageBox.Show($"The International license issued Succenssfully, the Id of the International license is [{InternationalLicense.InternationalLicenseID}]", "Succenss", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblInternationalLicenseAppID.Text = InternationalLicense.ApplicationID.ToString();
                lblInternationalLicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
                ctrlDrivingLicenseInfoWithFilter1.FilterEnabled = false;
            }
            else
            {
                MessageBox.Show($"Renewed license is failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnIssue.Enabled = false;
        }

        private void FormIssueInternationalLicense_Activated(object sender, EventArgs e)
        {
            ctrlDrivingLicenseInfoWithFilter1.FilterFocus();
        }

        private void llblShowInternationalLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShowInternationalLicenseDetails frm = new FormShowInternationalLicenseDetails(InternationalLicense.InternationalLicenseID);
            frm.ShowDialog(); 
        }

        private void llblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLicensesHistory frm = new FormLicensesHistory(SelectedLicense.DriverInfo.PersonID, true);
            frm.ShowDialog();
        }
    }
}
