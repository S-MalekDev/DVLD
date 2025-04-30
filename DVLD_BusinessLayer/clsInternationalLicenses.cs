using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsInternationalLicenses
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        public Int32 InternationalLicenseID { get; set; }
        public Int32 ApplicationID { get; set; }
        public Int32 DriverID { get; set; }
        public Int32 IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Boolean IsActive { get; set; }
        public Int32 CreatedByUserID { get; set; }

        private clsApplication _ApplicationInfo;
        private clsDrivers _DriverInfo;
        private clsLocalLicenseApplication _LocalDrivingLicenseAppInfo;
        private clsUser _UserInfoWhoCreatedIt;

        public clsApplication ApplicationInfo { get { return _ApplicationInfo; } }
        public clsDrivers DriverInfo { get { return _DriverInfo; } }
        public clsLocalLicenseApplication LocalDrivingLicenseAppInfo { get { return _LocalDrivingLicenseAppInfo; } }
        public clsUser UserInfoWhoCreatedIt { get { return _UserInfoWhoCreatedIt; } }
        public clsInternationalLicenses()
        {
            InternationalLicenseID = default;
            ApplicationID = default;
            DriverID = default;
            IssuedUsingLocalLicenseID = default;
            IssueDate = default;
            ExpirationDate = default;
            IsActive = default;
            CreatedByUserID = default;

            _ApplicationInfo =null;
            _DriverInfo = null;
            _LocalDrivingLicenseAppInfo = null;
            _UserInfoWhoCreatedIt = null;

            _Mode = enMode.AddNew;
        }
        private clsInternationalLicenses(Int32 InternationalLicenseID, Int32 ApplicationID, Int32 DriverID, Int32 IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, Boolean IsActive, Int32 CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;

            _ApplicationInfo = clsApplication.Find(ApplicationID);
            _DriverInfo = clsDrivers.Find(DriverID);
            _LocalDrivingLicenseAppInfo = clsLocalLicenseApplication.Find(IssuedUsingLocalLicenseID);
            _UserInfoWhoCreatedIt = clsUser.FindByUserID(CreatedByUserID);

            _Mode = enMode.Update;
        }
        static public DataTable GetAllInternationalLicensesWithPersonID(int PersonID)
        {
            return clsDataInternationalLicenses.GetAllInternationalLicensesWithPersonID( PersonID);
        }

        static public clsInternationalLicenses Find(Int32 InternationalLicenseID)
        {

            Int32 ApplicationID = default;
            Int32 DriverID = default;
            Int32 IssuedUsingLocalLicenseID = default;
            DateTime IssueDate = default;
            DateTime ExpirationDate = default;
            Boolean IsActive = default;
            Int32 CreatedByUserID = default;


            if (clsDataInternationalLicenses.GetInternationalLicenseInfoByID(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new clsInternationalLicenses(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            }
            else
            {
                return null;
            }

        }

        private bool _AddNewInternationalLicense()
        {
            this.InternationalLicenseID = clsDataInternationalLicenses.AddNewInternationalLicense(this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

            return InternationalLicenseID != -1;
        }

        private bool _UpdateInternationalLicense()
        {
            return clsDataInternationalLicenses.UpdateInternationalLicense(this.InternationalLicenseID, this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
        }

        static public DataTable GetAllInternationalLicensesList()
        {
            return clsDataInternationalLicenses.GetAllInternationalLicensesList();
        }
        static public bool DeleteInternationalLicense(Int32 InternationalLicenseID)
        {
            return clsDataInternationalLicenses.DeleteInternationalLicense(InternationalLicenseID);
        }

        static public bool IsInternationalLicenseExist(Int32 InternationalLicenseID)
        {
            return clsDataInternationalLicenses.IsInternationalLicenseExist(InternationalLicenseID);
        }

        static public bool IsInternationalLicenseExistbyDriverID(int LicenseID)
        {
            return clsDataInternationalLicenses.IsInternationalLicenseExistbyDriverID(LicenseID);
        }

        static public bool IsInternationalLicenseExistAndActivebyPersonID(int PersonID)
        {
            return clsDataInternationalLicenses.IsInternationalLicenseExistAndActivebyPersonID(PersonID);
        }

        static public int GetInternationalLicenseIdByPersonID(int PersonID)
        {
            return clsDataInternationalLicenses.GetInternationalLicenseIdByPersonID(PersonID);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewInternationalLicense())
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
                        return _UpdateInternationalLicense();

                    }
                default:
                    {
                        return false;
                    }
            }

        }


    }



}
