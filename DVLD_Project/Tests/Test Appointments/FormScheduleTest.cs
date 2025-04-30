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
    public partial class FormScheduleTest : Form
    {

        int _LocalDrivingLicenseAppID;


        public FormScheduleTest(int LocalDrivingLicenseAppID)
        {
            InitializeComponent();
            _LocalDrivingLicenseAppID = LocalDrivingLicenseAppID;
        }

        private void FormScheduleTest_Load(object sender, EventArgs e)
        {
            ctrlSchedultTest1.LoadSchedultTestDataWithLocalDrivingLicenseAppID(_LocalDrivingLicenseAppID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
