using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsDrivers
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        public Int32 DriverID { get; set; }
        public Int32 PersonID { get; set; }
        public Int32 CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        private clsPeople _PersonInfo;
        private clsUser _UserInfoWhoCreatedit;

        public clsPeople PersonInfo { get {  return _PersonInfo; } }
        public clsUser UserInfoWhoCreatedit { get {  return _UserInfoWhoCreatedit; } }


        public clsDrivers()
        {
            DriverID = default;
            PersonID = default;
            CreatedByUserID = default;
            CreatedDate = default;

            _PersonInfo = null;
            _UserInfoWhoCreatedit = null;

            _Mode = enMode.AddNew;
        }
        private clsDrivers(Int32 DriverID, Int32 PersonID, Int32 CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;

            _PersonInfo = clsPeople.Find(PersonID);
            _UserInfoWhoCreatedit = clsUser.FindByUserID(CreatedByUserID);

            _Mode = enMode.Update;
        }
        static public DataTable GetAllDrivers()
        {
            return clsDataDrivers.GetAllDrivers();
        }

        static public clsDrivers Find(Int32 DriverID)
        {

            Int32 PersonID = default;
            Int32 CreatedByUserID = default;
            DateTime CreatedDate = default;


            if (clsDataDrivers.GetDriverInfoByID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDrivers(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            else
            {
                return null;
            }

        }

        private bool _AddNewDriver()
        {
            this.DriverID = clsDataDrivers.AddNewDriver(this.PersonID, this.CreatedByUserID);

            return DriverID != -1;
        }

        private bool _UpdateDriver()
        {
            return clsDataDrivers.UpdateDriver(this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);
        }

        static public bool DeleteDriver(Int32 DriverID)
        {
            return clsDataDrivers.DeleteDriver(DriverID);
        }

        static public bool IsDriverExist(Int32 DriverID)
        {
            return clsDataDrivers.IsDriverExist(DriverID);
        }
        static public bool IsDriverExistWithPersonID(int PersonID, ref int  DriverID)
        {
            return clsDataDrivers.IsDriverExistWithPersonID(PersonID, ref DriverID);
        }

        public DataTable GetInternationalLicense()
        {
            return clsDataInternationalLicenses.GetAllInternationalLicensesWithPersonID(this.PersonID);
        }
        public DataTable GetAllLicesnes()
        {
            return clsDataLicenses.GetAllLocalLicensesWithPersonID(this.PersonID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewDriver())
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
                        return _UpdateDriver();

                    }
                default:
                    {
                        return false;
                    }
            }

        }


    }



}
