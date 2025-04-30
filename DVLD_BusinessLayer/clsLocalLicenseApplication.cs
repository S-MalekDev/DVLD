using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_BusinessLayer
{
    public class clsLocalLicenseApplication :clsApplication
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        public int LocalDrivingLicenseApplicationID { get; set; }
       public int LicenseClassID { get; set; }
       public string PersonFullName
        {
            get
            {
                return base.ApplicationPersonInfo.FullName;
            }
        }

       public clsLicenseClasses LicensClassInfo;
        public clsLocalLicenseApplication()
        {
            LocalDrivingLicenseApplicationID = -1;
            ApplicationID = -1;
            LicenseClassID = -1;
            ApplicationID = -1;
            ApplicationPersonID = -1;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = -1;
            ApplicationStatus = 4;
            LastStatusDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = -1;
            LicensClassInfo = null;

            _Mode = enMode.AddNew;
        }

        protected clsLocalLicenseApplication( int localDrivingLicenseApplicationID, int licenseClassID , int ApplicationID
            , int ApplicationPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate
            , decimal PaidFees, int CreatedByUserID) 
            :base( ApplicationID,  ApplicationPersonID,  ApplicationDate,  ApplicationTypeID,  ApplicationStatus,  LastStatusDate
                 ,  PaidFees,  CreatedByUserID)
        {
            
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            LicenseClassID = licenseClassID;
            LicensClassInfo = clsLicenseClasses.Find(licenseClassID);

            _Mode = enMode.Update;
        }

        private bool _AddNewLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = clsDataLocalLicenseApplication.AddNewLocalDrivingLicenseApplication
                (this.ApplicationID,this.LicenseClassID);

            return this.LocalDrivingLicenseApplicationID != -1;
        }
        private bool _UpdateLocalDrivingLicenseApplication()
        {
            return clsDataLocalLicenseApplication.UpdateLocalDrivingLicenseApplication
                (this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID);
        }

        public bool DoesItHaveADrivingLicense()
        {
            return clsDataLocalLicenseApplication.DoesItHaveADrivingLicense(this.ApplicationID);
        }

        static public clsLocalLicenseApplication Find(int LocalDrivingLicenseAppID)
        {

            int ApplicationID = -1;
            int LicenseClassID = -1;

            if (clsDataLocalLicenseApplication.GetLocalLicenseAppInfoByID(LocalDrivingLicenseAppID, ref ApplicationID, ref LicenseClassID))
            {
                clsApplication App = clsApplication.Find(ApplicationID);
                return new clsLocalLicenseApplication(LocalDrivingLicenseAppID , LicenseClassID, App.ApplicationID,App.ApplicationPersonID
                    ,App.ApplicationDate,App.ApplicationTypeID,App.ApplicationStatus,App.LastStatusDate,App.PaidFees,App.CreatedByUserID);
            }
            else
                return null;
        }

        static public bool CancelWithLocalDrivingLicenseAppID(int LocalDrivingLicenseAppID)
        {
            return clsDataLocalLicenseApplication.UpdateLocalDrivingLicenseAppStatus(LocalDrivingLicenseAppID,2);
        }

        static public DataTable GetAllLocalDrivingLicenseApplication()
        {
            return clsDataLocalLicenseApplication.GetAllLocalDrivingLicenseApplication();
        }

        public bool Deleted()
        {
            int ApplicationID = this.ApplicationID;

            if (clsDataLocalLicenseApplication.DeleteLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID))
            {
                return clsApplication.DeleteApplication(ApplicationID);
            }
            else return false;
        }

        static public bool DeleteLocalDrivingLicenseApp(int LocalDrivingLicenseAppID)
        {
            int AppID = clsLocalLicenseApplication.Find(LocalDrivingLicenseAppID).ApplicationID;

            if (clsDataLocalLicenseApplication.DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseAppID))
            {
                return clsApplication.DeleteApplication(AppID);
            }
            else return false;

        }

        static public bool IsLocalDrivingLicenseAppCanceled(int LocalDrivingLicenseAppID)
        {
            return clsDataLocalLicenseApplication.IsLocalDrivingLicenseAppCanceled(LocalDrivingLicenseAppID); 
        }

        static public bool DoesHaveApplicationActiveWithLicenseClass(ref int ApplicationID, int PersonID, int LicenseClassID)
        {
            return clsDataLocalLicenseApplication.DoesHaveApplicationActiveWithLicenseClass(ref ApplicationID, PersonID, LicenseClassID);
        }
        
        static public bool IsLocalDrivingLicenseAppActive(int LocalDrivinLicenseAppID)
        {
            return clsDataLocalLicenseApplication.IsLocalDrivingLicenseAppActive(LocalDrivinLicenseAppID);
        }


        static public bool IsLocalDrivingLicenseAppOnStatusNew(int LocalDrivinLicenseAppID)
        {
            return IsLocalDrivingLicenseAppActive(LocalDrivinLicenseAppID);
        }

        public bool IsLicenseIssued()
        {
            return clsDataLocalLicenseApplication.IsLicenseIssued(this.ApplicationID);
        }
        public byte GetTheNumberOfTestsTheApplicantHasPassed()
        {
            return clsDataLocalLicenseApplication.GetNumberTestsPassedWithLocalDrivingLicenseAppID(this.LocalDrivingLicenseApplicationID);
        }


        public bool HaveHeEverTakenATestBeforeFromTheType(clsTestType.enTestType testType)
        {
            return clsDataLocalLicenseApplication.HaveHeEverTakenATestBeforeFromTheType(this.LocalDrivingLicenseApplicationID, (byte)testType);
        }


        static public byte GetNumberTestsPassedWithLocalDrivingLicenseAppID(int LocalDrivingLicenseAppID)
        {
            return clsDataLocalLicenseApplication.GetNumberTestsPassedWithLocalDrivingLicenseAppID(LocalDrivingLicenseAppID);
        }
        
        public bool IsHeHaveAnAppointmentAndWasNotAttendItYet()
        {
            return clsDataLocalLicenseApplication.DidHeEverHasAnAppointment(this.LocalDrivingLicenseApplicationID) 
                && !clsDataLocalLicenseApplication.DidHeAttendHisLastAppointment(this.LocalDrivingLicenseApplicationID);
        }


        public byte GetTheNumberOfTrialsByTestType(clsTestType.enTestType testType)
        {
            return clsDataLocalLicenseApplication.GetTheNumberOfTrialsByTestType(this.LocalDrivingLicenseApplicationID,(byte)testType);
        }

        private void SetCompleted()
        {
            clsDataLocalLicenseApplication.UpdateLocalDrivingLicenseAppStatus(this.LocalDrivingLicenseApplicationID, 3);
        }
         public int IssuedLicenseForTheFirstTime(string Notes,int CreatedByUserID)
        {
            int DriverID = -1;
            
            if(!clsDrivers.IsDriverExistWithPersonID(this.ApplicationPersonID,ref DriverID))
            {
                clsDrivers NewDriver = new clsDrivers();
                NewDriver.PersonID = this.ApplicationPersonID;
                NewDriver.CreatedByUserID = CreatedByUserID;
                if (!NewDriver.Save())
                {
                    return -1;
                }
                else
                {
                    DriverID = NewDriver.DriverID;
                }
            }

            clsLicenses License = new clsLicenses();
            License.ApplicationID = this.ApplicationID;
            License.DriverID = DriverID;
            License.LicenseClass = this.LicenseClassID;
            License.IssueDate = DateTime.Now;
            License.ExpirationDate = DateTime.Now.AddYears(this.LicensClassInfo.DefaultValidityLength);

            if (!string.IsNullOrEmpty(Notes))
                License.Notes = Notes;

            License.PaidFees = this.LicensClassInfo.ClassFees;
            License.IsActive = true;
            License.IssueReason = clsLicenses.enIssueReason.FirstTime;
            License.CreatedByUserID = CreatedByUserID;
            if(License.Save())
            {
                this.SetCompleted();
                return License.LicenseID;
            }
            else
            {
                return -1;
            }
        }


        public DateTime GetTheDateOfTheLastTestAppointment()
        {
            return clsDataLocalLicenseApplication.GetTheDateOfTheLastTestAppointment(this.LocalDrivingLicenseApplicationID); 
        }
        public bool Cancel()
        {

            return clsDataApplications.CancelApplication(this.ApplicationID);
        }

        public bool Save()
        {
            base._Mode = (clsApplication.enMode)_Mode;

            if (!base.Save())
                return false;

            switch (_Mode)
            {
                case enMode.AddNew:
                {
                    if (_AddNewLocalDrivingLicenseApplication())
                    {
                            _Mode = enMode.Update;
                            return true;
                    }
                    else
                        return false;
                    

                }
                case enMode.Update:
                {
                    return _UpdateLocalDrivingLicenseApplication();

                }
                default:
                {
                    return false;
                }
            }

        }

    }
}
