using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class FormReleaseDetainedLicense : Form
    {
        clsLicenses _License = null;
        clsDetainedLicenses _DetainLicense = null;
        int _LicensesID = -1;
        public FormReleaseDetainedLicense()
        {
            InitializeComponent();
        }
        public FormReleaseDetainedLicense(int LicenseID)
        {
            InitializeComponent();
            _LicensesID=LicenseID;
        }

        private void FormDetainLocalDrivingLicense_Activated(object sender, EventArgs e)
        {
            
        }

        private void _PrepareTheFormWithInfoDetain()
        {
            _DetainLicense = clsDetainedLicenses.FindByLicenseID(_License.LicenseID);
            if(_DetainLicense == null)
            {
                MessageBox.Show("The detain license info is missing","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            lblLicenseID.Text = _License.LicenseID.ToString();
            lblDetainID.Text = _DetainLicense.DetainID.ToString();
            lblDetainDate.Text = _DetainLicense.DetainDate.ToString("dd/MMM/yyyy");
            lblCreatedBy.Text = _DetainLicense.CreatedByUserID.ToString();
            lblApplicationFees.Text = clsApplicationTypes.GetFeesApplicationType(clsApplicationTypes.enApplicationType.ReleaseDetainedDrivingLicsense).ToString();
            lblFineFees.Text = _DetainLicense.FineFees.ToString();
            lblTotalFees.Text = (Convert.ToDecimal(lblApplicationFees.Text) + Convert.ToDecimal(lblFineFees.Text)).ToString(); 
        }
        private void ctrlDrivingLicenseInfoWithFilter1_OnSelectedLicense(int obj)
        {
            if (_License != null)
                return;


            _License = ctrlDrivingLicenseInfoWithFilter1.SelectedLicenseInfo;

            if (!(btnRelease.Enabled = llblShowLicensesHistory.Enabled = _License.IsDetain()))
            {
                MessageBox.Show("The selected license is Not detained", "Not allowd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _PrepareTheFormWithInfoDetain();
        }



        private void btnRelease_Click(object sender, EventArgs e)
        {

            int ApplicationID  = _License.Release(clsGlobal.CurrentUser.UserID);

            if (ApplicationID == -1)
            {
                MessageBox.Show("Error: License released failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("License is released successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblApplicationID.Text = ApplicationID.ToString();
                ctrlDrivingLicenseInfoWithFilter1.FilterEnabled = false;
                ctrlDrivingLicenseInfoWithFilter1.LoadLicenseInfo(_License.LicenseID);

            }
            btnRelease.Enabled = false;
        }

        private void llblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLicensesHistory frm = new FormLicensesHistory(_License.DriverInfo.PersonID, true);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            if (_LicensesID != -1)
            {
                ctrlDrivingLicenseInfoWithFilter1.LoadLicenseInfo(_LicensesID);
                ctrlDrivingLicenseInfoWithFilter1.FilterEnabled = false;
            }
        }

        private void FormReleaseDetainedLicense_Activated(object sender, EventArgs e)
        {
            if (_LicensesID == -1)
                ctrlDrivingLicenseInfoWithFilter1.FilterFocus();
        }
    }
}
