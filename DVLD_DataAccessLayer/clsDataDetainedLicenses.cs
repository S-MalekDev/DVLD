using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public static class clsDataDetainedLicenses
    {

        static public DataTable GetAllDetainedLicenses()
        {
            DataTable dtDetainedLicensesList = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT * FROM DetainedLicensesListView ORDER BY ID Asc;";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dtDetainedLicensesList.Load(Reader);
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


            return dtDetainedLicensesList;
        }

        static public bool GetDetainedLicenseInfoByID(Int32 DetainID, ref Int32 LicenseID, ref DateTime DetainDate, ref Decimal FineFees, ref Int32 CreatedByUserID, ref Boolean IsReleased, ref DateTime ReleaseDate, ref Int32 ReleasedByUserID, ref Int32 ReleaseApplicationID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT * FROM DetainedLicenses WHERE DetainID =@DetainID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DetainID", DetainID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {

                    LicenseID = (Int32)Reader["LicenseID"];
                    DetainDate = (DateTime)Reader["DetainDate"];
                    FineFees = (Decimal)Reader["FineFees"];
                    CreatedByUserID = (Int32)Reader["CreatedByUserID"];
                    IsReleased = (Boolean)Reader["IsReleased"];

                    if (Reader["ReleaseDate"] != DBNull.Value)
                        ReleaseDate = (DateTime)Reader["ReleaseDate"];


                    if (Reader["ReleasedByUserID"] != DBNull.Value)
                        ReleasedByUserID = (Int32)Reader["ReleasedByUserID"];


                    if (Reader["ReleaseApplicationID"] != DBNull.Value)
                        ReleaseApplicationID = (Int32)Reader["ReleaseApplicationID"];



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

        static public int AddNewDetainedLicense(Int32 LicenseID, DateTime DetainDate, Decimal FineFees, Int32 CreatedByUserID, Boolean IsReleased, DateTime ReleaseDate, Int32 ReleasedByUserID, Int32 ReleaseApplicationID)
        {
            int DetainID = -1;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"INSERT INTO DetainedLicenses
                                         (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID)
                                   VALUES
                                         (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID);

                                         SELECT Scope_IDentity();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@DetainDate", DetainDate);
            Command.Parameters.AddWithValue("@FineFees", FineFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsReleased", IsReleased);

            if (ReleaseDate == default)
                Command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);


            if (ReleasedByUserID == default)
                Command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);


            if (ReleaseApplicationID == default)
                Command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);



            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    DetainID = ID;
                }
            }
            catch (Exception ex)
            {
                DetainID = -1;
            }
            finally
            {
                Connection.Close();
            }


            return DetainID;
        }

        static public bool UpdateDetainedLicense(Int32 DetainID, Int32 LicenseID, DateTime DetainDate, Decimal FineFees, Int32 CreatedByUserID, Boolean IsReleased, DateTime ReleaseDate, Int32 ReleasedByUserID, Int32 ReleaseApplicationID)
        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"UPDATE DetainedLicenses 
SET LicenseID = @LicenseID
, DetainDate = @DetainDate
, FineFees = @FineFees
, CreatedByUserID = @CreatedByUserID
, IsReleased = @IsReleased
, ReleaseDate = @ReleaseDate
, ReleasedByUserID = @ReleasedByUserID
, ReleaseApplicationID = @ReleaseApplicationID
WHERE DetainID = @DetainID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DetainID", DetainID);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@DetainDate", DetainDate);
            Command.Parameters.AddWithValue("@FineFees", FineFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsReleased", IsReleased);

            if (ReleaseDate == default)
                Command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);


            if (ReleasedByUserID == default)
                Command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);


            if (ReleaseApplicationID == default)
                Command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);



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

        static public bool DeleteDetainedLicense(Int32 DetainID)
        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "DELETE FROM DetainedLicenses WHERE DetainID = @DetainID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DetainID", DetainID);

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

        static public bool IsDetainedLicenseExist(Int32 DetainID)
        {
            bool IsDetainedLicenseExists = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT 1 FROM DetainedLicenses WHERE DetainID = @DetainID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                Connection.Open();
                object Exist = Command.ExecuteScalar();
                if (Exist != null)
                {
                    IsDetainedLicenseExists = true;
                }
            }
            catch (Exception ex)
            {
                IsDetainedLicenseExists = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsDetainedLicenseExists;
        }

        static public bool GetDetainedLicenseInfoByLicenseID(ref Int32 DetainID, Int32 LicenseID, ref DateTime DetainDate, ref Decimal FineFees, ref Int32 CreatedByUserID, ref Boolean IsReleased, ref DateTime ReleaseDate, ref Int32 ReleasedByUserID, ref Int32 ReleaseApplicationID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT TOP 1 * FROM DetainedLicenses WHERE LicenseID =@LicenseID ORDER BY DetainID Desc;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {

                    DetainID = (Int32)Reader["DetainID"];
                    DetainDate = (DateTime)Reader["DetainDate"];
                    FineFees = (Decimal)Reader["FineFees"];
                    CreatedByUserID = (Int32)Reader["CreatedByUserID"];
                    IsReleased = (Boolean)Reader["IsReleased"];

                    if (Reader["ReleaseDate"] != DBNull.Value)
                        ReleaseDate = (DateTime)Reader["ReleaseDate"];


                    if (Reader["ReleasedByUserID"] != DBNull.Value)
                        ReleasedByUserID = (Int32)Reader["ReleasedByUserID"];


                    if (Reader["ReleaseApplicationID"] != DBNull.Value)
                        ReleaseApplicationID = (Int32)Reader["ReleaseApplicationID"];



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
        static public bool IsLicenseDetain(int LicenseID)

        {
            bool IsLicenseDetain= false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT TOP 1 (DetainID) FROM DetainedLicenses WHERE LicenseID = @LicenseID AND IsReleased = 0 ORDER BY DetainID Desc;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                Connection.Open();
                object Exist = Command.ExecuteScalar();
                if (Exist != null)
                {
                    IsLicenseDetain = true;
                }
            }
            catch (Exception ex)
            {
                IsLicenseDetain = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsLicenseDetain;
        }


    }


}
