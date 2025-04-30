using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace DVLD_DataAccessLayer
{
    public static class clsDataInternationalLicenses
    {

        static public DataTable GetAllInternationalLicensesWithPersonID(int PersonID)
        {
            DataTable dtInternationalLicensesList = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"SELECT InternationalLicenseID AS ID, InternationalLicenses.ApplicationID AS [App ID], InternationalLicenses.IssuedUsingLocalLicenseID AS [Local License ID]
,FORMAT(InternationalLicenses.IssueDate,'dd/MMM/yyyy') AS [Issue Date],FORMAT(InternationalLicenses.ExpirationDate,'dd/MMM/yyyy') AS [Expiration Date], InternationalLicenses.IsActive AS [Is Active]
FROM InternationalLicenses INNER JOIN Drivers ON InternationalLicenses.DriverID = Drivers.DriverID
WHERE Drivers.PersonID = @PersonID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID",PersonID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dtInternationalLicensesList.Load(Reader);
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


            return dtInternationalLicensesList;
        }

        static public DataTable GetAllInternationalLicensesList()

        {
            DataTable dtInternationalLicensesList = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"SELECT InternationalLicenseID AS [Int.License ID],ApplicationID AS [Application ID],DriverID AS [Driver ID]
,IssuedUsingLocalLicenseID AS [L.License ID], Format(IssueDate,'dd/MMM/yyyy')AS [Issue Date],Format(ExpirationDate,'dd/MMM/yyyy')AS[Expiration Date]
,IsActive AS [Is Active]
FROM InternationalLicenses;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dtInternationalLicensesList.Load(Reader);
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


            return dtInternationalLicensesList;
        }
        static public bool GetInternationalLicenseInfoByID(Int32 InternationalLicenseID, ref Int32 ApplicationID, ref Int32 DriverID, ref Int32 IssuedUsingLocalLicenseID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref Boolean IsActive, ref Int32 CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT * FROM InternationalLicenses WHERE InternationalLicenseID =@InternationalLicenseID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {

                    ApplicationID = (Int32)Reader["ApplicationID"];
                    DriverID = (Int32)Reader["DriverID"];
                    IssuedUsingLocalLicenseID = (Int32)Reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    IsActive = (Boolean)Reader["IsActive"];
                    CreatedByUserID = (Int32)Reader["CreatedByUserID"];


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

        static public int AddNewInternationalLicense(Int32 ApplicationID, Int32 DriverID, Int32 IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, Boolean IsActive, Int32 CreatedByUserID)
        {
            int InternationalLicenseID = -1;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"INSERT INTO InternationalLicenses
                                         (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID)
                                   VALUES
                                         (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);

                                         SELECT Scope_IDentity();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    InternationalLicenseID = ID;
                }
            }
            catch (Exception ex)
            {
                InternationalLicenseID = -1;
            }
            finally
            {
                Connection.Close();
            }


            return InternationalLicenseID;
        }

        static public bool UpdateInternationalLicense(Int32 InternationalLicenseID, Int32 ApplicationID, Int32 DriverID, Int32 IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, Boolean IsActive, Int32 CreatedByUserID)
        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"UPDATE InternationalLicenses 
SET ApplicationID = @ApplicationID
, DriverID = @DriverID
, IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID
, IssueDate = @IssueDate
, ExpirationDate = @ExpirationDate
, IsActive = @IsActive
, CreatedByUserID = @CreatedByUserID
WHERE InternationalLicenseID = @InternationalLicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


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

        static public bool DeleteInternationalLicense(Int32 InternationalLicenseID)
        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "DELETE FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

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

        static public bool IsInternationalLicenseExistbyDriverID(int DriverID)

        {
            bool IsInternationalLicenseExist = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT 1 FROM InternationalLicenses WHERE DriverID = @DriverID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                Connection.Open();
                object Exist = Command.ExecuteScalar();
                if (Exist != null)
                {
                    IsInternationalLicenseExist = true;
                }
            }
            catch (Exception ex)
            {
                IsInternationalLicenseExist = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsInternationalLicenseExist;
        }

        static public bool IsInternationalLicenseExistAndActivebyPersonID(int PersonID)

        {
            bool IsInternationalLicenseExist = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"SELECT 1 FROM InternationalLicenses INNER JOIN Drivers ON InternationalLicenses.DriverID = Drivers.DriverID 
                             WHERE Drivers.PersonID = @PersonID AND InternationalLicenses.IsActive = 1;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                object Exist = Command.ExecuteScalar();
                if (Exist != null)
                {
                    IsInternationalLicenseExist = true;
                }
            }
            catch (Exception ex)
            {
                IsInternationalLicenseExist = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsInternationalLicenseExist;
        }

        static public int GetInternationalLicenseIdByPersonID(int PersonID)


        {
            int InternationalLicenseID = -1;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"SELECT 1 FROM InternationalLicenses INNER JOIN Drivers ON InternationalLicenses.DriverID = Drivers.DriverID 
                             WHERE Drivers.PersonID = @PersonID AND InternationalLicenses.IsActive = 1;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    InternationalLicenseID = ID;
                }
            }
            catch (Exception ex)
            {
                InternationalLicenseID = -1;
            }
            finally
            {
                Connection.Close();
            }

            return InternationalLicenseID;
        }

        static public bool IsInternationalLicenseExist(Int32 InternationalLicenseID)
        {
            bool IsInternationalLicenseExists = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT 1 FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {
                Connection.Open();
                object Exist = Command.ExecuteScalar();
                if (Exist != null)
                {
                    IsInternationalLicenseExists = true;
                }
            }
            catch (Exception ex)
            {
                IsInternationalLicenseExists = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsInternationalLicenseExists;
        }



    }


}
