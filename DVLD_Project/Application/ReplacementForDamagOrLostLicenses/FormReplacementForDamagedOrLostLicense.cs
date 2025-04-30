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
    public partial class FormReplacementForDamagedOrLostLicense : Form
    {
        clsLicenses ReplacementLicense = null;
        clsLicenses SelectedLicense = null;
        public FormReplacementForDamagedOrLostLicense()
        {
            InitializeComponent();
        }

        private string GetTextFeesSelectedReplacementApp()
        {
            if(rbDamagedLicense.Checked)
                return clsApplicationTypes.GetFeesApplicationType(clsApplicationTypes.enApplicationType.ReplacementForADamagedDrivingLicense).ToString();

            
            else// if (rbLostLicense.Checked)
                return clsApplicationTypes.GetFeesApplicationType(clsApplicationTypes.enApplicationType.ReplacementForALostDrivingLicense).ToString();
            
        }
        private void PrepareFormToDoingTheReplacementLicense()
        {
            lblAppDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            lblOldLicenseID.Text = SelectedLicense.LicenseID.ToString();
            lblAppFees.Text = GetTextFeesSelectedReplacementApp();
            lblCreatedByUserName.Text = clsGlobal.CurrentUser.UserName;
        }

        private void ctrlDrivingLicenseInfoWithFilter1_OnSelectedLicense(int obj)
        {
            SelectedLicense = ctrlDrivingLicenseInfoWithFilter1.SelectedLicenseInfo;

            llblShowLicensesHistory.Enabled =(SelectedLicense!=null);

            if (!( btnIssueReplacement.Enabled = SelectedLicense.IsActive))
            {
                MessageBox.Show($"Selected license is not Active, choose an other license id.", "Not allowed."
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrepareFormToDoingTheReplacementLicense();
        }

        private void rbReplacementLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDamagedLicense.Checked)
            {
                this.Text = lblReplacementTitle.Text = "Replacement For Damaged SelectedLicense";
                lblAppFees.Text = GetTextFeesSelectedReplacementApp();
            }
            else// if (rbLostLicense.Checked)
            {
                this.Text = lblReplacementTitle.Text = "Replacement For Lost SelectedLicense";
                lblAppFees.Text = GetTextFeesSelectedReplacementApp();
            }
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if(rbDamagedLicense.Checked)
            {
                ReplacementLicense = SelectedLicense.ReplacementLicenseForDamaged(clsGlobal.CurrentUser.UserID);
            }
            else //if(rbLostLicense.Checked)
            {
                ReplacementLicense = SelectedLicense.ReplacementLicenseForLost(clsGlobal.CurrentUser.UserID);
            }

            if(llblShowNewLicneseInfo.Enabled = ReplacementLicense!=null)
            {
                MessageBox.Show($"The license Replacemented Succenssfully, the Id of the new license is [{ReplacementLicense.LicenseID}]", "Succenss", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblLostOrDamagedLicenseAppID.Text = ReplacementLicense.ApplicationID.ToString();
                lblReplacedLicenseID.Text = ReplacementLicense.LicenseID.ToString();
                ctrlDrivingLicenseInfoWithFilter1.FilterEnabled = false;
                btnIssueReplacement .Enabled = false;
            }
            else
            {
                MessageBox.Show($"Replacement license is failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llblShowNewLicneseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLocalDrivingLicenseInfo frm = new FormLocalDrivingLicenseInfo(ReplacementLicense.LicenseID, true);
            frm.ShowDialog();
        }

        private void llblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLicensesHistory frm = new FormLicensesHistory(SelectedLicense.DriverInfo.PersonID, true);
            frm.ShowDialog();
        }
    }
}
