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
    public partial class FormDetainLocalDrivingLicense : Form
    {
        clsLicenses _License = null;
        clsDetainedLicenses _DetainLicense = null;
        public FormDetainLocalDrivingLicense()
        {
            InitializeComponent();
        }

        private void FormDetainLocalDrivingLicense_Activated(object sender, EventArgs e)
        {
            ctrlDrivingLicenseInfoWithFilter1.FilterFocus();
        }

        private void _PrepareTheFormWithInfoDetain()
        {
            lblLicenseID.Text = _License.LicenseID.ToString();
            lblDetainDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
        }
        private void ctrlDrivingLicenseInfoWithFilter1_OnSelectedLicense(int obj)
        {
            if (_License != null)
                return;


            _License = ctrlDrivingLicenseInfoWithFilter1.SelectedLicenseInfo;

            if( !(btnDetain.Enabled = llblShowLicensesHistory.Enabled = !_License.IsDetain()))
            {
                MessageBox.Show("The selected license is already detained","Not allowd",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            _PrepareTheFormWithInfoDetain();
        }

        private void tbFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar));
        }

        private void tbFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (e.Cancel = string.IsNullOrEmpty(tbFineFees.Text))
                errorProvider1.SetError(tbFineFees, "This field is required.");
            else
                errorProvider1.SetError(tbFineFees, null);
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("The field of detain fees is required for make a detain license","not allowed",MessageBoxButtons.OK,MessageBoxIcon.Warning); 
                return;
            }

            _DetainLicense = _License.Detain(Convert.ToDecimal(tbFineFees.Text),clsGlobal.CurrentUser.UserID);
            if(  _DetainLicense == null )
            {
                MessageBox.Show("Error: License detained failed!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("License is detianed successfully","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblDetainID.Text = _DetainLicense.DetainID.ToString();
                ctrlDrivingLicenseInfoWithFilter1.FilterEnabled = false;
                ctrlDrivingLicenseInfoWithFilter1.LoadLicenseInfo(_License.LicenseID);

            }
            btnDetain.Enabled = false;
        }

        private void llblLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLocalDrivingLicenseInfo frm = new FormLocalDrivingLicenseInfo(_License.LicenseID,true);
            frm.ShowDialog();
        }

        private void llblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLicensesHistory frm = new FormLicensesHistory(_License.DriverInfo.PersonID,true);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
