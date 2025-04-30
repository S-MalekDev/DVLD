using DVLD_BusinessLayer;
using DVLD_Project.User;
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
    public partial class FormMain : Form
    {
        private FormLogin _frmLogin;
        public FormMain(FormLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManagePeople ManagePeople = new FormManagePeople();
            ManagePeople.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
            
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserDetails frm = new FormUserDetails(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangePassword frm = new FormChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private enum enClose { SignOut = 0, FormClose = 1 };
        private enClose CloseType = enClose.FormClose;
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseType = enClose.SignOut;
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManageUsers frm = new FormManageUsers();
            frm .ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManageApplicationTypes frm = new FormManageApplicationTypes();
            frm .ShowDialog();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseType == enClose.FormClose)
                _frmLogin.Close();
            
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewLocalLicenseApplication frm = new FormNewLocalLicenseApplication();
            frm .ShowDialog();
        }

        private void internationalLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManageInternationalLicenses frm = new FormManageInternationalLicenses();
            frm .ShowDialog();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLocalDrivingLicenseApplication frm = new FormLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManageDrivers frm = new FormManageDrivers();
            frm .ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManageTestTypes frm = new FormManageTestTypes();
            frm .ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRenewLocalDrivingLicense frm = new FormRenewLocalDrivingLicense();
            frm.ShowDialog();
        }

        private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReplacementForDamagedOrLostLicense frm = new FormReplacementForDamagedOrLostLicense();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDetainLocalDrivingLicense frm = new FormDetainLocalDrivingLicense();
            frm.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReleaseDetainedLicense frm = new FormReleaseDetainedLicense();
            frm.ShowDialog();
        }

        private void manageDetainLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManageReleaseAndDetainLicenses frm = new FormManageReleaseAndDetainLicenses();
            frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLocalDrivingLicenseApplication frm = new FormLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReleaseDetainedLicense frm = new FormReleaseDetainedLicense();
            frm.ShowDialog();
        }
    }
}
