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
    public partial class ctrlShowLicneseInfo : UserControl
    {
        private clsLicenses License = null;

        public clsLicenses SelectedLicenseInfo { get { return License; } }
        public int LicenseID { get { return License==null? -1:License.LicenseID; } }
        public ctrlShowLicneseInfo()
        {
            InitializeComponent();
        }

        private string _GetDefaultImagePath()
        {
            if (License.DriverInfo.PersonInfo.Gendor == 0)//Male
                return @"C:\Users\DELL\Desktop\Course#19 FullRealProject DVLD\Icons\Male 512.png";
            else//Female
                return @"C:\Users\DELL\Desktop\Course#19 FullRealProject DVLD\Icons\Female 512.png";
        }

        private string _GetImageDriverPath()
        {
            if(!string.IsNullOrEmpty(License.DriverInfo.PersonInfo.ImagePath))
            {
                if (File.Exists(License.DriverInfo.PersonInfo.ImagePath))
                    return License.DriverInfo.PersonInfo.ImagePath;
                else
                    MessageBox.Show("The image of the driver is missing", "Not Found it", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _GetDefaultImagePath();
        }
        private void _LoadLicenseInfo()
        {
            lblClassName.Text = License.LicenseClassInfo.ClassName;
            lblName.Text = License.DriverInfo.PersonInfo.FullName;
            lblLicenseID.Text = License.LicenseID.ToString();
            lblNationalNo.Text = License.DriverInfo.PersonInfo.NationalNo;
            lblGendor.Text = (License.DriverInfo.PersonInfo.Gendor == 0) ? "Male" : "Female";
            lblIssueDate.Text = License.IssueDate.ToString("dd/MMM/yyyy");
            lblIssueReason.Text = License.IssueReasonText;

            if (!string.IsNullOrEmpty(License.Notes))
                lblNotes.Text = License.Notes;
            else
                lblNotes.Text = "No Notes.";

            lblIsActive.Text = License.IsActive ? "Yes" : "No";
            lblDateOfBirth.Text = License.DriverInfo.PersonInfo.DateOfBirth.ToString("dd/MMM/yyyy");
            lblDriverID.Text = License.DriverID.ToString();
            lblExpirationDate.Text = License.ExpirationDate.ToString("dd/MMM/yyyy");
            lblIsDetained.Text = License.IsDetain()?"Yes":"No";

            pbImageDriver.ImageLocation = _GetImageDriverPath();
        }
        public void ShowLicenseInfoByLicenseID(int LicneseID)
        {
            License = clsLicenses.Find(LicneseID);

            if (License == null)
            {
                MessageBox.Show("Error: SelectedLicense Was No Find!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadLicenseInfo();
        }

        public void ShowLicenseInfoByLocalDrivingLicenseAppID(int LocalDrivingLicenseAppID)
        {
            License = clsLicenses.FindByLocalDrivingLicenseAppID(LocalDrivingLicenseAppID);

            if (License == null)
            {
                MessageBox.Show("Error: SelectedLicense Was No Find!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
