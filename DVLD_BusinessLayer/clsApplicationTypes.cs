using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DVLD_BusinessLayer
{
    public class clsApplicationTypes
    {
        public enum enApplicationType
        {
            NewLocalDrivingLicenseService = 1, RenewDrivingLicenseService = 2, ReplacementForALostDrivingLicense = 3
                , ReplacementForADamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6
                , RetakeTest = 7
        }
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Fees { get; set; }

        public clsApplicationTypes()
        {
            ID = -1;
            Title = string.Empty;
            Fees = 0;
        }
        private clsApplicationTypes(int ID, string Title, decimal Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Fees = Fees;
        }

        static public DataTable GetAllApplicationTypes()
        {
            return clsDataApplicationTypes.GetAllApplicationTypes();
        }

        static public decimal GetFeesApplicationType(enApplicationType type)
        {
            return clsDataApplicationTypes.GetFeesApplicationType((byte) type);
        }
        private bool _UpdateApplicationType()
        {
            return clsDataApplicationTypes.UpdateApplicationType(this.ID, this.Title, this.Fees);
        }

        static public clsApplicationTypes Find(int ID)
        {

            string Title = string.Empty;
            decimal Fees = 0;
            if (clsDataApplicationTypes.GetApplicationTypeInfoByID(ID, ref Title, ref Fees))
            {
                return new clsApplicationTypes(ID, Title, Fees);
            }
            else
                return null;
        }
        static public clsApplicationTypes Find(string Title)
        {

            int ID = -1;
            decimal Fees = 0;
            if (clsDataApplicationTypes.GetApplicationTypeInfoByTitle(ref ID,  Title, ref Fees))
            {
                return new clsApplicationTypes(ID, Title, Fees);
            }
            else
                return null;
        }

        public bool Save()
        {
            if(_UpdateApplicationType())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
