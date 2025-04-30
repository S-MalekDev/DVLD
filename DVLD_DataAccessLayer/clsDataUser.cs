using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public static class clsDataUser
    {
        static public DataTable GetAllUsers()
        {
            DataTable dtUsersList = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT * FROM UsersList;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dtUsersList.Load(Reader);
                }

                Reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }


            return dtUsersList;
        }

        static public bool GetUserInfoByUserID(int UserID,ref int PersonID,ref string UserName,ref string Password,ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT * FROM Users WHERE UserID =@UserID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {

                    PersonID = (int)Reader["PersonID"];
                    UserName = (string)Reader["UserName"];
                    Password = (string)Reader["Password"];
                    IsActive = (bool)Reader["IsActive"];
                  
                    IsFound = true;
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }


            return IsFound;
        }

        static public bool GetUserInfoByPersonID(ref int UserID,  int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT * FROM Users WHERE PersonID =@PersonID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {

                    UserID = (int)Reader["UserID"];
                    UserName = (string)Reader["UserName"];
                    Password = (string)Reader["NewPassword"];
                    IsActive = (bool)Reader["IsActive"];

                    IsFound = true;
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }


            return IsFound;
        }

        static public bool GetUserInfoByUsernameAndPassword(ref int UserID, ref int PersonID,  string UserName,  string Password, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT * FROM Users WHERE UserName =@UserName And Password =@NewPassword;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@NewPassword", Password);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {

                    UserID = (int)Reader["UserID"];
                    PersonID = (int)Reader["PersonID"];
                    IsActive = (bool)Reader["IsActive"];

                    IsFound = true;
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }


            return IsFound;
        }

        static public int AddNewUser( int PersonID,  string UserName,  string Password,  bool IsActive)

        {
            int UserID = -1;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"INSERT INTO Users (PersonID,UserName,Password,IsActive)
                                  VALUES
                                               (@PersonID,@UserName,@Password,@IsActive);

                                                SELECT Scope_IDentity();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    UserID = ID;
                }
            }
            catch (Exception ex)
            {
                UserID = -1;
            }
            finally
            {
                Connection.Close();
            }


            return UserID;
        }
      
        static public bool UpdateUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)


        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"UPDATE Users
                            SET PersonID = @PersonID
                               ,UserName = @UserName
                               ,Password = @Password
                               ,IsActive = @IsActive
                          WHERE UserID = @UserID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", IsActive);


            try
            {
                Connection.Open();
                RowsEfacts = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }


            return RowsEfacts > 0;
        }

        static public bool DeleteUser(int UserID)

        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "DELETE FROM Users WHERE UserID = @UserID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();
                RowsEfacts = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }

            return RowsEfacts > 0;
        }

        static public bool IsUserExist(int UserID)
        {
            bool IsUserIDExists = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT 1 FROM Users WHERE UserName = @UserName;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserID);

            try
            {
                Connection.Open();
                object Exist = Command.ExecuteScalar();
                if (Exist != null)
                {
                    IsUserIDExists = true;
                }
            }
            catch (Exception ex)
            {
                IsUserIDExists = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsUserIDExists;
        }
        
        static public bool IsUserExist(string UserName)
        {
            bool IsUserIDExists = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT 1 FROM Users WHERE UserName = @UserName;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                Connection.Open();
                object Exist = Command.ExecuteScalar();
                if (Exist != null)
                {
                    IsUserIDExists = true;
                }
            }
            catch (Exception ex)
            {
                IsUserIDExists = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsUserIDExists;
        }

        static public bool IsUserExistForPersonID(int PersonID)

        {
            bool IsPersonIDExists = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT 1 FROM Users WHERE PersonID = @PersonID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                object Exist = Command.ExecuteScalar();
                if (Exist != null)
                {
                    IsPersonIDExists = true;
                }
            }
            catch (Exception ex)
            {
                IsPersonIDExists = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsPersonIDExists;
        }

        static public bool ChangePassword(int UserID, string NewPassword)



        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"UPDATE Users
                            SET Password = @NewPassword
                          WHERE UserID = @UserID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@NewPassword", NewPassword);


            try
            {
                Connection.Open();
                RowsEfacts = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }


            return RowsEfacts > 0;
        }
    }
}
