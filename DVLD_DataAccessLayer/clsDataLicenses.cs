using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DVLD_DataAccessLayer
{
    public static class clsDataLicenses
    {

        static public DataTable GetAllLocalLicensesWithPersonID(int PersonID)
        {
            DataTable dtLicensesList = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"SELECT Licenses.LicenseID AS ID, Licenses.ApplicationID AS [App ID], LicenseClasses.ClassName AS [Class Name],FORMAT(Licenses.IssueDate,'dd/MMM/yyyy')  AS [Issue Date],FORMAT(Licenses.ExpirationDate,'dd/MMM/yyyy') AS [Expiration Date], Licenses.IsActive AS [Is Active]
FROM Licenses INNER JOIN LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
              INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID
WHERE Drivers.PersonID = @PersonID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dtLicensesList.Load(Reader);
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


            return dtLicensesList;
        }

        static public bool GetLicenseInfoByID(Int32 LicenseID, ref Int32 ApplicationID, ref Int32 DriverID, ref Int32 LicenseClass, ref DateTime IssueDate, ref DateTime ExpirationDate, ref String Notes, ref Decimal PaidFees, ref Boolean IsActive, ref Byte IssueReason, ref Int32 CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT * FROM Licenses WHERE LicenseID =@LicenseID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {

                    ApplicationID = (Int32)Reader["ApplicationID"];
                    DriverID = (Int32)Reader["DriverID"];
                    LicenseClass = (Int32)Reader["LicenseClass"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];

                    if (Reader["Notes"] != DBNull.Value)
                        Notes = (String)Reader["Notes"];
                    else
                        Notes = default;

                    PaidFees = (Decimal)Reader["PaidFees"];
                    IsActive = (Boolean)Reader["IsActive"];
                    IssueReason = (Byte)Reader["IssueReason"];
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

        static public int AddNewLicense(Int32 ApplicationID, Int32 DriverID, Int32 LicenseClass, DateTime IssueDate, DateTime ExpirationDate, String Notes, Decimal PaidFees, Boolean IsActive, Byte IssueReason, Int32 CreatedByUserID)
        {
            int LicenseID = -1;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"INSERT INTO Licenses
                                         (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
                                   VALUES
                                         (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);

                                         SELECT Scope_IDentity();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

            if (Notes == default)
                Command.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@Notes", Notes);

            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@IssueReason", IssueReason);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    LicenseID = ID;
                }
            }
            catch (Exception ex)
            {
                LicenseID = -1;
            }
            finally
            {
                Connection.Close();
            }


            return LicenseID;
        }

        static public bool UpdateLicense(Int32 LicenseID, Int32 ApplicationID, Int32 DriverID, Int32 LicenseClass, DateTime IssueDate, DateTime ExpirationDate, String Notes, Decimal PaidFees, Boolean IsActive, Byte IssueReason, Int32 CreatedByUserID)
        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"UPDATE Licenses 
SET ApplicationID = @ApplicationID
, DriverID = @DriverID
, LicenseClass = @LicenseClass
, IssueDate = @IssueDate
, ExpirationDate = @ExpirationDate
, Notes = @Notes
, PaidFees = @PaidFees
, IsActive = @IsActive
, IssueReason = @IssueReason
, CreatedByUserID = @CreatedByUserID
WHERE LicenseID = @LicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

            if (Notes == default)
                Command.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@Notes", Notes);

            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@IssueReason", IssueReason);
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

        static public bool DeleteLicense(Int32 LicenseID)
        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "DELETE FROM Licenses WHERE LicenseID = @LicenseID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

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

        static public bool GetLicenseInfoByLocalDrivingLicenseAppID(int LocalDrivingLicenseApplicationID, ref Int32 LicenseID, ref Int32 ApplicationID, ref Int32 DriverID
            , ref Int32 LicenseClass, ref DateTime IssueDate, ref DateTime ExpirationDate, ref String Notes, ref Decimal PaidFees
            , ref Boolean IsActive, ref Byte IssueReason, ref Int32 CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT * FROM Licenses WHERE 
Licenses.ApplicationID = (SELECT Applications.ApplicationID FROM Applications INNER JOIN LocalDrivingLicenseApplications 
                            ON Applications.ApplicationID= LocalDrivingLicenseApplications.ApplicationID 
							WHERE LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID);";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    LicenseID = (Int32)Reader["LicenseID"];
                    ApplicationID = (Int32)Reader["ApplicationID"];
                    DriverID = (Int32)Reader["DriverID"];
                    LicenseClass = (Int32)Reader["LicenseClass"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];

                    if (Reader["Notes"] != DBNull.Value)
                        Notes = (String)Reader["Notes"];
                    else
                        Notes = default;

                    PaidFees = (Decimal)Reader["PaidFees"];
                    IsActive = (Boolean)Reader["IsActive"];
                    IssueReason = (Byte)Reader["IssueReason"];
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

        static public bool IsLicenseExistWithLicenseID(Int32 LicenseID)
        {
            bool IsLicenseExists = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT 1 FROM Licenses WHERE LicenseID = @LicenseID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                Connection.Open();
                object Exist = Command.ExecuteScalar();
                if (Exist != null)
                {
                    IsLicenseExists = true;
                }
            }
            catch (Exception ex)
            {
                IsLicenseExists = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsLicenseExists;
        }

        static public bool IsLicenseExistWithLocalDrivingLicenseAppID(int LocalDrivingLicenseApplicationID)

        {
            bool IsLicenseExists = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"SELECT IsExist = 1 FROM Licenses INNER JOIN LocalDrivingLicenseApplications 
                                                  ON Licenses.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                             WHERE LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                Connection.Open();
                object Exist = Command.ExecuteScalar();
                if (Exist != null)
                {
                    IsLicenseExists = true;
                }
            }
            catch (Exception ex)
            {
                IsLicenseExists = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsLicenseExists;
        }

        static public bool IsLicenseExistWithPersonID(int PersonID)

        {
            bool IsLicenseExists = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"SELECT 1 FROM Licenses INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID
                            WHERE Drivers.PersonID = @PersonID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                object Exist = Command.ExecuteScalar();
                if (Exist != null)
                {
                    IsLicenseExists = true;
                }
            }
            catch (Exception ex)
            {
                IsLicenseExists = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsLicenseExists;
        }

        static public bool IsLicenseExistWithPersonID(int PersonID, byte LicenseClassID)

        {
            bool IsLicenseExists = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"SELECT 1 FROM Licenses INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID
                            WHERE Drivers.PersonID = @PersonID AND Licenses.LicenseClass = @LicenseClassID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                Connection.Open();
                object Exist = Command.ExecuteScalar();
                if (Exist != null)
                {
                    IsLicenseExists = true;
                }
            }
            catch (Exception ex)
            {
                IsLicenseExists = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsLicenseExists;
        }

        static public bool UpdateLicenseStatus(int LicenseID,bool Status)

        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"UPDATE Licenses 
SET IsActive = @IsActive
WHERE LicenseID = @LicenseID";


            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            Command.Parameters.AddWithValue("@IsActive", Status);



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
