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
    public partial class FormIssueDriverLicenseFirstTime : Form
    {
        private int _LocalDrivingLicenseAppID;
        public FormIssueDriverLicenseFirstTime(int LocalDrivingLicenseAppID)
        {
            InitializeComponent();
            _LocalDrivingLicenseAppID = LocalDrivingLicenseAppID;
        }

        private void ctrlLocalDrivingLicenseApplicationInfo1_Load(object sender, EventArgs e)
        {
            ctrlLocalDrivingLicenseApplicationInfo1.ShowLicenseInfoEnebled = false;
        }

        private void FormIssueDriverLicenseFirstTime_Load(object sender, EventArgs e)
        {
            ctrlLocalDrivingLicenseApplicationInfo1.LoadLocalDrivingLicenseAppInfo(_LocalDrivingLicenseAppID); 
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            clsLocalLicenseApplication LocalDrivingLicenseApp = ctrlLocalDrivingLicenseApplicationInfo1.LocalLicenseApplicationInfo;

            int LicenseID = LocalDrivingLicenseApp.IssuedLicenseForTheFirstTime(tbNotes.Text, clsGlobal.CurrentUser.UserID);
            
            if(LicenseID != -1)
            {
                MessageBox.Show($"License Issued Successfully With SelectedLicense ID [ {LicenseID} ].", "Successfully Issued"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("An Error Occurred When Issueding The License.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
