using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsLicenseClasses
    {
        
        public enum enLicenseClass
        {
            SmallMotorcycle = 1, HeavyMotorcycleLicense = 2, OrdinaryDrivingLicense = 3, Commercial = 4
                , Agricultural = 5, SmallAndMediumBus = 6, TruckAndHeavyVehicle = 7
        }
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        public Int32 LicenseClassID { get; set; }
        public String ClassName { get; set; }
        public String ClassDescription { get; set; }
        public Byte MinimumAllowedAge { get; set; }
        public Byte DefaultValidityLength { get; set; }
        public Decimal ClassFees { get; set; }


        public clsLicenseClasses()
        {
            LicenseClassID = default;
            ClassName = default;
            ClassDescription = default;
            MinimumAllowedAge = default;
            DefaultValidityLength = default;
            ClassFees = default;

            _Mode = enMode.AddNew;
        }
        private clsLicenseClasses(Int32 LicenseClassID, String ClassName, String ClassDescription, Byte MinimumAllowedAge, Byte DefaultValidityLength, Decimal ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;

            _Mode = enMode.Update;
        }

        static public DataTable GetAllLicenseClasses()
        {
            return clsDataLicenseClasses.GetAllLicenseClasses();
        }

        static public clsLicenseClasses Find(Int32 LicenseClassID)
        {

            String ClassName = default;
            String ClassDescription = default;
            Byte MinimumAllowedAge = default;
            Byte DefaultValidityLength = default;
            Decimal ClassFees = default;


            if (clsDataLicenseClasses.GetLicenseClassInfoByID(LicenseClassID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClasses(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
            {
                return null;
            }

        }

        private bool _AddNewLicenseClass()
        {
            this.LicenseClassID = clsDataLicenseClasses.AddNewLicenseClass(this.ClassName, this.ClassDescription, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);

            return LicenseClassID != -1;
        }

        private bool _UpdateLicenseClass()
        {
            return clsDataLicenseClasses.UpdateLicenseClass(this.LicenseClassID, this.ClassName, this.ClassDescription, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);
        }

        static public bool DeleteLicenseClass(Int32 LicenseClassID)
        {
            return clsDataLicenseClasses.DeleteLicenseClass(LicenseClassID);
        }

        static public bool IsLicenseClassExist(Int32 LicenseClassID)
        {
            return clsDataLicenseClasses.IsLicenseClassExist(LicenseClassID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewLicenseClass())
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
                        return _UpdateLicenseClass();

                    }
                default:
                    {
                        return false;
                    }
            }

        }


    }


}
