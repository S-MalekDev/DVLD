using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    static public class clsDataLocalLicenseApplication
    {
        static public DataTable GetAllLocalDrivingLicenseApplication()
        {
            DataTable dtLocalDrivingLicenseApplicationList = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT * FROM MYLocalDrivingLicenseApplicationView;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dtLocalDrivingLicenseApplicationList.Load(Reader);
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


            return dtLocalDrivingLicenseApplicationList;
        }

        static public int AddNewLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID)
        {
            int LocalDrivingLicenseApplicationID = -1;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"INSERT INTO LocalDrivingLicenseApplications
                                   (ApplicationID,LicenseClassID)
                             VALUES
                                   (@ApplicationID,@LicenseClassID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    LocalDrivingLicenseApplicationID = ID;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }


            return LocalDrivingLicenseApplicationID;
        }

        static public bool UpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID,int ApplicationID, int LicenseClassID)



        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"UPDATE LocalDrivingLicenseApplications
                             SET 
                                 ApplicationID = @ApplicationID
                                ,LicenseClassID = @LicenseClassID
                           WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID; ";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


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

        static public bool DeleteLocalDrivingLicenseApplication(Int32 LocalDrivingLicenseApplicationID)
        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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

        static public bool GetLocalLicenseAppInfoByID(int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {

                    ApplicationID = (int)Reader["ApplicationID"];
                    LicenseClassID = (int)Reader["LicenseClassID"];

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

        static public bool GetLocalLicenseAppInfoByApplicationID(ref int LocalDrivingLicenseApplicationID, int ApplicationID, ref int LicenseClassID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT * FROM LocalDrivingLicenseApplications WHERE ApplicationID =@ApplicationID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {

                    LocalDrivingLicenseApplicationID = (int)Reader["LocalDrivingLicenseApplicationID"];
                    LicenseClassID = (int)Reader["LicenseClassID"];

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

        static public bool DoesItHaveADrivingLicense(int ApplicationID)

        {
            bool IsLicenseExist = false;
            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT 1 FROM Licenses WHERE ApplicationID = @ApplicationID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    IsLicenseExist = true;
                }

            }
            catch (Exception ex)
            {
                IsLicenseExist = false;
            }
            finally
            {
                Connection.Close();
            }


            return IsLicenseExist;
        }
        static public bool IsLocalDrivingLicenseAppCanceled(int LocalDrivingLicenseApplicationID)
        {
            bool IsAppCanceled = false;
            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"Select IsAppCanceled = 1 From LocalDrivingLicenseApplications INNER JOIN Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID And ApplicationStatus = 2;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    IsAppCanceled = true;
                }

            }
            catch (Exception ex)
            {
                IsAppCanceled = false;
            }
            finally
            {
                Connection.Close();
            }


            return IsAppCanceled;
        }
        static public bool DoesHaveApplicationActiveWithLicenseClass(ref int ApplicationID,int PersonID,int LicenseClassID)
        {
            ApplicationID = -1;
            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT Applications.ApplicationID
FROM Applications INNER JOIN LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID 
                  INNER JOIN LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID 
				  INNER JOIN People ON Applications.ApplicationPersonID = People.PersonID
WHERE People.PersonID = @PersonID AND LicenseClasses.LicenseClassID = @LicenseClassID AND Applications.ApplicationStatus = 1;";
                           
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    ApplicationID = ID;
                }

            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                Connection.Close();
            }


            return ApplicationID!=-1;
        }

        static public byte GetNumberTestsPassedWithLocalDrivingLicenseAppID(int LocalDrivingLicenseApplicationID)

        {
            byte NumberTestPassed = 0;

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
                if (Result != null && byte.TryParse(Result.ToString(), out byte Count))
                {
                    NumberTestPassed = Count;
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
        static public bool HaveHeEverTakenATestBeforeFromTheType(int LocalDrivingLicenseApplicationID, byte TestTypeID)

        {
            bool IsHave = false;
            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT Top 1 (Tests.TestID) FROM Tests INNER JOIN TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
WHERE TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestAppointments.TestTypeID = @TestTypeID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    IsHave = true ;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }


            return IsHave;
        }
        static public bool UpdateLocalDrivingLicenseAppStatus(int LocalDrivingLicenseApplicationID, byte NewStatus)
        {
            bool IsUpdated = false;
            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"Update Applications
SET ApplicationStatus = @ApplicationStatus
WHERE ApplicationID = (SELECT ApplicationID FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID);";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@ApplicationStatus", NewStatus);


            try
            {
                Connection.Open();

                IsUpdated = (Command.ExecuteNonQuery()>0);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }


            return IsUpdated;
        }
        static public bool IsLocalDrivingLicenseAppActive(int LocalDrivingLicenseApplicationID)

        {
            bool IsActive = false;
            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT IsActive = 1 FROM LocalDrivingLicenseApplications INNER JOIN Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
WHERE LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND Applications.ApplicationStatus = 1;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null )
                {
                    IsActive = true;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }


            return IsActive;
        }

        static public bool DidHeEverHasAnAppointment(int LocalDrivingLicenseApplicationID)
        {
            bool Answer = false;
            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT TOP 1 TestAppointmentID FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    Answer = true;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }


            return Answer;
        }

        static public bool DidHeAttendHisLastAppointment(int LocalDrivingLicenseApplicationID)
        {
            bool DidHeAttend = false;
            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT 1 FROM  Tests
WHERE Tests.TestAppointmentID = (SELECT TOP 1 (TestAppointmentID) FROM TestAppointments 
WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID ORDER BY TestAppointmentID Desc);";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    DidHeAttend = true;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }


            return DidHeAttend;
        }

        static public byte GetTheNumberOfTrialsByTestType(int LocalDrivingLicenseApplicationID, byte TestTypeID)

        {
            byte NumberOfTrials = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT COUNT(Tests.TestID) FROM Tests INNER JOIN TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
WHERE TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestAppointments.TestTypeID = @TestTypeID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && byte.TryParse(Result.ToString(), out byte Count))
                {
                    NumberOfTrials = Count;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }


            return NumberOfTrials;
        }

        static public bool IsLicenseIssued(int ApplicationID)
        {
            bool IsLicenseIssued = false;
            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT IsLicenseIssued = 1 FROM Licenses WHERE ApplicationID = @ApplicationID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    IsLicenseIssued = true;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }


            return IsLicenseIssued;
        }
        static public DateTime GetTheDateOfTheLastTestAppointment(int LocalDrivingLicenseApplicationID)


        {
            DateTime DateOfLastAppointment = DateTime.Now;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT TOP 1 (AppointmentDate) FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID 
ORDER BY TestAppointmentID Desc";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && DateTime.TryParse(Result.ToString(), out DateTime Date))
                {
                    DateOfLastAppointment = Date;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }


            return DateOfLastAppointment;
        }
    }


}
