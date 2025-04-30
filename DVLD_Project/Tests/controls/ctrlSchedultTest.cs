using DVLD_BusinessLayer;
using DVLD_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class ctrlSchedultTest : UserControl
    {
        private clsApplication RetackTestApp;
        private clsLocalLicenseApplication _LocalDrivingLicenseApp;
        private clsTestAppointments _TestAppointments;
        private enApplicationType _SelectedApplicationType;
        private enMode _Mode;



        private enum enApplicationType { NewScheduleTest=0, RetakeScheduleTest = 1}
        private enApplicationType SelectedApplicationType
        {
            get { return  _SelectedApplicationType; }
            set
            {
                switch(_SelectedApplicationType=value)
                {
                    case enApplicationType.NewScheduleTest:
                        {
                            gbRetakeTestInfo.Enabled = false;
                            break;
                        }
                        case enApplicationType.RetakeScheduleTest:
                        {
                            gbRetakeTestInfo.Enabled = true;
                            break;
                        }
                }
            }
        }
        
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode Mode
        {
            get { return _Mode; }
            set
            {
                switch(_Mode = value )
                {
                    case enMode.AddNew:
                        {
                            dtpDateTest.MinDate = DateTime.Now;
                            break;
                        }
                    case enMode.Update:
                        {
                            _TestAppointments = clsTestAppointments.GetTheLastTestAppointmentsByLocalDrivingLicenseAppID(_LocalDrivingLicenseApp.LocalDrivingLicenseApplicationID);

                            dtpDateTest.MinDate = (DateTime.Compare(DateTime.Now, _TestAppointments.AppointmentDate) < 0) ? DateTime.Now : _TestAppointments.AppointmentDate;
                            break;
                        }
                }
            }
        }


        private clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;
        public clsTestType.enTestType SelectedTestType
        {
            get { return _TestTypeID; }
            set
            {
                _TestTypeID = value;

                switch(_TestTypeID)
                {
                    case clsTestType.enTestType.VisionTest:
                        {
                            gbShceduleTest.Text = "Vision Test";
                            lblTestTittle.Text = "Vision Test";
                            pbTestImage.Image = Resources.Vision_512;
                            break;
                        }
                    case clsTestType.enTestType.WrittenTest:
                        {
                            gbShceduleTest.Text = "Written Test";
                            lblTestTittle.Text = "Written Test";
                            pbTestImage.Image = Resources.Written_Test_512;
                            break;
                        }
                    case clsTestType.enTestType.PracticalTest:
                        {
                            gbShceduleTest.Text = "Practical Test";
                            lblTestTittle.Text = "Practical Test";
                            pbTestImage.Image = Resources.Driving_test;
                            break;
                        }
                }
            }
        }
        
        public ctrlSchedultTest()
        {
            InitializeComponent();
        }

        private void SelectTheCurrentTestTypeForTheDriver_sLicenseApplicant()
        {
            byte NumberTestsPassed = _LocalDrivingLicenseApp.GetTheNumberOfTestsTheApplicantHasPassed();

            if (NumberTestsPassed != 3)
                SelectedTestType = (clsTestType.enTestType)NumberTestsPassed + 1;
           
        }
        private void SelectTheMode()
        {
            Mode = (_LocalDrivingLicenseApp.IsHeHaveAnAppointmentAndWasNotAttendItYet())? enMode.Update : enMode.AddNew;
        }
        private void SelectApplicationType()
        {
            SelectedApplicationType = (_LocalDrivingLicenseApp.HaveHeEverTakenATestBeforeFromTheType(SelectedTestType)) ? enApplicationType.RetakeScheduleTest : enApplicationType.NewScheduleTest;
        }
        private bool IsTheDataOfTheTestApointmentSaved()
        {
            if (Mode == enMode.AddNew)
            {
                _TestAppointments = new clsTestAppointments();


                _TestAppointments.TestTypeID = (byte)SelectedTestType;
                _TestAppointments.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApp.LocalDrivingLicenseApplicationID;
                _TestAppointments.AppointmentDate = dtpDateTest.Value;
                _TestAppointments.PaidFees = clsTestType.GetFeesTestType(SelectedTestType);
                _TestAppointments.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                _TestAppointments.IsLocked = false;


                if (SelectedApplicationType == enApplicationType.RetakeScheduleTest)
                {
                    if (IsRetakeTestApplicationCreated())
                        _TestAppointments.RetakeTestApplicationID = RetackTestApp.ApplicationID;
                    else
                    {
                        MessageBox.Show("Error");
                        return false;
                    }
                }
            }
            else//Mode == enMode.Update
            {
                _TestAppointments.AppointmentDate = dtpDateTest.Value;
            }
            

            return _TestAppointments.Save();
        }
        private void ShowSchedultTestData()
        {
            lblLocalDrivingLicenseAppID.Text = _LocalDrivingLicenseApp.LocalDrivingLicenseApplicationID.ToString();
            lblLicenseClass.Text = _LocalDrivingLicenseApp.LicensClassInfo.ClassName;
            lblName.Text = _LocalDrivingLicenseApp.PersonFullName;
            lblTrial.Text = _LocalDrivingLicenseApp.GetTheNumberOfTrialsByTestType(SelectedTestType).ToString();

            decimal TotalFees = 0;
            if (_Mode == enMode.Update)
            {
                dtpDateTest.Value = _TestAppointments.AppointmentDate;
                lblFees.Text = _TestAppointments.PaidFees.ToString();

            }
            else
            {
                dtpDateTest.Value = DateTime.Now;
                lblFees.Text = (TotalFees = clsTestType.GetFeesTestType(SelectedTestType)).ToString();
            }

            
            if(SelectedApplicationType == enApplicationType.RetakeScheduleTest)
            {
                lblRetakTestAppFees.Text = clsApplicationTypes.GetFeesApplicationType(clsApplicationTypes.enApplicationType.RetakeTest).ToString();
                TotalFees += Convert.ToDecimal(lblRetakTestAppFees.Text);
                if(Mode == enMode.Update) 
                    lblRetakeTestAppID.Text = _TestAppointments.RetakeTestApplicationID.ToString();
            }


            lblTotalFees.Text = TotalFees.ToString();
            
        }

        private bool IsRetakeTestApplicationCreated()
        {
            if(SelectedApplicationType == enApplicationType.RetakeScheduleTest)
            {
                RetackTestApp = new clsApplication();

                RetackTestApp.ApplicationPersonID = _LocalDrivingLicenseApp.ApplicationPersonInfo.PersonID;
                RetackTestApp.ApplicationDate = DateTime.Now;
                RetackTestApp.ApplicationTypeID = (byte)clsApplicationTypes.enApplicationType.RetakeTest;
                RetackTestApp.ApplicationStatus = (byte)clsApplication.enStatus.New;
                RetackTestApp.LastStatusDate = DateTime.Now;
                RetackTestApp.PaidFees = clsApplicationTypes.GetFeesApplicationType(clsApplicationTypes.enApplicationType.RetakeTest);
                RetackTestApp.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            }
            

            return RetackTestApp.Save();
        }

        public void LoadSchedultTestDataWithLocalDrivingLicenseAppID(int LocalDrivingLicenseAppID)
        {
            if (!(dtpDateTest.Enabled = btnSave.Enabled = !clsLicenses.IsLicenseExistWithLocalDrivingLicenseAppID(LocalDrivingLicenseAppID)))
            {
                MessageBox.Show($"The person with local driving license app id = {LocalDrivingLicenseAppID} is already has a local driving license", "Not alload"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblMessageError.Visible = true;
                lblMessageError.Text = "Not alload, the person is already has a local driving license.";
                return;
            }

            if(!(dtpDateTest.Enabled = btnSave.Enabled = !clsLocalLicenseApplication.IsLocalDrivingLicenseAppCanceled(LocalDrivingLicenseAppID)))
            {
                MessageBox.Show($"Not alload, the local driving license app with id = {LocalDrivingLicenseAppID} is canceled", "Not alload"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblMessageError.Visible = true;
                lblMessageError.Text = "Not alload, the local driving license is canceled!!.";
                return;
            }

            _LocalDrivingLicenseApp = clsLocalLicenseApplication.Find(LocalDrivingLicenseAppID);

            if (!(dtpDateTest.Enabled = btnSave.Enabled = !(_LocalDrivingLicenseApp == null)))
            {
                MessageBox.Show($"Error: the local driving license application with id = {LocalDrivingLicenseAppID} was no find!!", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblMessageError.Visible = true;
                lblMessageError.Text = "Error: the local driving license app is missing!!";
                return;
            }

            


            SelectTheCurrentTestTypeForTheDriver_sLicenseApplicant();
            SelectTheMode();
            SelectApplicationType();

            ShowSchedultTestData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(IsTheDataOfTheTestApointmentSaved())
            {
                MessageBox.Show("The data saved successfully.", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(_SelectedApplicationType == enApplicationType.RetakeScheduleTest)
                {
                    if(Mode == enMode.AddNew)
                        lblRetakeTestAppID.Text = RetackTestApp.ApplicationID.ToString();
                    else
                        lblRetakeTestAppID.Text = _TestAppointments.RetakeTestApplicationID.ToString();
                }
            }
            else
            {
                MessageBox.Show("Error: the data was not save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            btnSave.Enabled = false;
        }
    }
}
