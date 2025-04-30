using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace DVLD_DataAccessLayer
{
    static public class clsDataApplications
    {
        static public DataTable GetAllApplications()
        {
            DataTable dtApplicationsList = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT * FROM Applications;";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dtApplicationsList.Load(Reader);
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


            return dtApplicationsList;
        }

        static public bool GetApplicationInfoByID(int ApplicationID, ref int ApplicationPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID
            , ref byte ApplicationStatus, ref DateTime LastStatusDate, ref decimal PaidFees, ref int CreatedByUserID)


        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT * FROM Applications WHERE ApplicationID =@ApplicationID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {

                    ApplicationPersonID = (int)Reader["ApplicationPersonID"];
                    ApplicationTypeID = (int)Reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)Reader["ApplicationStatus"];
                    PaidFees = (decimal)Reader["PaidFees"];
                    ApplicationDate = (DateTime)Reader["ApplicationDate"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    LastStatusDate = (DateTime)Reader["LastStatusDate"];


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

        static public int AddNewApplication(int ApplicationPersonID, DateTime ApplicationDate,int ApplicationTypeID
            ,byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees,int CreatedByUserID)

        {
            int ApplicationID = -1;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"INSERT INTO Applications
                                   (ApplicationPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus,LastStatusDate
                                    ,PaidFees,CreatedByUserID)
                             VALUES
                                   (@ApplicationPersonID,@ApplicationDate,@ApplicationTypeID,@ApplicationStatus
                                    ,@LastStatusDate,@PaidFees,@CreatedByUserID);

                                         SELECT Scope_IDentity();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationPersonID", ApplicationPersonID);
            Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            Command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);



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
                ApplicationID = -1;
            }
            finally
            {
                Connection.Close();
            }


            return ApplicationID;
        }

        static public bool UpdateApplication(int ApplicationID, int ApplicationPersonID, DateTime ApplicationDate
            , int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)


        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"UPDATE Applications
                            SET ApplicationPersonID = @ApplicationPersonID
                               ,ApplicationDate = @ApplicationDate
                               ,ApplicationTypeID = @ApplicationTypeID
                               ,ApplicationStatus = @ApplicationStatus
                               ,LastStatusDate = @LastStatusDate
                               ,PaidFees = @PaidFees
                               ,CreatedByUserID = @CreatedByUserID
                          WHERE ApplicationID = @ApplicationID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@ApplicationPersonID", ApplicationPersonID);
            Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            Command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
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

        static public bool DeleteApplication(Int32 ApplicationID)
        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "DELETE FROM Applications WHERE ApplicationID = @ApplicationID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

        static public bool IsApplicationExist(Int32 ApplicationID)
        {
            bool IsApplicationExists = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT 1 FROM Applications WHERE ApplicationID = @ApplicationID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                Connection.Open();
                object Exist = Command.ExecuteScalar();
                if (Exist != null)
                {
                    IsApplicationExists = true;
                }
            }
            catch (Exception ex)
            {
                IsApplicationExists = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsApplicationExists;
        }

        static public bool UpdateStatus(int ApplicationID, byte NewStatus)
        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"UPDATE Applications
                            SET 
                               ApplicationStatus = @ApplicationStatus
                               ,LastStatusDate = @LastStatusDate

                          WHERE ApplicationID = @ApplicationID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@ApplicationStatus", NewStatus);
            Command.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);


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




        

        static public bool CancelApplication(int ApplicationID)
        {

            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"UPDATE Applications
                        SET 
                            LastStatusDate = @LastStatusDate
                           ,ApplicationStatus = 2
                      WHERE ApplicationID = @ApplicationID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);


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
