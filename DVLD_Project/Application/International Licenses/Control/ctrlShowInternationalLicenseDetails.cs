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
using System.IO;

namespace DVLD_Project
{
    public partial class ctrlShowInternationalLicenseDetails : UserControl
    {

        private clsInternationalLicenses _InternationalLicense = null;

        public clsInternationalLicenses SelectedInternationalLicenseInfo { get { return _InternationalLicense; } }
        public int InternationalLicenseID { get { return _InternationalLicense == null ? -1 : _InternationalLicense.InternationalLicenseID; } }

        public ctrlShowInternationalLicenseDetails()
        {
            InitializeComponent();
        }

        private string _GetDefaultImagePath()
        {
            if (_InternationalLicense.DriverInfo.PersonInfo.Gendor == 0)//Male
                return @"C:\Users\DELL\Desktop\Course#19 FullRealProject DVLD\Icons\Male 512.png";
            else//Female
                return @"C:\Users\DELL\Desktop\Course#19 FullRealProject DVLD\Icons\Female 512.png";
        }

        private string _GetImageDriverPath()
        {
            if (!string.IsNullOrEmpty(_InternationalLicense.DriverInfo.PersonInfo.ImagePath))
            {
                if (File.Exists(_InternationalLicense.DriverInfo.PersonInfo.ImagePath))
                    return _InternationalLicense.DriverInfo.PersonInfo.ImagePath;
                else
                    MessageBox.Show("The image of the driver is missing", "Not Found it", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _GetDefaultImagePath();
        }
        private void _LoadLicenseInfo()
        {
            lblName.Text = _InternationalLicense.DriverInfo.PersonInfo.FullName;
            lblInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lblLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblNationalNo.Text = _InternationalLicense.DriverInfo.PersonInfo.NationalNo;
            lblGendor.Text = (_InternationalLicense.DriverInfo.PersonInfo.Gendor == 0) ? "Male" : "Female";
            lblIssueDate.Text = _InternationalLicense.IssueDate.ToString("dd/MMM/yyyy");
            lblInternationalApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
            lblIsActive.Text = _InternationalLicense.IsActive ? "Yes" : "No";
            lblDateOfBirth.Text = _InternationalLicense.DriverInfo.PersonInfo.DateOfBirth.ToString("dd/MMM/yyyy");
            lblDriverID.Text = _InternationalLicense.DriverID.ToString();
            lblExpirationDate.Text = _InternationalLicense.ExpirationDate.ToString("dd/MMM/yyyy");
            pbImageDriver.ImageLocation = _GetImageDriverPath();
        }
        public void ShowLicenseInfoByInternationalLicenseID(int InternationalLicenseID)
        {
            _InternationalLicense = clsInternationalLicenses.Find(InternationalLicenseID);

            if (_InternationalLicense == null)
            {
                MessageBox.Show("Error: International SelectedLicense is Not Found!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadLicenseInfo();
        }

        private void lblGendor_TextChanged(object sender, EventArgs e)
        {
            if (lblGendor.Text == "Male")
                gbImageGendor.ImageLocation = @"C:\Users\DELL\Desktop\Course#19 FullRealProject DVLD\Icons\Man 32.png";

            else//if lblGendor.Text == "Female"
                gbImageGendor.ImageLocation = @"C:\Users\DELL\Desktop\Course#19 FullRealProject DVLD\Icons\Woman 32.png";
        }
    }
}
