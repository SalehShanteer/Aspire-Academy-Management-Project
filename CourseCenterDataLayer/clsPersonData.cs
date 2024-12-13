using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CourseCenterDataLayer
{
    public class clsPersonData
    {
        public static bool FindPersonByID(int ID, ref string FirstName, ref string LastName, ref string Gender
            , ref DateTime DateOfBirth, ref string Email, ref string Phone, ref string Address, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from Persons where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Gender = (string)reader["Gender"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];

                    if (reader["Address"] != DBNull.Value)
                        Address = (string)reader["Address"];
                    else
                        Address = string.Empty;

                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = string.Empty;

                    IsFound = true;
                }
                reader.Close();
            }
            catch { IsFound = false; }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool IsPersonExist(int ID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from Persons where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    IsFound = true;

                reader.Close();
            }
            catch { IsFound = false; } 
            finally { connection.Close(); }

            return IsFound;
        }

        public static int AddNewPerson(string FirstName, string LastName, string Gender, DateTime DateOfBirth, string Email
            , string Phone, string Address, string ImagePath)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "insert into Persons values (@FirstName, @LastName, @Gender, @DateOfBirth" +
                ", @Email, @Phone, @Address, @ImagePath) " +
                "select SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("Phone", Phone);

            if (!string.IsNullOrWhiteSpace(Address))
                command.Parameters.AddWithValue("@Address", Address);
            else
                command.Parameters.AddWithValue("@Address", DBNull.Value);

            if (!string.IsNullOrWhiteSpace(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(Convert.ToString(result), out int NewID))
                    ID = NewID;
            }
            catch { ID = -1; }
            finally { connection.Close(); }

            return ID;
        }

        public static bool UpdatePerson(int ID, string FirstName, string LastName, string Gender, DateTime DateOfBirth
            , string Email, string Phone, string Address, string ImagePath)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "update Persons set FirstName = @FirstName, LastName = @LastName, Gender = @Gender, DateOfBirth = @DateOfBirth" +
                ", Email = @Email, Phone = @Phone, Address = @Address, ImagePath = @ImagePath where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("Phone", Phone);

            if (!string.IsNullOrWhiteSpace(Address))
                command.Parameters.AddWithValue("@Address", Address);
            else
                command.Parameters.AddWithValue("@Address", DBNull.Value);

            if (!string.IsNullOrWhiteSpace(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            command.Parameters.AddWithValue("PersonID", ID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch { RowsAffected = 0; }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static bool DeletePerson(int ID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "delete from Persons where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch { RowsAffected = 0; } 
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static DataTable GetAllPersons()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from Persons";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                reader.Close();
            }
            catch { }
            finally { connection.Close(); }

            return dt;
        }
        
    }
}
