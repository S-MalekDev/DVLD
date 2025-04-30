using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsCountries
    {
        public short CountryID { get; set; }
        public string CountryName { get; set; }

        public clsCountries()
        {
            this.CountryID = -1;
            this.CountryName = string.Empty;
        }
        private clsCountries(short CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

        static public DataTable GetAllCountries()
        {
            return clsDataCountries.GetAllCountries();
        }

        static public clsCountries Find(short CountryID)
        {
            string CountryName = string.Empty ;

            if(clsDataCountries.GetCountryInfoByID(CountryID,ref CountryName))
            {
                return new clsCountries(CountryID, CountryName);
            }
            else
            {
                return null;
            }
        }

        static public clsCountries Find(string CountryName)
        {
            short CountryID = 0;
            if (clsDataCountries.GetCountryInfoByName(ref CountryID, CountryName))
            {
                return new clsCountries(CountryID, CountryName);
            }
            else
            {
                return null;
            }
        }


    }
}
