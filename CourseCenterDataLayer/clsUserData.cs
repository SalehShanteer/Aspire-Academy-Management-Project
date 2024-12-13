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
    public class clsUserData
    {

        public static bool FindByID(int ID, ref int PersonID, ref string Username, ref string Password
            , ref int RoleID, ref DateTime DateCreated, ref DateTime LastLogin
            , ref bool IsActive)
        {
            bool IsFound = false;
            
            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from users where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    Username = (string)reader["Username"];
                    Password = (string)reader["Password"];
                    RoleID = (int)reader["RoleID"];

                    DateCreated = reader["DateCreated"] != DBNull.Value ? (DateTime)reader["DateCreated"] : DateTime.MinValue;
                    DateCreated = reader["LastLogin"] != DBNull.Value ? (DateTime)reader["LastLogin"] : DateTime.MinValue;

                    IsActive = (bool)reader["IsActive"];

                    IsFound = true;
                }
                reader.Close();
            }
            catch { IsFound = false; }
            finally {  connection.Close(); }

            return IsFound;
        }

        public static bool FindByUsernameAndPassword(ref int ID, ref int PersonID, string Username, string Password
            , ref int RoleID, ref DateTime DateCreated, ref DateTime LastLogin
            , ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from users where Username = @Username and Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    RoleID = (int)reader["RoleID"];

                    DateCreated = reader["DateCreated"] != DBNull.Value ? (DateTime)reader["DateCreated"] : DateTime.MinValue;
                    DateCreated = reader["LastLogin"] != DBNull.Value ? (DateTime)reader["LastLogin"] : DateTime.MinValue;

                    IsActive = (bool)reader["IsActive"];

                    IsFound = true;
                }
                reader.Close();
            }
            catch { IsFound = false; }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool IsExistByID(int ID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select 1 from Users where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", ID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                IsFound = result != null;          
            }
            catch {}
            finally { connection.Close(); }
            
            return IsFound;
        }

        public static bool IsExistByUsernameAndPassword(string Username, string Password)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select 1 from Users where Username = @Username AND Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                IsFound = result != null;
            }
            catch { }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool IsPersonIDExist(int PersonID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select 1 from Users where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                IsFound = result != null;
            }
            catch { }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool IsUsernameUsedBefore(string Username)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select 1 from Users where Username = @Username";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                IsFound = result != null;
            }
            catch { }
            finally { connection.Close(); }

            return IsFound;
        }

        //return if username used before without except user ID username (used when update  )
        public static bool IsUsernameUsedBefore(int ID, string Username)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select 1 from Users where Username = @Username and UserID <> @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", ID);
            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                IsFound = result != null;
            }
            catch { }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool IsUserActive(string Username)
        {
            bool IsActive = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select IsActive from Users where Username = @Username";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && bool.TryParse(result.ToString(), out bool res))
                {
                    IsActive = res;
                }               
            }
            catch { }
            finally { connection.Close(); }

            return IsActive;
        }

        public static int AddNewUser(int PersonID, string Username, string Password, int RoleID, bool IsActive)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "insert into Users values (@PersonID, @Username, @Password, @RoleID" +
                           ", GetDate(), NULL, @IsActive) " +
                           "select SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@RoleID", RoleID);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int NewID))
                {
                    ID = NewID;
                }
            }
            catch { }
            finally { connection.Close(); }

            return ID;
        }

        public static bool UpdateUser(int ID, int PersonID, string Username, string Password, int RoleID
            , DateTime LastLogin, bool IsActive)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "UPDATE Users SET PersonID = @PersonID, Username = @Username, Password = @Password" +
                           ", RoleID = @RoleID, LastLogin = @LastLogin, IsActive = @IsActive " +
                           "WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@RoleID", RoleID);

            command.Parameters.AddWithValue("@LastLogin", LastLogin != DateTime.MinValue? LastLogin : (object)DBNull.Value);

            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@UserID", ID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();               
            }
            catch { RowsAffected = 0; }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static bool DeleteUser(int ID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "DELETE from Users where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", ID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static DataTable GetAllUsersList()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from Users";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }

            return dt;
        }

    }
}
