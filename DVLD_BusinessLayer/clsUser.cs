using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsUser
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsPeople PersonInfo;

        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.IsActive = false;
            this.PersonInfo = new clsPeople(); 

            _Mode = enMode.AddNew;
        }

        private clsUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            this.PersonInfo = clsPeople.Find(PersonID);

            _Mode = enMode.Update;
        }


        private bool _AddNewUser()
        {
            this.UserID = clsDataUser.AddNewUser( this.PersonID, this.UserName, this.Password, this.IsActive);

            return UserID != -1;
        }

        private bool _UpdateUser()
        {
            return clsDataUser.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive);
        }

        static public bool DeleteUser(int UserID)
        {
            return clsDataUser.DeleteUser(UserID);
        }

        static public DataTable GetAllUsers()
        {
            return clsDataUser.GetAllUsers();
        }

        static public bool IsExist(string UserName)
        {
            return clsDataUser.IsUserExist(UserName);
        }

        static public bool IsExist(int UserID)
        {
            return clsDataUser.IsUserExist(UserID);
        }

        static public bool IsExistForPersonID(int PersonID)

        {
            return clsDataUser.IsUserExistForPersonID(PersonID);
        }

        static public clsUser FindByUserID(int UserID)
        {
            int PersonID = -1;
            string UserName= string.Empty;
            string Password=string.Empty;
            bool IsActive = false;

            if (clsDataUser.GetUserInfoByUserID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserID,  PersonID,  UserName,  Password,  IsActive);
            }
            else
            {
                return null;
            }

        }

        static public clsUser FindByPersonID(int PersonID)
        {
            int UserID = -1;
            string UserName = string.Empty;
            string Password = string.Empty;
            bool IsActive = false;

            if (clsDataUser.GetUserInfoByPersonID(ref UserID,  PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }

        }

        static public clsUser FindByUsernameAndPassword(string UserName,string Password)
        {
            int PersonID = -1;
            int UserID = -1;
            bool IsActive = false;

            if (clsDataUser.GetUserInfoByUsernameAndPassword(ref UserID, ref PersonID,  UserName,  Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }

        }

        static public bool ChangePassword(int  UserID, string NewPassword)
        {
            return clsDataUser.ChangePassword(UserID, NewPassword);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewUser())
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
                        return _UpdateUser();

                    }
                default:
                    {
                        return false;
                    }
            }

        }
    }
}
