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
    public partial class FormShowDetailsLocalDrivingLicenseApplication : Form
    {
        private int _LocalDrivingLicenseAppID = -1;
        public FormShowDetailsLocalDrivingLicenseApplication(int LocalDrivingLicenseAppID)
        {
            InitializeComponent();
            _LocalDrivingLicenseAppID = LocalDrivingLicenseAppID;
        }

        private void FormShowDetailsLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            ctrlLocalDrivingLicenseApplicationInfo1.LoadLocalDrivingLicenseAppInfo(_LocalDrivingLicenseAppID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
