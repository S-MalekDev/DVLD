using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    static public class clsDataLicenseClasses
    {

        static public DataTable GetAllLicenseClasses()
        {
            DataTable dtLicenseClassesList = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT * FROM LicenseClasses;";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dtLicenseClassesList.Load(Reader);
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


            return dtLicenseClassesList;
        }

        static public bool GetLicenseClassInfoByID(Int32 LicenseClassID, ref String ClassName, ref String ClassDescription, ref Byte MinimumAllowedAge, ref Byte DefaultValidityLength, ref Decimal ClassFees)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT * FROM LicenseClasses WHERE LicenseClassID =@LicenseClassID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {

                    ClassName = (String)Reader["ClassName"];
                    ClassDescription = (String)Reader["ClassDescription"];
                    MinimumAllowedAge = (Byte)Reader["MinimumAllowedAge"];
                    DefaultValidityLength = (Byte)Reader["DefaultValidityLength"];
                    ClassFees = (Decimal)Reader["ClassFees"];


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

        static public int AddNewLicenseClass(String ClassName, String ClassDescription, Byte MinimumAllowedAge, Byte DefaultValidityLength, Decimal ClassFees)
        {
            int LicenseClassID = -1;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"INSERT INTO LicenseClasses
                                         (ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees)
                                   VALUES
                                         (@ClassName, @ClassDescription, @MinimumAllowedAge, @DefaultValidityLength, @ClassFees);

                                         SELECT Scope_IDentity();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ClassName", ClassName);
            Command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            Command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            Command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            Command.Parameters.AddWithValue("@ClassFees", ClassFees);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    LicenseClassID = ID;
                }
            }
            catch (Exception ex)
            {
                LicenseClassID = -1;
            }
            finally
            {
                Connection.Close();
            }


            return LicenseClassID;
        }

        static public bool UpdateLicenseClass(Int32 LicenseClassID, String ClassName, String ClassDescription, Byte MinimumAllowedAge, Byte DefaultValidityLength, Decimal ClassFees)
        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"UPDATE LicenseClasses 
SET ClassName = @ClassName
, ClassDescription = @ClassDescription
, MinimumAllowedAge = @MinimumAllowedAge
, DefaultValidityLength = @DefaultValidityLength
, ClassFees = @ClassFees
WHERE LicenseClassID = @LicenseClassID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            Command.Parameters.AddWithValue("@ClassName", ClassName);
            Command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            Command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            Command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            Command.Parameters.AddWithValue("@ClassFees", ClassFees);


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

        static public bool DeleteLicenseClass(Int32 LicenseClassID)
        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "DELETE FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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

        static public bool IsLicenseClassExist(Int32 LicenseClassID)
        {
            bool IsLicenseClassExists = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT 1 FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                Connection.Open();
                object Exist = Command.ExecuteScalar();
                if (Exist != null)
                {
                    IsLicenseClassExists = true;
                }
            }
            catch (Exception ex)
            {
                IsLicenseClassExists = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsLicenseClassExists;
        }

    }

}
