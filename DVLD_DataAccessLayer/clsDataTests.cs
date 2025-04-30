using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public static class clsDataTests
    {

        static public DataTable GetAllTests()
        {
            DataTable dtTestsList = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT * FROM Tests;";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dtTestsList.Load(Reader);
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


            return dtTestsList;
        }

        static public bool GetTestInfoByID(Int32 TestID, ref Int32 TestAppointmentID, ref Boolean TestResult, ref String Notes, ref Int32 CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT * FROM Tests WHERE TestID =@TestID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestID", TestID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {

                    TestAppointmentID = (Int32)Reader["TestAppointmentID"];
                    TestResult = (Boolean)Reader["TestResult"];

                    if (Reader["Notes"] != DBNull.Value)
                        Notes = (String)Reader["Notes"];
                    else
                        Notes = default;

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

        static public int AddNewTest(Int32 TestAppointmentID, Boolean TestResult, String Notes, Int32 CreatedByUserID)
        {
            int TestID = -1;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"INSERT INTO Tests
                                         (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                                   VALUES
                                         (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);

                                         SELECT Scope_IDentity();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@TestResult", TestResult);

            if (Notes == default)
                Command.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@Notes", Notes);

            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    TestID = ID;
                }
            }
            catch (Exception ex)
            {
                TestID = -1;
            }
            finally
            {
                Connection.Close();
            }


            return TestID;
        }

        static public bool UpdateTest(Int32 TestID, Int32 TestAppointmentID, Boolean TestResult, String Notes, Int32 CreatedByUserID)
        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"UPDATE Tests 
SET TestAppointmentID = @TestAppointmentID
, TestResult = @TestResult
, Notes = @Notes
, CreatedByUserID = @CreatedByUserID
WHERE TestID = @TestID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestID", TestID);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@TestResult", TestResult);

            if (Notes == default)
                Command.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@Notes", Notes);

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

        static public bool DeleteTest(Int32 TestID)
        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "DELETE FROM Tests WHERE TestID = @TestID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestID", TestID);

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

        static public bool IsTestExist(Int32 TestID)
        {
            bool IsTestExists = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT 1 FROM Tests WHERE TestID = @TestID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                Connection.Open();
                object Exist = Command.ExecuteScalar();
                if (Exist != null)
                {
                    IsTestExists = true;
                }
            }
            catch (Exception ex)
            {
                IsTestExists = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsTestExists;
        }

        static public int GetNumberTestsPassedWithLocalDrivingLicenseAppID(int LocalDrivingLicenseApplicationID)

        {
            int NumberTestPassed = -1;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"Select Count(Tests.TestID) From Tests INNER JOIN TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                                      INNER JOIN LocalDrivingLicenseApplications ON TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
WHERE LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND Tests.TestResult = 1;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    NumberTestPassed = ID;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }


            return NumberTestPassed;
        }

    }


}
