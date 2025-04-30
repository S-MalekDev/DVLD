using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLD_BusinessLayer.clsLicenseClasses;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_BusinessLayer
{
    public class clsLicenses
    {
        
        public enum enIssueReason { FirstTime=1, Renew=2, ReplacementForDamaged=3, ReplacementForLost=4}
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        public string IssueReasonText
        {
            get
            {
                switch(this.IssueReason)
                {
                    case enIssueReason.FirstTime:
                    {
                        return "First Time";
                    }
                    case enIssueReason.Renew:
                    {
                        return "Renew License";
                    }
                    case enIssueReason.ReplacementForDamaged:
                    {
                        return "Replacement For Damaged";
                    }
                    case enIssueReason.ReplacementForLost:
                    {
                        return "Replacement For Lost";
                    }
                    default:
                    {
                        return "Unknown";
                    }
                }
            }
        }
        public Int32 LicenseID { get; set; }
        public Int32 ApplicationID { get; set; }
        public Int32 DriverID { get; set; }
        public Int32 LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public String Notes { get; set; }
        public Decimal PaidFees { get; set; }
        public Boolean IsActive { get; set; }
        public enIssueReason IssueReason { get; set; }
        public Int32 CreatedByUserID { get; set; }

        private clsApplication _ApplicationInfo;
        private clsDrivers _DriverInfo;
        private clsLicenseClasses _LicenseClassInfo;        
        private clsUser _UserInfoWhoCreatedit;

        public clsApplication ApplicationInfo { get {  return _ApplicationInfo; } }
        public clsDrivers DriverInfo { get { return _DriverInfo; } }
        public clsLicenseClasses LicenseClassInfo { get { return _LicenseClassInfo; } }
        public clsUser UserInfoWhoCreatedit { get { return _UserInfoWhoCreatedit; } }


        public clsLicenses()
        {
            LicenseID = default;
            ApplicationID = default;
            DriverID = default;
            LicenseClass = default;
            IssueDate = default;
            ExpirationDate = default;
            Notes = default;
            PaidFees = default;
            IsActive = default;
            IssueReason = default;
            CreatedByUserID = default;

            _ApplicationInfo = null;
            _DriverInfo = null;
            _LicenseClassInfo = null;
            _UserInfoWhoCreatedit = null;

            _Mode = enMode.AddNew;
        }
        private clsLicenses(Int32 LicenseID, Int32 ApplicationID, Int32 DriverID, Int32 LicenseClass, DateTime IssueDate
            , DateTime ExpirationDate, String Notes, Decimal PaidFees, Boolean IsActive, enIssueReason IssueReason, Int32 CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;

            _ApplicationInfo = clsApplication.Find(ApplicationID);
            _DriverInfo = clsDrivers.Find(DriverID);
            _LicenseClassInfo = clsLicenseClasses.Find(LicenseClass);
            _UserInfoWhoCreatedit = clsUser.FindByUserID(CreatedByUserID);
            _Mode = enMode.Update;
        }

        static public DataTable GetAllLocalLicensesWithPersonID(int PersonID)
        {
            return clsDataLicenses.GetAllLocalLicensesWithPersonID(PersonID);
        }

        static public clsLicenses Find(Int32 LicenseID)
        {

            Int32 ApplicationID = default;
            Int32 DriverID = default;
            Int32 LicenseClass = default;
            DateTime IssueDate = default;
            DateTime ExpirationDate = default;
            String Notes = default;
            Decimal PaidFees = default;
            Boolean IsActive = default;
            Byte IssueReason = default;
            Int32 CreatedByUserID = default;


            if (clsDataLicenses.GetLicenseInfoByID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicenses(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive,(enIssueReason) IssueReason, CreatedByUserID);
            }
            else
            {
                return null;
            }

        }

        static public clsLicenses FindByLocalDrivingLicenseAppID(int LocalDrivingLicenseApplicationID)
        {
            int LicenseID = default;
            int ApplicationID = default;
            int DriverID = default;
            int LicenseClass = default;
            DateTime IssueDate = default;
            DateTime ExpirationDate = default;
            string Notes = default;
            decimal PaidFees = default;
            bool IsActive = default;
            byte IssueReason = default;
            int CreatedByUserID = default;

            if (clsDataLicenses.GetLicenseInfoByLocalDrivingLicenseAppID(LocalDrivingLicenseApplicationID, ref LicenseID, ref ApplicationID, ref DriverID
            , ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees
            , ref IsActive, ref IssueReason, ref CreatedByUserID))
            {

                return new clsLicenses(LicenseID, ApplicationID, DriverID
            , LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees
            , IsActive, (enIssueReason)IssueReason, CreatedByUserID);
            }
            else
                return null;
        }
        private bool _AddNewLicense()
        {
            this.LicenseID = clsDataLicenses.AddNewLicense(this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);

            return LicenseID != -1;
        }

        private bool _UpdateLicense()
        {
            return clsDataLicenses.UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);
        }

        static public bool IsLicenseExistWithLocalDrivingLicenseAppID(int LocalDrivingLicenseAppID)
        {
            return clsDataLicenses.IsLicenseExistWithLocalDrivingLicenseAppID(LocalDrivingLicenseAppID);
        }

        public bool IsExpiared()
        {
            return (this.ExpirationDate < DateTime.Now);
        }

        static public bool DeleteLicense(Int32 LicenseID)
        {
            return clsDataLicenses.DeleteLicense(LicenseID);
        }

        public clsDetainedLicenses Detain(decimal Fees, int CreatedByUser)
        {

            clsDetainedLicenses DetainLicense = new clsDetainedLicenses();

            DetainLicense.LicenseID = this.LicenseID;
            DetainLicense.DetainDate = DateTime.Now;
            DetainLicense.FineFees = Fees;
            DetainLicense.CreatedByUserID = CreatedByUser;
            DetainLicense.IsReleased = false;

            if(DetainLicense.Save())
                return DetainLicense;

            else return null;
        }
        public bool IsDetain()
        {
            return clsDataDetainedLicenses.IsLicenseDetain(this.LicenseID);
        }
        static public bool IsLicenseExistWithLicenseID(Int32 LicenseID)
        {
            return clsDataLicenses.IsLicenseExistWithLicenseID(LicenseID);
        }

        static public bool IsLicenseExistWithPersonID(int PersonID)
        {
            return clsDataLicenses.IsLicenseExistWithPersonID(PersonID);
        }

        private void DeactivateCurrentLicense()
        {
             clsDataLicenses.UpdateLicenseStatus(this.LicenseID,false);
        }

        public int Release(int CreatedByUser)
        {
            clsDetainedLicenses DetainLicense = null;
            if((DetainLicense= clsDetainedLicenses.FindByLicenseID(this.LicenseID)) == null)
            {
                return -1;
            }

            clsApplication ReleaseApp = new clsApplication();
            ReleaseApp.ApplicationPersonID = this.DriverInfo.PersonID;
            ReleaseApp.ApplicationDate = DateTime.Now;
            ReleaseApp.ApplicationTypeID = (byte)clsApplicationTypes.enApplicationType.ReleaseDetainedDrivingLicsense;
            ReleaseApp.ApplicationStatus = (byte)clsApplication.enStatus.Completed;
            ReleaseApp.LastStatusDate = DateTime.Now;
            ReleaseApp.PaidFees = clsApplicationTypes.GetFeesApplicationType(clsApplicationTypes.enApplicationType.ReleaseDetainedDrivingLicsense);
            ReleaseApp.CreatedByUserID = CreatedByUser;

            if (!ReleaseApp.Save())
                return -1;


            DetainLicense.IsReleased = true;
            DetainLicense.ReleaseDate = DateTime.Now;
            DetainLicense.ReleasedByUserID = CreatedByUser;
            DetainLicense.ReleaseApplicationID = ReleaseApp.ApplicationID;
            if (DetainLicense.Save())
            {
                return DetainLicense.ReleaseApplicationID;
            }
            else
                return -1;
        }
        public clsLicenses RenewLicense(string Notes,int CreatedbyUserID)
        {
            if (!this.IsExpiared())
                return null ;

            clsApplication RenewApp = new clsApplication();
            RenewApp.ApplicationPersonID = this.DriverInfo.PersonID;
            RenewApp.ApplicationDate = DateTime.Now;
            RenewApp.ApplicationTypeID = (byte)clsApplicationTypes.enApplicationType.RenewDrivingLicenseService;
            RenewApp.ApplicationStatus = (byte)clsApplication.enStatus.Completed;
            RenewApp.LastStatusDate = DateTime.Now;
            RenewApp.PaidFees = clsApplicationTypes.GetFeesApplicationType(clsApplicationTypes.enApplicationType.RenewDrivingLicenseService);
            RenewApp.CreatedByUserID = CreatedbyUserID;

            if (!RenewApp.Save())
                return null;


            clsLicenses NewLicense = new clsLicenses();
            NewLicense.ApplicationID = RenewApp.ApplicationID;
            NewLicense.DriverID = this.DriverInfo.DriverID;
            NewLicense.LicenseClass = this.LicenseClass;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = DateTime.Now.AddYears(this.LicenseClassInfo.DefaultValidityLength);
            NewLicense.Notes = (string.IsNullOrEmpty(Notes))? default : Notes;
            NewLicense.PaidFees = this.LicenseClassInfo.ClassFees;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = enIssueReason.Renew;
            NewLicense.CreatedByUserID = CreatedbyUserID;
            if(NewLicense.Save())
            {
                this.DeactivateCurrentLicense();
                return NewLicense;
            }

            return null;
        }

        public clsLicenses ReplacementLicenseForDamaged(int CreatedByUserID)
        {
            if (!this.IsActive)
                return null;

            clsApplication DamagedApp = new clsApplication();
            DamagedApp.ApplicationPersonID = this.DriverInfo.PersonID;
            DamagedApp.ApplicationDate = DateTime.Now;
            DamagedApp.ApplicationTypeID = (byte)clsApplicationTypes.enApplicationType.ReplacementForADamagedDrivingLicense;
            DamagedApp.ApplicationStatus = (byte)clsApplication.enStatus.Completed;
            DamagedApp.LastStatusDate = DateTime.Now;
            DamagedApp.PaidFees = clsApplicationTypes.GetFeesApplicationType(clsApplicationTypes.enApplicationType.ReplacementForADamagedDrivingLicense);
            DamagedApp.CreatedByUserID = CreatedByUserID;

            if (!DamagedApp.Save())
                return null;


            clsLicenses ReplacementLicense = new clsLicenses();
            ReplacementLicense.ApplicationID = DamagedApp.ApplicationID;
            ReplacementLicense.DriverID = this.DriverInfo.DriverID;
            ReplacementLicense.LicenseClass = this.LicenseClass;
            ReplacementLicense.IssueDate = DateTime.Now;
            ReplacementLicense.ExpirationDate = DateTime.Now.AddYears(this.LicenseClassInfo.DefaultValidityLength);
            ReplacementLicense.Notes = (string.IsNullOrEmpty(this.Notes)) ? default : this.Notes;
            ReplacementLicense.PaidFees = this.PaidFees;
            ReplacementLicense.IsActive = true;
            ReplacementLicense.IssueReason = enIssueReason.ReplacementForDamaged;
            ReplacementLicense.CreatedByUserID = CreatedByUserID;
            if (!ReplacementLicense.Save())           
                return null;

            else
            {
                this.DeactivateCurrentLicense();
                return ReplacementLicense;
            }
        }

        public clsInternationalLicenses IssueInternationalLicense(int CreatedByUserID)
        {
            if (!this.IsActive)
                return null;

            clsApplication InternationalLicenseApp = new clsApplication();
            InternationalLicenseApp.ApplicationPersonID = this.DriverInfo.PersonID;
            InternationalLicenseApp.ApplicationDate = DateTime.Now;
            InternationalLicenseApp.ApplicationTypeID = (byte)clsApplicationTypes.enApplicationType.NewInternationalLicense;
            InternationalLicenseApp.ApplicationStatus = (byte)clsApplication.enStatus.Completed;
            InternationalLicenseApp.LastStatusDate = DateTime.Now;
            InternationalLicenseApp.PaidFees = clsApplicationTypes.GetFeesApplicationType(clsApplicationTypes.enApplicationType.NewInternationalLicense);
            InternationalLicenseApp.CreatedByUserID = CreatedByUserID;

            if (!InternationalLicenseApp.Save())
                return null;


            clsInternationalLicenses NewInternationalLicese = new clsInternationalLicenses();
            NewInternationalLicese.ApplicationID = InternationalLicenseApp.ApplicationID;
            NewInternationalLicese.DriverID = this.DriverInfo.DriverID;
            NewInternationalLicese.IssuedUsingLocalLicenseID = this.LicenseID;
            NewInternationalLicese.IssueDate = DateTime.Now;
            NewInternationalLicese.ExpirationDate = DateTime.Now.AddYears(1);
            NewInternationalLicese.IsActive = true;
            NewInternationalLicese.CreatedByUserID = CreatedByUserID;

            if (NewInternationalLicese.Save())
            {
                return NewInternationalLicese;
            }

            return null;
        }
        public clsLicenses ReplacementLicenseForLost(int CreatedByUserID)
        {
            if (!this.IsActive)
                return null;

            clsApplication LostApp = new clsApplication();
            LostApp.ApplicationPersonID = this.DriverInfo.PersonID;
            LostApp.ApplicationDate = DateTime.Now;
            LostApp.ApplicationTypeID = (byte)clsApplicationTypes.enApplicationType.ReplacementForALostDrivingLicense;
            LostApp.ApplicationStatus = (byte)clsApplication.enStatus.Completed;
            LostApp.LastStatusDate = DateTime.Now;
            LostApp.PaidFees = clsApplicationTypes.GetFeesApplicationType(clsApplicationTypes.enApplicationType.ReplacementForALostDrivingLicense);
            LostApp.CreatedByUserID = CreatedByUserID;

            if (!LostApp.Save())
                return null;


            clsLicenses ReplacementLicense = new clsLicenses();
            ReplacementLicense.ApplicationID = LostApp.ApplicationID;
            ReplacementLicense.DriverID = this.DriverInfo.DriverID;
            ReplacementLicense.LicenseClass = this.LicenseClass;
            ReplacementLicense.IssueDate = DateTime.Now;
            ReplacementLicense.ExpirationDate = DateTime.Now.AddYears(this.LicenseClassInfo.DefaultValidityLength);
            ReplacementLicense.Notes = (string.IsNullOrEmpty(this.Notes)) ? default : this.Notes;
            ReplacementLicense.PaidFees = this.PaidFees;
            ReplacementLicense.IsActive = true;
            ReplacementLicense.IssueReason = enIssueReason.ReplacementForLost;
            ReplacementLicense.CreatedByUserID = CreatedByUserID;
            if (ReplacementLicense.Save())
            {
                this.DeactivateCurrentLicense();
                return ReplacementLicense;
            }

            return null;
        }


        static public bool IsLicenseExistWithPersonID(int PersonID,clsLicenseClasses.enLicenseClass LicenseClasse)
        {
            return clsDataLicenses.IsLicenseExistWithPersonID(PersonID,(byte)LicenseClasse);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewLicense())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }
                case enMode.Update:
                    {
                        return _UpdateLicense();

                    }
                default:
                    {
                        return false;
                    }
            }

        }


    }



}
