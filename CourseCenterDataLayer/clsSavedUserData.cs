using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCenterDataLayer
{
    public class clsSavedUserData
    {

        public static bool FindSavedUserByID(int ID, ref string Username, ref string Password)
        {
            
            bool IsFound = false;   

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select Username, Password from SavedUser where ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Username = (string)reader["Username"];
                    Password = (string)reader["Password"];

                    IsFound = true;
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); } 

            return IsFound;
        }
        
        public static bool UpdateSavedUser(string Username, string Password)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "Update SavedUser set Username = @Username, Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

    }
}
