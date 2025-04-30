using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    static public class clsDataApplicationTypes
    {
        static public DataTable GetAllApplicationTypes()
        {
            DataTable dtApplicationTypes = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT * FROM ApplicationTypes;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dtApplicationTypes.Load(Reader);
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


            return dtApplicationTypes;
        }

        static public decimal GetFeesApplicationType(byte ApplicationTypeID)


        {
            decimal ApplicationTypeFees = -1;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT ApplicationFees FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && decimal.TryParse(Result.ToString(), out decimal Fees))
                {
                    ApplicationTypeFees = Fees;
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                Connection.Close();
            }


            return ApplicationTypeFees;
        }
        static public bool GetApplicationTypeInfoByID(int ID,ref string Title, ref decimal Fees)

        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT * FROM ApplicationTypes WHERE ApplicationTypeID =@ID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {

                    Title = (string)Reader["ApplicationTypeTitle"];
                    Fees = (decimal)Reader["ApplicationFees"];

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

        static public bool GetApplicationTypeInfoByTitle(ref int ID, string Title, ref decimal Fees)

        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT * FROM ApplicationTypes WHERE ApplicationTypeTitle =@Title;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Title", Title);

            //ApplicationTypeID
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {

                    ID = (int)Reader["ApplicationTypeID"];
                    Fees = (decimal)Reader["ApplicationFees"];

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

        static public bool UpdateApplicationType(int ID, string Title, decimal Fees)



        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"UPDATE ApplicationTypes
                             SET ApplicationTypeTitle = @Title
                                ,ApplicationFees = @Fees
                           WHERE ApplicationTypeID = @ID; ";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@Title", Title);
            Command.Parameters.AddWithValue("@Fees", Fees);


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
