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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Project
{
    public partial class ctrlLocalDrivingLicenseApplicationInfo : UserControl
    {
        private bool _ShowLicenseInfoEnebled = true;
        public bool ShowLicenseInfoEnebled
        {
            set
            {
                _ShowLicenseInfoEnebled = value;
                llblShowLicenseInfo.Enabled = _ShowLicenseInfoEnebled;
            }
            get { return _ShowLicenseInfoEnebled; }

        }

        private clsLocalLicenseApplication _LocalDrivingLacenseApp = null;
        public clsLocalLicenseApplication LocalLicenseApplicationInfo { get { return _LocalDrivingLacenseApp; } }



        public ctrlLocalDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        public void LoadLocalDrivingLicenseAppInfo(int LocalDrivingLicenseAppID)
        {
            _LocalDrivingLacenseApp = clsLocalLicenseApplication.Find(LocalDrivingLicenseAppID);
           
            if(_LocalDrivingLacenseApp == null)
            {
                MessageBox.Show($"The _LocalDrivingLacenseApp With ID [{LocalDrivingLicenseAppID}] Was No Found!", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                llblShowLicenseInfo.Enabled = false;
                return;
            }

            llblShowLicenseInfo.Enabled = _LocalDrivingLacenseApp.DoesItHaveADrivingLicense();

            lblLocalDrivingLicenseAppID.Text = _LocalDrivingLacenseApp.LocalDrivingLicenseApplicationID.ToString();
            lblAppliedForLicense.Text = _LocalDrivingLacenseApp.LicensClassInfo.ClassName;
            lblPassedTest.Text = clsTests.GetNumberTestsPassedWithLocalDrivingLicenseAppID(LocalDrivingLicenseAppID).ToString();
            ctrlApplicationBasicInfo1.LoadApplicationInfo(_LocalDrivingLacenseApp.ApplicationID);
        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLocalDrivingLicenseInfo frm = new FormLocalDrivingLicenseInfo(_LocalDrivingLacenseApp.LocalDrivingLicenseApplicationID);
            frm.ShowDialog();
        }
    }
}
