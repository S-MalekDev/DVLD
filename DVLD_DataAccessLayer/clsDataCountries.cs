using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public static class clsDataCountries
    {
        static public DataTable GetAllCountries()
        {
            DataTable dtCountries = new DataTable();

            string Query = "SELECT CountryName FROM Countries;";

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dtCountries.Load(Reader);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }

            return dtCountries;
        }

        static public bool GetCountryInfoByID(short CountryID, ref string CountryName)

        {
            bool IsFind = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT CountryName FROM Countries WHERE CountryID = @CountryID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                Connection.Open();
                object Name = Command.ExecuteScalar();
                if (Name != null)
                {
                    CountryName = Name.ToString();
                    IsFind = true;
                }

            }
            catch (Exception ex)
            {
                IsFind = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsFind;
        }

        static public bool GetCountryInfoByName(ref short CountryID,string CountryName)

        {
            bool IsFind = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT CountryID FROM Countries WHERE CountryName = @CountryName;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                Connection.Open();
                object ID = Command.ExecuteScalar();
                if (ID != null && short.TryParse(ID.ToString(),out CountryID))
                {
                    IsFind = true;
                }

            }
            catch (Exception ex)
            {
                IsFind = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsFind;
        }
    }
}