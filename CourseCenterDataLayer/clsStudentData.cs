using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CourseCenterDataLayer
{
    public class clsStudentData
    {
        public static bool FindStudentByID(int ID, ref int PersonID, ref int LevelID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from Students where StudentID = @StudentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@StudentID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    LevelID = (int)reader["LevelID"];

                    IsFound = true;
                }
                reader.Close();
            }
            catch { IsFound = false; }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool IsStudentExist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from students where StudentID = @StudentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@StudentID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    isFound = true;

                reader.Close();
            }
            catch { isFound = false; }
            finally { connection.Close(); }

            return isFound;
        }

        public static bool IsPersonIDExist(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from students where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    isFound = true;

                reader.Close();
            }
            catch { isFound = false; }
            finally { connection.Close(); }

            return isFound;
        }

        public static int AddNewStudent(int PersonID, int LevelID)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "insert into Students values (@PersonID, @LevelID) " +
                           "select SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LevelID", LevelID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int NewID))
                    ID = NewID;
            }
            catch { }
            finally { connection.Close(); }

            return ID;
        }

        public static bool UpdateStudent(int ID, int PersonID, int LevelID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "update Students set PersonID = @PersonID, LevelID = @LevelID where StudentID = @StudentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LevelID", LevelID);
            command.Parameters.AddWithValue("@StudentID", ID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch { RowsAffected = 0; }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static bool DeleteStudent(int ID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "delete from Students where StudentID = @StudentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@StudentID", ID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch { RowsAffected = 0; }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static DataTable GetAllStudents()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from Students";

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

        public static int CountStudents()
        {
            int counter = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select count(*) from Students";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int StudentsNumber))
                    counter = StudentsNumber;
            }
            catch { counter = -1; }
            finally { connection.Close(); }

            return counter;
        }

        public static string GetStudentFullName(int ID)
        {
            string FullName = string.Empty;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select (Persons.FirstName + ' ' +  Persons.LastName) as FullName from Students " +
                           "inner join Persons " +
                           "on Persons.PersonID = Students.PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                FullName = result.ToString();
            }
            catch { FullName = string.Empty; }
            finally { connection.Close(); }

            return FullName;
        }

    }
}
