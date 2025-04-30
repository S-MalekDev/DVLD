using DVLD_DataAccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsPeople
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;

        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public short NationalityCountryID { get; set; }
        public string ImagePath { get; set; }
        public string FullName
        {
            get
            {
                if (string.IsNullOrEmpty(ThirdName))
                    return FirstName + " " + SecondName + " " + LastName;
                else 
                    return FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
            }
        }

        public clsCountries CountryInfo;

        public clsPeople()
        {
            this.PersonID = -1;
            this.NationalNo = string.Empty;
            this.FirstName = string.Empty;
            this.SecondName = string.Empty;
            this.ThirdName = string.Empty;
            this.LastName = string.Empty;
            this.DateOfBirth = DateTime.Now;
            this.Gendor = 0;
            this.Address = string.Empty;
            this.Phone = string.Empty;
            this.Email = string.Empty;
            this.NationalityCountryID = -1;
            this.ImagePath = string.Empty;
            _Mode = enMode.AddNew;
        }

        private clsPeople(int personID, string nationalNo, string firstName, string secondName, string thirdName, string lastName
            , DateTime dateOfBirth, byte gendor, string address, string phone, string email, short nationalityCountryID, string imagePath)
        {
            this.PersonID = personID;
            this.NationalNo = nationalNo;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gendor = gendor;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.NationalityCountryID = nationalityCountryID;
            this.ImagePath = imagePath;
            this.CountryInfo = clsCountries.Find(nationalityCountryID);
            _Mode = enMode.Update;
        }


        private bool _AddNewPerson()
        {
            this.PersonID = clsDataPeople.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName
                , this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);

            return PersonID != -1;
        }
        private bool _UpdatePerson()
        {
            return clsDataPeople.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName
                , this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }

        static public bool DeletePerson(int PersonID)
        {
            return clsDataPeople.DeletePerson(PersonID);
        }

        static public DataTable GetAllPeople()
        {
            return clsDataPeople.GetAllPeople();
        }

        static public bool IsExist(string NationalNo)
        {
            return clsDataPeople.IsPersonExist(NationalNo);
        }

        static public bool IsExist(int PersonID)
        {
            return clsDataPeople.IsPersonExist(PersonID);
        }

        static public clsPeople Find(int PersonID)
        {
            string NationalNo = string.Empty;
            string FirstName = string.Empty;
            string SecondName = string.Empty;
            string ThirdName = string.Empty;
            string LastName = string.Empty;
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            string Address = string.Empty;
            string Phone = string.Empty;
            string Email = string.Empty;
            short NationalityCountryID = -1;
            string ImagePath = string.Empty;

            if (clsDataPeople.GetPersonInfoByID(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName
            , ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPeople(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName
            , DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }

        }

        static public clsPeople Find(string NationalNo)
        {
            int PersonID = -1;
            string FirstName = string.Empty;
            string SecondName = string.Empty;
            string ThirdName = string.Empty;
            string LastName = string.Empty;
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            string Address = string.Empty;
            string Phone = string.Empty;
            string Email = string.Empty;
            short NationalityCountryID = -1;
            string ImagePath = string.Empty;

            if (clsDataPeople.GetPersonInfoByNationalNo(ref PersonID,  NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName
            , ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPeople(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName
            , DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }

        }


        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewPerson())
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
                        return _UpdatePerson();
                       
                    }
                default:
                    {
                        return false;
                    }
            }

        }
    }
}
