using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public static class clsDataTestAppointments
    {

        static public DataTable GetAllTestAppointments()
        {
            DataTable dtTestAppointmentsList = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT * FROM TestAppointments;";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dtTestAppointmentsList.Load(Reader);
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


            return dtTestAppointmentsList;
        }

        static public DataTable GetAllAppointmentsBy_LDL_AppID_TestType( int LocalDrivingLicenseApplicationID, byte TestTypeID)
        {
            DataTable dtTestAppointmentsList = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"SELECT TestAppointmentID AS [Appointment ID],AppointmentDate AS [Appointment Date], PaidFees AS [Paid Fees], IsLocked AS [Is Locked] FROM TestAppointments 
WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID;";
            

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dtTestAppointmentsList.Load(Reader);
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


            return dtTestAppointmentsList;
        }

        static public bool GetTestAppointmentInfoByID(Int32 TestAppointmentID, ref Int32 TestTypeID, ref Int32 LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate, ref Decimal PaidFees, ref Int32 CreatedByUserID, ref Boolean IsLocked, ref Int32 RetakeTestApplicationID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT * FROM TestAppointments WHERE TestAppointmentID =@TestAppointmentID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {

                    TestTypeID = (Int32)Reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (Int32)Reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)Reader["AppointmentDate"];
                    PaidFees = (Decimal)Reader["PaidFees"];
                    CreatedByUserID = (Int32)Reader["CreatedByUserID"];
                    IsLocked = (Boolean)Reader["IsLocked"];

                    if (Reader["RetakeTestApplicationID"] != DBNull.Value)
                        RetakeTestApplicationID = (Int32)Reader["RetakeTestApplicationID"];
                    else
                        RetakeTestApplicationID = default;



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

        static public int AddNewTestAppointment(Int32 TestTypeID, Int32 LocalDrivingLicenseApplicationID, DateTime AppointmentDate, Decimal PaidFees, Int32 CreatedByUserID, Boolean IsLocked, Int32 RetakeTestApplicationID)
        {
            int TestAppointmentID = -1;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"INSERT INTO TestAppointments
                                         (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID)
                                   VALUES
                                         (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked, @RetakeTestApplicationID);

                                         SELECT Scope_IDentity();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsLocked", IsLocked);

            if (RetakeTestApplicationID == default)
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);



            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    TestAppointmentID = ID;
                }
            }
            catch (Exception ex)
            {
                TestAppointmentID = -1;
            }
            finally
            {
                Connection.Close();
            }


            return TestAppointmentID;
        }

        static public bool UpdateTestAppointment(Int32 TestAppointmentID, Int32 TestTypeID, Int32 LocalDrivingLicenseApplicationID, DateTime AppointmentDate, Decimal PaidFees, Int32 CreatedByUserID, Boolean IsLocked, Int32 RetakeTestApplicationID)
        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"UPDATE TestAppointments 
SET TestTypeID = @TestTypeID
, LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
, AppointmentDate = @AppointmentDate
, PaidFees = @PaidFees
, CreatedByUserID = @CreatedByUserID
, IsLocked = @IsLocked
, RetakeTestApplicationID = @RetakeTestApplicationID
WHERE TestAppointmentID = @TestAppointmentID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsLocked", IsLocked);

            if (RetakeTestApplicationID == default)
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);



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

        static public bool DeleteTestAppointment(Int32 TestAppointmentID)
        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "DELETE FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

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

        static public bool IsTestAppointmentExist(Int32 TestAppointmentID)
        {
            bool IsTestAppointmentExists = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT 1 FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                Connection.Open();
                object Exist = Command.ExecuteScalar();
                if (Exist != null)
                {
                    IsTestAppointmentExists = true;
                }
            }
            catch (Exception ex)
            {
                IsTestAppointmentExists = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsTestAppointmentExists;
        }

        static public bool IsHaveAnAppointmentActiveOfTestType(int LocalDrivingLicenseApplicationID, byte TestTypeID)
        {
            bool IsHaveActiveAppointment = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT HasAppointmentActive = 1 FROM TestAppointments WHERE " +
                "LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID AND IsLocked = 0;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    IsHaveActiveAppointment = true;
                }
            }
            catch (Exception ex)
            {
                IsHaveActiveAppointment = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsHaveActiveAppointment;
        }

        static public bool IsThereALockedAppointment(int LocalDrivingLicenseApplicationID, byte TestTypeID)

        {
            bool IsHaveActiveAppointment = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT HasAppointmentActive = 1 FROM TestAppointments WHERE " +
                "LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID AND IsLocked = 1;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    IsHaveActiveAppointment = true;
                }
            }
            catch (Exception ex)
            {
                IsHaveActiveAppointment = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsHaveActiveAppointment;
        }

        static public bool DidHePassTheTest(int LocalDrivingLicenseApplicationID, byte TestTypeID)

        {
            bool DidHePass = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = @"SELECT [He Pass The Test] = 1 FROM TestAppointments INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
WHERE TestAppointments.LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID AND TestAppointments.TestTypeID = @TestTypeID AND Tests.TestResult = 1;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    DidHePass = true;
                }
            }
            catch (Exception ex)
            {
                DidHePass = false;
            }
            finally
            {
                Connection.Close();
            }

            return DidHePass;
        }

        static public bool GetTheLastTestAppointmentsByLocalDrivingLicenseAppID(ref Int32 TestAppointmentID,ref byte TestTypeID,  Int32 LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate, ref Decimal PaidFees, ref Int32 CreatedByUserID, ref Boolean IsLocked, ref Int32 RetakeTestApplicationID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT TOP 1 * FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID  ORDER BY TestAppointmentID Desc;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    TestAppointmentID = (int)Reader["TestAppointmentID"];
                    TestTypeID = (byte)(int)Reader["TestTypeID"];
                    AppointmentDate = (DateTime)Reader["AppointmentDate"];
                    PaidFees = (Decimal)Reader["PaidFees"];
                    CreatedByUserID = (Int32)Reader["CreatedByUserID"];
                    IsLocked = (Boolean)Reader["IsLocked"];

                    if (Reader["RetakeTestApplicationID"] != DBNull.Value)
                        RetakeTestApplicationID = (Int32)Reader["RetakeTestApplicationID"];
                    else
                        RetakeTestApplicationID = default;

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
        static public bool Locked(int TestAppointmentID)

        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"UPDATE TestAppointments 
                           SET IsLocked = 1

                      WHERE TestAppointmentID = @TestAppointmentID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);



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
