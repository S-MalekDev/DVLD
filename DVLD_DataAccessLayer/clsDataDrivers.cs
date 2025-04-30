using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public static class clsDataDrivers
    {

        static public DataTable GetAllDrivers()
        {
            DataTable dtDriversList = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"SELECT Drivers.DriverID AS [Driver ID],Drivers.PersonID AS [Person ID],People.NationalNo AS [National No], 
CASE WHEN People.ThirdName IS NULL THEN People.FirstName + ' ' + People.SecondName + ' ' + People.LastName 
ELSE People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName 
END
AS [Full Name]
,FORMAT(Drivers.CreatedDate,'dd/MMM/yyyy') AS Date
, (SELECT COUNT(LicenseID) FROM Licenses WHERE Licenses.DriverID = Drivers.DriverID AND Licenses.IsActive = 1 ) AS [Active Licenses]
FROM Drivers INNER JOIN People ON Drivers.PersonID = People.PersonID;";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dtDriversList.Load(Reader);
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


            return dtDriversList;
        }

        static public bool GetDriverInfoByID(Int32 DriverID, ref Int32 PersonID, ref Int32 CreatedByUserID, ref DateTime CreatedDate)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT * FROM Drivers WHERE DriverID =@DriverID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {

                    PersonID = (Int32)Reader["PersonID"];
                    CreatedByUserID = (Int32)Reader["CreatedByUserID"];
                    CreatedDate = (DateTime)Reader["CreatedDate"];


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

        static public int AddNewDriver(Int32 PersonID, Int32 CreatedByUserID)
        {
            int DriverID = -1;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"INSERT INTO Drivers
                                         (PersonID, CreatedByUserID, CreatedDate)
                                   VALUES
                                         (@PersonID, @CreatedByUserID, @CreatedDate);

                                         SELECT Scope_IDentity();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@CreatedDate", DateTime.Now);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    DriverID = ID;
                }
            }
            catch (Exception ex)
            {
                DriverID = -1;
            }
            finally
            {
                Connection.Close();
            }


            return DriverID;
        }

        static public bool UpdateDriver(Int32 DriverID, Int32 PersonID, Int32 CreatedByUserID, DateTime CreatedDate)
        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"UPDATE Drivers 
SET PersonID = @PersonID
, CreatedByUserID = @CreatedByUserID
, CreatedDate = @CreatedDate
WHERE DriverID = @DriverID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@CreatedDate", CreatedDate);


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

        static public bool DeleteDriver(Int32 DriverID)
        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "DELETE FROM Drivers WHERE DriverID = @DriverID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);

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

        static public bool IsDriverExist(Int32 DriverID)
        {
            bool IsDriverExists = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT 1 FROM Drivers WHERE DriverID = @DriverID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                Connection.Open();
                object Exist = Command.ExecuteScalar();
                if (Exist != null)
                {
                    IsDriverExists = true;
                }
            }
            catch (Exception ex)
            {
                IsDriverExists = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsDriverExists;
        }

        static public bool IsDriverExistWithPersonID(int PersonID , ref int DriverID)

        {
            DriverID = -1;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = " SELECT DriverID FROM Drivers WHERE PersonID = @PersonID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(),out int ID))
                {
                    DriverID = ID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }

            return DriverID != -1;
        }
    }


}
