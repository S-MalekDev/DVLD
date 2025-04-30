using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_BusinessLayer
{
    public class clsApplication
    {
        public enum enApplicationType
        {
            NewLocalDrivingLicenseService = 1, RenewDrivingLicenseService = 2, ReplacementForALostDrivingLicense = 3
                , ReplacementForADamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6
                , RetakeTest = 7
        }

        public enum enStatus { New = 1, Canceled = 2,Completed = 3 }
        protected enum enMode { AddNew = 0, Update = 1 } 
        protected enMode  _Mode;

        public int ApplicationID { get; set; }
        public int ApplicationPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public byte ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public string StatusText
        {
            get
            {
                switch(ApplicationStatus)
                {
                    case 1:
                        return "New";
                    case 2:
                        return "Cancelled";
                    case 3:
                        return "Completed";
                    default:
                        return "Unknown";
                }
            }
        }

        public clsPeople ApplicationPersonInfo = null;
        public clsUser CreatedByUserInfo=null;
        public clsApplicationTypes ApplicationTypeInfo = null;

        public clsApplication()
        {
            ApplicationID = -1;
            ApplicationPersonID = -1;
            ApplicationDate = DateTime.Now; 
            ApplicationTypeID = -1;
            ApplicationStatus = 4;
            LastStatusDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = -1;

            _Mode = enMode.AddNew;
        }
        protected clsApplication(int ApplicationID, int ApplicationPersonID, DateTime ApplicationDate, int ApplicationTypeID
            , byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicationPersonID = ApplicationPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;

            ApplicationPersonInfo = clsPeople.Find(this.ApplicationPersonID);
            CreatedByUserInfo = clsUser.FindByUserID(this.CreatedByUserID);
            ApplicationTypeInfo = clsApplicationTypes.Find(this.ApplicationTypeID);

            _Mode = enMode.Update;
        }

        
        private bool _AddNewApplication()
        {
            this.ApplicationID = clsDataApplications.AddNewApplication(this.ApplicationPersonID, this.ApplicationDate
                , this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

            return this.ApplicationID != -1;
        }

        private bool _UpdateApplication()
        {
            return clsDataApplications.UpdateApplication(this.ApplicationID, this.ApplicationPersonID, this.ApplicationDate
                , this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
        }

        static public bool DeleteApplication(int ApplicationID)
        {
            return clsDataApplications.DeleteApplication(ApplicationID);
        }
        static public clsApplication Find(int ApplicationID)
        { 
            int ApplicationPersonID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = -1;
            byte ApplicationStatus = 0;
            DateTime LastStatusDate = DateTime.Now;
            decimal PaidFees = 0;
            int CreatedByUserID = -1;

            if (clsDataApplications.GetApplicationInfoByID(ApplicationID, ref ApplicationPersonID, ref ApplicationDate, ref ApplicationTypeID
            , ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                return new clsApplication(ApplicationID, ApplicationPersonID, ApplicationDate, ApplicationTypeID
            , ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            }
            else
                return null;
        }

        static public bool Cancel(int ApplicationID)
        {
            return clsDataApplications.UpdateStatus(ApplicationID,2);
        }

        public bool Cancel()
        {
            return clsDataApplications.UpdateStatus(this.ApplicationID, 2);
        }

        static public bool SetCompleted(int ApplicationID)
        {
            return clsDataApplications.UpdateStatus(ApplicationID, 3);
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                {
                    if (_AddNewApplication())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                }
                case enMode.Update:
                {
                    return _UpdateApplication();
                }
                default:
                {
                    return false;
                }

            }
            
        }

    }
}
