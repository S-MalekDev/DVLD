using DVLD_BusinessLayer;
using DVLD_Project.Properties;
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
    public partial class FormTakeTest : Form
    {
        private clsTests _Test;
        private clsTestType.enTestType _SelectedTestType;
        private clsTestAppointments _TestAppointment;
        public FormTakeTest(int TestAppointmentID, clsTestType.enTestType type)
        {
            InitializeComponent();
            _SelectedTestType = type;
            _TestAppointment = clsTestAppointments.Find(TestAppointmentID);
        }

        private void _LoadTheTitleAndTheImage()
        {
            switch (_SelectedTestType)
            {
                case clsTestType.enTestType.VisionTest:
                    {
                        gbTakeTest.Text = "Vision Test";
                        lblTestTittle.Text = "Vision Test";
                        pbTestImage.Image = Resources.Vision_512; ;
                        break;
                    }
                case clsTestType.enTestType.WrittenTest:
                    {
                        gbTakeTest.Text = "Written Test";
                        lblTestTittle.Text = "Written Test";
                        pbTestImage.Image = Resources.Written_Test_512; 
                        break;
                    }
                case clsTestType.enTestType.PracticalTest:
                    {
                        gbTakeTest.Text = "Driving Test";
                        lblTestTittle.Text = "Driving Test";
                        pbTestImage.Image = Resources.Driving_test; ;
                        break;
                    }
            }

        }
        private void _LoadDataOnTheForm()
        {
            if(_TestAppointment == null)
            {
                MessageBox.Show("Error: The Test Appointment Was No Find !!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                return;
            }

            clsLocalLicenseApplication LocalDrivingLicenseApp = clsLocalLicenseApplication.Find(_TestAppointment.LocalDrivingLicenseApplicationID);
            lblLocalDrivingLicenseAppID.Text = LocalDrivingLicenseApp.LocalDrivingLicenseApplicationID.ToString();
            lblLicenseClass.Text = LocalDrivingLicenseApp.LicensClassInfo.ClassName;
            lblName.Text = LocalDrivingLicenseApp.PersonFullName;
            lblTrial.Text = clsTests.GetNumberTestsPassedWithLocalDrivingLicenseAppID(LocalDrivingLicenseApp.LocalDrivingLicenseApplicationID).ToString();
            lblDate.Text = _TestAppointment.AppointmentDate.ToString("dd/MMM/yyyy");
            lblFees.Text = clsTestType.GetFeesTestType(_SelectedTestType).ToString();

        }
        private void _CreateATestAndUpLoadInfo()
        {
            _Test = new clsTests();
            _Test.TestAppointmentID = _TestAppointment.TestAppointmentID;
            _Test.TestResult = rbPass.Checked;

            if (!string.IsNullOrEmpty(tbNotes.Text))
                _Test.Notes = tbNotes.Text;

            _Test.CreatedByUserID = clsGlobal.CurrentUser.UserID;


        }

        private void FormTakeTest_Load(object sender, EventArgs e)
        {
            _LoadTheTitleAndTheImage();
            _LoadDataOnTheForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure You Want To Save? After That You Cannot Change The Pass/Fail Result After You Save."
                ,"Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                _CreateATestAndUpLoadInfo();

                if(_Test.Save() && _TestAppointment.Locked())
                {
                    if(_TestAppointment.RetakeTestApplicationID!=default)
                    {
                        clsApplication.SetCompleted(_TestAppointment.RetakeTestApplicationID);
                    }

                    lblTestID.Text = _Test.TestID.ToString();
                    MessageBox.Show("Data Save Successfully."
                 ,"Success Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Error: Saved Faild."
                 , "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
