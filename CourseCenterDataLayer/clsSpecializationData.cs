using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCenterDataLayer
{
    public class clsSpecializationData
    {
        public static bool FindSpecializationByID(int ID, ref string Name, ref string Description)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from Specializations where SpecializationID = @SpecializationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SpecializationID", ID);

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

        public static bool FindSpecializationByName(string Name, ref int ID, ref string Description)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from Specializations where Name = @Name";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ID = (int)reader["SpecializationID"];

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

        public static bool IsSpecializationExist(int ID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select 1 from Specializations where SpecializationID = @SpecializationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SpecializationID", ID);

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

        public static int AddNewSpecialization(string Name, string Description)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "insert into Specializations values (@Name, @Description) " +
                           "select SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);

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

        public static bool UpdateSpecialization(int ID, string Name, string Description)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "Update Specializations set Name = @Name, Description = @Description " +
                           "where SpecializationID = @SpecializationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);

            if (Description != string.Empty)
                command.Parameters.AddWithValue("@Description", Description);
            else
                command.Parameters.AddWithValue("@Description", DBNull.Value);

            command.Parameters.AddWithValue("@SpecializationID", ID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch { RowsAffected = 0; }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static bool DeleteSpecialization(int ID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "Delete from Specializations where SpecializationID = @SpecializationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SpecializationID", ID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch { RowsAffected = 0; }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static DataTable GetAllSpecializations()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from Specializations order by SpecializationID";

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
