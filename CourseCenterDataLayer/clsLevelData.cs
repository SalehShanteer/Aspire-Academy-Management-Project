using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCenterDataLayer
{
    public class clsLevelData
    {
        public static bool FindLevelByID(int ID, ref string Name, ref string Description)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from Levels where LevelID = @LevelID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LevelID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Name = (string)reader["Name"];

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

        public static bool FindLevelByName(string Name, ref int ID, ref string Description)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from Levels where Name = @Name";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ID = (int)reader["LevelID"];

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

        public static bool IsLevelExist(int ID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from Levels where LevelID = @LevelID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LevelID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                    IsFound = true;
            }
            catch { IsFound = false; }
            finally { connection.Close(); }

            return IsFound;
        }

        public static int AddNewLevel(string Name, string Description)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "insert into Levels values (@Name, @Description) select SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);

            if (!string.IsNullOrWhiteSpace(Description))
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

        public static bool UpdateLevel(int ID, string Name, string Description)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "Update levels set Name = @Name, Description = @Description where LevelID = @LevelID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);

            if (!string.IsNullOrWhiteSpace(Description))
                command.Parameters.AddWithValue("@Description", Description);
            else
                command.Parameters.AddWithValue("@Description", DBNull.Value);

            command.Parameters.AddWithValue("@LevelID", ID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch { RowsAffected = 0; }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static bool DeleteLevel(int ID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "delete from levels where LevelID = @LevelID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LevelID", ID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch { RowsAffected = 0; } 
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static DataTable GetAllLevels()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from Levels order by LevelID";

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
