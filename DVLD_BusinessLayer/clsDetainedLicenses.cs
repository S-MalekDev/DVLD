using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsDetainedLicenses
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;

        private Int32 _DetainID;

        public Int32 DetainID { get { return _DetainID; } }
        public Int32 LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public Decimal FineFees { get; set; }
        public Int32 CreatedByUserID { get; set; }
        public Boolean IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Int32 ReleasedByUserID { get; set; }
        public Int32 ReleaseApplicationID { get; set; }


        public clsDetainedLicenses()
        {
            _DetainID = -1;
            LicenseID = -1;
            DetainDate = DateTime.Now;
            FineFees = -1;
            CreatedByUserID = -1;
            IsReleased = false;
            ReleaseDate = default;
            ReleasedByUserID = default;
            ReleaseApplicationID = default;

            _Mode = enMode.AddNew;
        }
        private clsDetainedLicenses(Int32 DetainID, Int32 LicenseID, DateTime DetainDate, Decimal FineFees, Int32 CreatedByUserID, Boolean IsReleased, DateTime ReleaseDate, Int32 ReleasedByUserID, Int32 ReleaseApplicationID)
        {
            _DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;

            _Mode = enMode.Update;
        }
        static public DataTable GetAllDetainedLicenses()
        {
            return clsDataDetainedLicenses.GetAllDetainedLicenses();
        }

        static public clsDetainedLicenses Find(Int32 DetainID)
        {

            Int32 LicenseID = -1;
            DateTime DetainDate = DateTime.Now;
            Decimal FineFees = -1;
            Int32 CreatedByUserID = -1;
            Boolean IsReleased = false;
            DateTime ReleaseDate = default;
            Int32 ReleasedByUserID = default;
            Int32 ReleaseApplicationID = default;


            if (clsDataDetainedLicenses.GetDetainedLicenseInfoByID(DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainedLicenses(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }
            else
            {
                return null;
            }

        }

        static public clsDetainedLicenses FindByLicenseID(int LicenseID)
        {
            int DetainID = -1;
            DateTime DetainDate = DateTime.Now;
            Decimal FineFees = -1;
            Int32 CreatedByUserID = -1;
            Boolean IsReleased = false;
            DateTime ReleaseDate = default;
            Int32 ReleasedByUserID = default;
            Int32 ReleaseApplicationID = default;


            if (clsDataDetainedLicenses.GetDetainedLicenseInfoByLicenseID(ref DetainID, LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainedLicenses(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewDetainedLicense()
        {
            _DetainID = clsDataDetainedLicenses.AddNewDetainedLicense(this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);

            return _DetainID != -1;
        }

        private bool _UpdateDetainedLicense()
        {
            return clsDataDetainedLicenses.UpdateDetainedLicense(this.DetainID, this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
        }


        static public bool DeleteDetainedLicense(Int32 DetainID)
        {
            return clsDataDetainedLicenses.DeleteDetainedLicense(DetainID);
        }

        static public bool IsDetainedLicenseExist(Int32 DetainID)
        {
            return clsDataDetainedLicenses.IsDetainedLicenseExist(DetainID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewDetainedLicense())
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
                        return _UpdateDetainedLicense();

                    }
                default:
                    {
                        return false;
                    }
            }

        }


    }



}
