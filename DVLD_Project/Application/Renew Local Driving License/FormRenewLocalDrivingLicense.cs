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
    public partial class FormRenewLocalDrivingLicense : Form
    {
        private clsLicenses NewLicense = null;
        private clsLicenses License = null;
        public FormRenewLocalDrivingLicense()
        {
            InitializeComponent();
        }

        private void _PrepareApplicationNewLicenseForm()
        {
            lblAppDate.Text = lblIssueDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            lblAppFees.Text = clsApplicationTypes.GetFeesApplicationType(clsApplicationTypes.enApplicationType.RenewDrivingLicenseService).ToString();
            lblLicenseFees.Text = License.LicenseClassInfo.ClassFees.ToString();
            lblExpirationDate.Text = DateTime.Now.AddYears(License.LicenseClassInfo.DefaultValidityLength).ToString("dd/MMM/yyyy");
            lblOldLicenseID.Text = License.LicenseID.ToString();
            lblTotalFees.Text = (License.LicenseClassInfo.ClassFees + clsApplicationTypes.GetFeesApplicationType(clsApplicationTypes.enApplicationType.RenewDrivingLicenseService)).ToString();
            lblCreatedByUserName.Text = clsGlobal.CurrentUser.UserName;
            tbNotes.Text = License.Notes;
        }

        private void ctrlDrivingLicenseInfoWithFilter1_OnSelectedLicense(int obj)
        {
            
            License = ctrlDrivingLicenseInfoWithFilter1.SelectedLicenseInfo;
            llblShowLicensesHistory.Enabled = (obj != -1);

            if (!(btnRenew.Enabled = License.IsExpiared()))
            {
                MessageBox.Show($"Selected license is not yet expiared, it will expire on:{License.ExpirationDate.ToString("dd/MMM/yyyy")}", "Not allowed."
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!(btnRenew.Enabled=License.IsActive))
            {
                MessageBox.Show($"Selected license is not Active, choose an other license id.", "Not allowed."
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _PrepareApplicationNewLicenseForm();
        }

        private void btnRenew_EnabledChanged(object sender, EventArgs e)
        {
            if(NewLicense == null)
            gbAppNewLicenseInfo.Visible = btnRenew.Enabled;

            if(gbAppNewLicenseInfo.Visible)ctrlDrivingLicenseInfoWithFilter1.Location = new System.Drawing.Point(7, 52);
            else ctrlDrivingLicenseInfoWithFilter1.Location = new System.Drawing.Point(7, 186);
        }

      

        private void FormRenewLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            ctrlDrivingLicenseInfoWithFilter1.Location = new System.Drawing.Point(7, 186);
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to renew this license ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.No)
                return;

            NewLicense = License.RenewLicense(tbNotes.Text, clsGlobal.CurrentUser.UserID);

            if(llblShowNewLicneseInfo.Enabled = (NewLicense !=null))
            {
                MessageBox.Show($"The license Renewed Succenssfully, the Id of the new license is [{NewLicense.LicenseID}]","Succenss",MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblRenewLicenseAppID.Text = NewLicense.ApplicationID.ToString();
                lblRenewLicenseID.Text = NewLicense.LicenseID.ToString();
                ctrlDrivingLicenseInfoWithFilter1.FilterEnabled = false;
            }
            else
            {
                MessageBox.Show($"Renewed license is failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            btnRenew.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llblShowNewLicneseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLocalDrivingLicenseInfo frm = new FormLocalDrivingLicenseInfo(NewLicense.LicenseID, true);
            frm.ShowDialog();
        }

        private void FormRenewLocalDrivingLicense_Activated(object sender, EventArgs e)
        {
            ctrlDrivingLicenseInfoWithFilter1.FilterFocus();
        }

        private void llblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLicensesHistory frm = new FormLicensesHistory(License.DriverInfo.PersonID, true);
            frm.ShowDialog();
        }
    }
}
