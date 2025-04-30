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
    public partial class FormNewLocalLicenseApplication : Form
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;

        private int _PersonID = -1;
        private int _LocalDrivingLicenseAppID;
        private clsLocalLicenseApplication _LocalDrivingLicenseApp;
        
        public FormNewLocalLicenseApplication()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public FormNewLocalLicenseApplication(int LocalDrivingLicenseAppID)
        {
            InitializeComponent();
            _LocalDrivingLicenseAppID = LocalDrivingLicenseAppID;
            _Mode = enMode.Update;
        }

        private enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 }
        
        private clsLicenseClasses.enLicenseClass _SelectedLicenseClass = clsLicenseClasses.enLicenseClass.OrdinaryDrivingLicense;

        private clsApplicationTypes _ApplicationType = clsApplicationTypes.Find("New Local Driving License Service");

        private void _PrepareTheFormWithDefaultValues()
        {
            lblNameOfUser.Text = clsGlobal.CurrentUser.UserName;
            _FillcbLicenseClasses();

            if (_Mode == enMode.AddNew)
            {
                this.Text = "Add New Local Driving License Application.";
                lblTitleForm.Text = "Add New Local Driving License Application";
                pApplicationInfo.Enabled = false;
                btnNext.Enabled = false;
                lblApplicationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                lblApplicationFees.Text = _ApplicationType.Fees.ToString();
            }
            else if(_Mode == enMode.Update)
            {
                this.Text = "Update Local Driving License Application.";
                lblTitleForm.Text = "Update Local Driving License Application";
                ctrlPersonCartWithFilter1.FilterEnabled = false;
                pApplicationInfo.Enabled = true ;
                btnNext.Enabled = true;
                
            }

            
        }
        private void _FillcbLicenseClasses()
        {
            DataTable dtClassesName = clsLicenseClasses.GetAllLicenseClasses();

            foreach (DataRow ClassName in dtClassesName.Rows)
            {
                cbLicenseClasses.Items.Add(ClassName["ClassName"].ToString());
            }

            cbLicenseClasses.SelectedIndex = cbLicenseClasses.FindString("Class 3 - Ordinary driving license");
        }
        private void _LoadDataOfLocalDrivingLicenceApplication()
        {
            _LocalDrivingLicenseApp = clsLocalLicenseApplication.Find(_LocalDrivingLicenseAppID);

            if (_LocalDrivingLicenseApp != null)
            {
                ctrlPersonCartWithFilter1.LoadPersonInfo(_LocalDrivingLicenseApp.ApplicationPersonID);
                lblApplicationID.Text = _LocalDrivingLicenseAppID.ToString();
                lblApplicationDate.Text = _LocalDrivingLicenseApp.LastStatusDate.ToString("dd/MM/yyyy");
                lblApplicationFees.Text = _LocalDrivingLicenseApp.PaidFees.ToString();
                cbLicenseClasses.SelectedItem = _LocalDrivingLicenseApp.LicensClassInfo.ClassName;
            }
            else
            {
                MessageBox.Show($"Sorry Was not Found A Local Driving SelectedLicense With ID {_LocalDrivingLicenseAppID}","Error"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }    
        }
        private void _FillObjectLocalDrivingLicenseApplicationWithInfo()
        {
            if(_Mode == enMode.AddNew)
            {
                _LocalDrivingLicenseApp = new clsLocalLicenseApplication();

                _LocalDrivingLicenseApp.LicenseClassID = (int)_SelectedLicenseClass;
                _LocalDrivingLicenseApp.ApplicationPersonID = _PersonID;
                _LocalDrivingLicenseApp.ApplicationDate = DateTime.Now;
                _LocalDrivingLicenseApp.ApplicationStatus = (byte)enApplicationStatus.New;
                _LocalDrivingLicenseApp.LastStatusDate = DateTime.Now;
                _LocalDrivingLicenseApp.ApplicationTypeID = _ApplicationType.ID;
                _LocalDrivingLicenseApp.PaidFees = (decimal)_ApplicationType.Fees;
                _LocalDrivingLicenseApp.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            }

            _LocalDrivingLicenseApp.LicenseClassID = (int)_SelectedLicenseClass;
            _LocalDrivingLicenseApp.CreatedByUserID = clsGlobal.CurrentUser.UserID;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            if (_Mode == enMode.AddNew && _PersonID == -1)
            {
                MessageBox.Show("Please Selected A Person.","Selected Person"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            tcAddLocalDrivingLicenseApplication.SelectedTab 
                = tcAddLocalDrivingLicenseApplication.TabPages["pApplicationInfo"];
            btnSave.Enabled = true;

        }

        private void ctrlPersonCartWithFilter1_OnPersonSelected(int obj)
        {
            pApplicationInfo.Enabled = true;
            
            btnNext.Enabled = true;
            _PersonID = obj;
        }

        private void FormNewLocalLicenseApplication_Load(object sender, EventArgs e)
        {
            _PrepareTheFormWithDefaultValues();
            if (_Mode == enMode.Update)
                _LoadDataOfLocalDrivingLicenceApplication();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsLicenses.IsLicenseExistWithPersonID(ctrlPersonCartWithFilter1.PersonID, _SelectedLicenseClass))
            {
                MessageBox.Show("Person Already Have a License With The Same Applied Driving Class, Choose Diffrent Driving Class.", "Not Allowed."
                     , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int ApplicationID = -1;
             if (clsLocalLicenseApplication.DoesHaveApplicationActiveWithLicenseClass(ref ApplicationID, ctrlPersonCartWithFilter1.PersonID, (byte)_SelectedLicenseClass))
             {
                 MessageBox.Show("Choose Another License Class, The Selected Person Already Have An Active Application "
                                + $"For The Selected Class With ID ={ApplicationID}.", "Not Allowed."
                     , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 return;
             }

            if (_Mode == enMode.Update && clsLocalLicenseApplication.IsLocalDrivingLicenseAppCanceled(_LocalDrivingLicenseAppID))
             {
                 MessageBox.Show($"The Local Driving License Application With ID [{_LocalDrivingLicenseAppID}] Is Canceled, You Can't Edit It."
                                 , "Error."
                      , MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }
        

             _FillObjectLocalDrivingLicenseApplicationWithInfo();

             if (_LocalDrivingLicenseApp.Save())
             {
                 MessageBox.Show($"Local Driving License Application Saved Successfully.", "Saved"
                 , MessageBoxButtons.OK, MessageBoxIcon.Information);
                 lblApplicationID.Text = _LocalDrivingLicenseApp.ApplicationID.ToString();
                _Mode = enMode.Update;
                this.Text = "Update Local Driving License Application.";
                lblTitleForm.Text = "Update Local Driving License Application";
            }
             else
             {
                 MessageBox.Show("Saved Faild", "Error."
                 , MessageBoxButtons.OK, MessageBoxIcon.Error);
             }   

        }
        
        private void cbLicenseClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectedLicenseClass = (clsLicenseClasses.enLicenseClass)cbLicenseClasses.SelectedIndex + 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNewLocalLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlPersonCartWithFilter1.FilterFocus();
        }
    }
}
