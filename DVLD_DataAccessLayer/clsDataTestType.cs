using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public static class clsDataTestType
    {

        static public DataTable GetAllTestTypes()
        {
            DataTable dtTestTypesList = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT TestTypeID AS ID, TestTypeTitle AS Title, TestTypeDescription AS Description, TestTypeFees AS Fees FROM TestTypes;";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dtTestTypesList.Load(Reader);
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


            return dtTestTypesList;
        }

        static public bool GetTestTypeInfoByID(Int32 TestTypeID, ref String TestTypeTitle, ref String TestTypeDescription, ref Decimal TestTypeFees)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT * FROM TestTypes WHERE TestTypeID =@TestTypeID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {

                    TestTypeTitle = (String)Reader["TestTypeTitle"];
                    TestTypeDescription = (String)Reader["TestTypeDescription"];
                    TestTypeFees = (Decimal)Reader["TestTypeFees"];


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

        static public decimal GetFeesTestType(byte TestTypeID)

        {
            decimal TestTypeFees = -1;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT TestTypeFees FROM TestTypes WHERE TestTypeID = @TestTypeID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && decimal.TryParse(Result.ToString(), out decimal Fees))
                {
                    TestTypeFees = Fees;
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                Connection.Close();
            }


            return TestTypeFees;
        }
        static public int AddNewTestType(String TestTypeTitle, String TestTypeDescription, Decimal TestTypeFees)
        {
            int TestTypeID = -1;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"INSERT INTO TestTypes
                                         (TestTypeTitle, TestTypeDescription, TestTypeFees)
                                   VALUES
                                         (@TestTypeTitle, @TestTypeDescription, @TestTypeFees);

                                         SELECT Scope_IDentity();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            Command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            Command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    TestTypeID = ID;
                }
            }
            catch (Exception ex)
            {
                TestTypeID = -1;
            }
            finally
            {
                Connection.Close();
            }


            return TestTypeID;
        }

        static public bool UpdateTestType(Int32 TestTypeID, String TestTypeTitle, String TestTypeDescription, Decimal TestTypeFees)
        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"UPDATE TestTypes 
SET TestTypeTitle = @TestTypeTitle
, TestTypeDescription = @TestTypeDescription
, TestTypeFees = @TestTypeFees
WHERE TestTypeID = @TestTypeID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            Command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            Command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);


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

        static public bool DeleteTestType(Int32 TestTypeID)
        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "DELETE FROM TestTypes WHERE TestTypeID = @TestTypeID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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

        static public bool IsTestTypeExist(Int32 TestTypeID)
        {
            bool IsTestTypeExists = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT 1 FROM TestTypes WHERE TestTypeID = @TestTypeID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                Connection.Open();
                object Exist = Command.ExecuteScalar();
                if (Exist != null)
                {
                    IsTestTypeExists = true;
                }
            }
            catch (Exception ex)
            {
                IsTestTypeExists = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsTestTypeExists;
        }

    }


}
