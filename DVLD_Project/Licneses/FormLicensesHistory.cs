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
    public partial class FormLicensesHistory : Form
    {
        private clsLocalLicenseApplication _LocalDrivingLicesesApp;
        private int PersonID;
        public FormLicensesHistory(int ID, bool IsPersonID = false)
        {
            InitializeComponent();
            _PrepareTheForm();

            if (IsPersonID)
            {
                PersonID = ID;
            }
            else
            {
                _LocalDrivingLicesesApp = clsLocalLicenseApplication.Find(ID);
                PersonID = _LocalDrivingLicesesApp.ApplicationPersonID;
            }
        }

        private void _PrepareTheForm()
        {
            ctrlPersonCartWithFilter1.EditPersonVisibled = false;
            ctrlPersonCartWithFilter1.FilterEnabled = false;
        }
        private void _ShowPersonInfo()
        {
            ctrlPersonCartWithFilter1.LoadPersonInfo(PersonID);
            
        }

        private void _ShowDriverLicensesHistory()
        {
            int DriverID = -1;
            if (clsDrivers.IsDriverExistWithPersonID(PersonID, ref DriverID))
                ctrlDriverLicensesHistory1.LoadDrivingLicensesHistorybyDriverID(DriverID);
        }
        private void FormLicensesHistory_Load(object sender, EventArgs e)
        {
            _ShowPersonInfo();

            _ShowDriverLicensesHistory();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
