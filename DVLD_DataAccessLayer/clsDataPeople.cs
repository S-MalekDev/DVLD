using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public static class clsDataPeople
    {
        static public DataTable GetAllPeople()
        {
            DataTable PeopleList = new DataTable();

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT * FROM PeopleList;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if(Reader.HasRows)
                {
                    PeopleList.Load(Reader);
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
            

            return PeopleList;
        }

        static public bool GetPersonInfoByID(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName
            , ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone, ref string Email
                                             , ref short NationalityCountryID, ref string ImagePath)

        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT * FROM People WHERE PersonID =@PersonID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {

                    NationalNo = (string)Reader["NationalNo"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    LastName = (string)Reader["LastName"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    Gendor = (byte)Reader["Gendor"];
                    Address = (string)Reader["Address"];
                    Phone = (string)Reader["Phone"];
                    NationalityCountryID = (short)(int)Reader["NationalityCountryID"];

                    if (Reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)Reader["ThirdName"];
                    }


                    if (Reader["Email"] != DBNull.Value)
                    {
                        Email = (string)Reader["Email"];
                    }



                    if (Reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)Reader["ImagePath"];
                    }



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

        static public bool GetPersonInfoByNationalNo(ref int PersonID,  string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName
            , ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone, ref string Email
                                             , ref short NationalityCountryID, ref string ImagePath)

        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"SELECT * FROM People WHERE NationalNo =@NationalNo;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {

                    PersonID = (int)Reader["PersonID"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    LastName = (string)Reader["LastName"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    Gendor = (byte)Reader["Gendor"];
                    Address = (string)Reader["Address"];
                    Phone = (string)Reader["Phone"];
                    NationalityCountryID = (short)(int)Reader["NationalityCountryID"];

                    if (Reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)Reader["ThirdName"];
                    }


                    if (Reader["Email"] != DBNull.Value)
                    {
                        Email = (string)Reader["Email"];
                    }



                    if (Reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)Reader["ImagePath"];
                    }



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

        static public int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName
                             , DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email
                             , short NationalityCountryID, string ImagePath)

        {
            int PersonID = -1;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"INSERT INTO People
                                         (NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth,Gendor,Address,Phone
                                         ,Email,NationalityCountryID,ImagePath)
                                   VALUES
                                         (@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,@Gendor,@Address
                                         ,@Phone,@Email,@NationalityCountryID,@ImagePath);

                                         SELECT Scope_IDentity();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);


            if (!string.IsNullOrEmpty(ThirdName))
            {
                Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            else
            {
                Command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            }


            if (!string.IsNullOrEmpty(Email))
            {
                Command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                Command.Parameters.AddWithValue("@Email", DBNull.Value);
            }


            if (!string.IsNullOrEmpty(ImagePath))
            {
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }


            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    PersonID = ID;
                }
            }
            catch (Exception ex)
            {
                PersonID = -1;
            }
            finally
            {
                Connection.Close();
            }


            return PersonID;
        }
        static public bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName
                                             , DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email
                                             , short NationalityCountryID, string ImagePath)


        {
            int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);


            string Query = @"UPDATE People
                           SET NationalNo = @NationalNo
                              ,FirstName = @FirstName
                              ,SecondName = @SecondName
                              ,ThirdName = @ThirdName
                              ,LastName = @LastName
                              ,DateOfBirth = @DateOfBirth
                              ,Gendor = @Gendor
                              ,Address = @Address
                              ,Phone = @Phone
                              ,Email = @Email
                              ,NationalityCountryID = @NationalityCountryID
                              ,ImagePath = @ImagePath
                         WHERE PersonID=@PersonID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);


            if (!string.IsNullOrEmpty(ThirdName))
            {
                Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            else
            {
                Command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            }


            if (!string.IsNullOrEmpty(Email))
            {
                Command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                Command.Parameters.AddWithValue("@Email", DBNull.Value);
            }


            if (!string.IsNullOrEmpty(ImagePath))
            {
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }


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


            return RowsEfacts>0;
        }

        static public bool DeletePerson(int PersonID)

        {
             int RowsEfacts = 0;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "DELETE FROM People WHERE PersonID = @PersonID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

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

            return RowsEfacts>0;
        }

        static public bool IsPersonExist(string NationalNo)
        {
            bool IsNationalNoExists = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT 1 FROM people WHERE NationalNo = @NationalNo;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                Connection.Open();
                object Exist = Command.ExecuteScalar();
                if (Exist != null)
                {
                    IsNationalNoExists = true;
                }
            }
            catch (Exception ex)
            {
                IsNationalNoExists = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsNationalNoExists;
        }

        static public bool IsPersonExist(int PersonID)
        {
            bool IsPersonIDExists = false;

            SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString);

            string Query = "SELECT 1 FROM people WHERE PersonID = @PersonID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                object Exist = Command.ExecuteScalar();
                if (Exist != null)
                {
                    IsPersonIDExists = true;
                }
            }
            catch (Exception ex)
            {
                IsPersonIDExists = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsPersonIDExists;
        }


    }
}
