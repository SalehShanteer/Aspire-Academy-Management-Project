using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CourseCenterDataLayer
{
    public class clsCourseData
    {
        
        public static bool FindCourseByID(int ID, ref string Name, ref int InstructorID, ref short CreditHours, ref decimal CourseFee)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "select * from Courses where CourseID = @CourseID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CourseID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Name = (string)reader["Name"];

                    if (reader["InstructorID"] != DBNull.Value)
                        InstructorID = (int)reader["InstructorID"];
                    else
                        InstructorID = -1;

                    if (reader["CreditHours"] != DBNull.Value)
                        CreditHours = (short)reader["CreditHours"];
                    else
                        CreditHours = -1;

                    if (reader["CourseFee"] != DBNull.Value)
                        CourseFee = (decimal)reader["CourseFee"];
                    else
                        CourseFee = -1;

                    IsFound = true;
                }
                reader.Close();
            }
            catch { IsFound = false; }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool FindCourseByName(ref int ID, string Name, ref int InstructorID, ref short CreditHours, ref decimal CourseFee)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "select * from Courses where Name = @Name";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ID = (int)reader["CourseID"];

                    if (reader["InstructorID"] != DBNull.Value)
                        InstructorID = (int)reader["InstructorID"];
                    else
                        InstructorID = -1;

                    if (reader["CreditHours"] != DBNull.Value)
                        CreditHours = (short)reader["CreditHours"];
                    else
                        CreditHours = -1;

                    if (reader["CourseFee"] != DBNull.Value)
                        CourseFee = (decimal)reader["CourseFee"];
                    else
                        CourseFee = -1;

                    IsFound = true;
                }
                reader.Close();
            }
            catch { IsFound = false; }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool IsCourseExist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "select * from Courses where CourseID = @CourseID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CourseID", ID);

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

        public static bool IsCourseExist(string Name)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "select * from Courses where Name = @Name";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);

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

        public static int AddNewCourse(string Name, int InstructorID, short CreditHours, decimal CourseFee)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "insert into Courses values (@Name, @InstructorID, @CreditHours, @CourseFee) " +
                           "select SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@InstructorID", InstructorID != -1 ? (object)InstructorID : DBNull.Value);
            command.Parameters.AddWithValue("@CreditHours", CreditHours != -1 ? (object)CreditHours : DBNull.Value);
            command.Parameters.AddWithValue("@CourseFee", CourseFee != -1 ? (object)CourseFee : DBNull.Value);

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

        public static bool UpdateCourse(int ID, string Name, int InstructorID, short CreditHours, decimal CourseFee)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "update Courses set Name = @Name, InstructorID = @InstructorID" +
                           ", CreditHours = @CreditHours, CourseFee = @CourseFee where CourseID = @CourseID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);

            if (InstructorID != -1)
                command.Parameters.AddWithValue("@InstructorID", InstructorID);
            else
                command.Parameters.AddWithValue("@InstructorID", DBNull.Value);

            if (CreditHours != -1)
                command.Parameters.AddWithValue("@CreditHours", CreditHours);
            else
                command.Parameters.AddWithValue("@CreditHours", DBNull.Value);

            if (CourseFee != -1)
                command.Parameters.AddWithValue("@CourseFee", CourseFee);
            else
                command.Parameters.AddWithValue("@CourseFee", DBNull.Value);

            command.Parameters.AddWithValue("@CourseID", ID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch { RowsAffected = 0; }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static bool DeleteCourse(int ID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "delete from Courses where CourseID = @CourseID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CourseID", ID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch { RowsAffected = 0; }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static DataTable GetAllCourses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "select * from Courses";
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

        public static DataTable GetInstructorCourses(int InstructorID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "select CourseID, Name, CreditHours, CourseFee from Courses " +
                           "where InstructorID = @InstructorID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InstructorID", InstructorID);

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

        public static DataTable GetCompleteCourses()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from Courses " +
                           "where CreditHours is not null and CourseFee is not null";
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

        public static int CountCourses()
        {
            int counter = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "select count(*) from Courses select SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int CoursesNumber))
                    counter = CoursesNumber;
            }
            catch { counter = -1; }
            finally { connection.Close(); }

            return counter;
        }

        public static int CountInstructorCourses(int InstructorID)
        {
            int counter = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "select count(*) from Courses where InstructorID = @InstructorID " +
                           "select SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InstructorID", InstructorID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int CoursesNumber))
                    counter = CoursesNumber;
            }
            catch { counter = -1; }
            finally { connection.Close(); }

            return counter;
        }

        public static int CountInstructorsTeachCourses()
        {
            int counter = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "select count(Distinct InstructorID) from Courses " +
                           "select SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InstructorsNumber))
                    counter = InstructorsNumber;
            }
            catch { counter = -1; }
            finally { connection.Close(); }

            return counter;
        }
    }
}
