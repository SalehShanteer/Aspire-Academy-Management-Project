using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCenterDataLayer
{
    public class clsRoleData
    {

        public static bool FindRoleByID(int ID, ref string Name, ref int Permissions, ref string Description)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from Roles where RoleID = @RoleID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoleID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Name = (string)reader["Name"];

                    Permissions = (int)reader["Permissions"];
                    
                    if (reader["Description"] != DBNull.Value)
                        Description = (string)reader["Description"];
                    else
                        Description = string.Empty;

                    IsFound = true;
                }
                reader.Close();
            }
            catch { IsFound = false; }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool FindRoleByName(string Name, ref int ID, ref int Permissions, ref string Description)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from Roles where Name = @Name";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ID = (int)reader["RoleID"];
                    Permissions = (int)reader["Permissions"];

                    if (reader["Description"] != DBNull.Value)
                        Description = (string)reader["Description"];
                    else
                        Description = string.Empty;

                    IsFound = true;
                }
                reader.Close();
            }
            catch { IsFound = false; }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool IsRoleExist(int ID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select 1 from Roles where RoleID = @RoleID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoleID", ID);

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

        public static int AddNewRole(string Name, int Permissions, string Description)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "insert into Roles values (@Name, @Permissions, @Description) " +
                           "select SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Permissions", Permissions);

            if (Description != string.Empty)
                command.Parameters.AddWithValue("@Description", Description);
            else
                command.Parameters.AddWithValue("@Description", DBNull.Value);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(Convert.ToString(result), out int NewID))
                {
                    ID = NewID;
                }
            }
            catch { ID = -1; }
            finally { connection.Close(); }

            return ID;
        }

        public static bool UpdateRole(int ID, string Name, int Permissions, string Description)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "Update Roles set Name = @Name, Permissions = @Permissions, Description = @Description " +
                           "where RoleID = @RoleID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Permissions", Permissions);

            if (Description != string.Empty)
                command.Parameters.AddWithValue("@Description", Description);
            else
                command.Parameters.AddWithValue("@Description", DBNull.Value);

            command.Parameters.AddWithValue("@RoleID", ID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch { RowsAffected = 0; }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static bool DeleteRole(int ID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "Delete from Roles where RoleID = @RoleID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoleID", ID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch { RowsAffected = 0; }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static DataTable GetAllRoles()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from Roles";

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
