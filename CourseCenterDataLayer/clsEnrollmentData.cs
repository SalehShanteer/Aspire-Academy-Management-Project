using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCenterDataLayer
{
    public class clsEnrollmentData
    {
        public static bool FindEnrollmentByID(int ID, ref int StudentID, ref int CourseID,  ref DateTime StartDate, ref DateTime EndDate, ref byte Grade)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "select * from Enrollments where EnrollmentID = @EnrollmentID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EnrollmentID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    StudentID = (int)reader["StudentID"];
                    CourseID = (int)reader["CourseID"];
                    StartDate = (DateTime)reader["StartDate"];

                    if (reader["EndDate"] != DBNull.Value)
                        EndDate = (DateTime)reader["EndDate"];
                    else
                        EndDate = DateTime.MinValue;

                    if (reader["Grade"] != DBNull.Value)
                        Grade = (byte)reader["Grade"];
                    else
                        Grade = 101;

                    IsFound = true;
                }
                reader.Close();
            }
            catch { IsFound = false; }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool IsEnrollmentExist(int ID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "select * from Enrollments where EnrollmentID = @EnrollmentID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EnrollmentID", ID);

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

        public static int AddNewEnrollment(int StudentID, int CourseID, DateTime StartDate, DateTime EndDate, byte Grade)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "insert into Enrollments values (@StudentID, @CourseID, @StartDate, @EndDate, @Grade) " +
                           "select SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@StudentID", StudentID);
            command.Parameters.AddWithValue("@CourseID", CourseID);
            command.Parameters.AddWithValue("@StartDate", StartDate);

            if (EndDate != DateTime.MinValue)
                command.Parameters.AddWithValue("@EndDate", EndDate);
            else
                command.Parameters.AddWithValue("@EndDate", DBNull.Value);

            if (Grade != 101)
                command.Parameters.AddWithValue("@Grade", Grade);
            else
                command.Parameters.AddWithValue("@Grade", DBNull.Value);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int NewID))
                    ID = NewID;
            }
            catch { ID = -1; }
            finally { connection.Close(); }

            return ID;
        }

        public static bool UpdateEnrollment(int ID, int StudentID, int CourseID, DateTime StartDate, DateTime EndDate, byte Grade)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "update Enrollments set StudentID = @StudentID, CourseID = @CourseID, StartDate = @StartDate" +
                ", EndDate = @EndDate, Grade = @Grade where EnrollmentID = @EnrollmentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StudentID", StudentID);
            command.Parameters.AddWithValue("@CourseID", CourseID);
            command.Parameters.AddWithValue("@StartDate", StartDate);
            if (EndDate != DateTime.MinValue)
                command.Parameters.AddWithValue("@EndDate", EndDate);
            else
                command.Parameters.AddWithValue("@EndDate", DBNull.Value);
            if (Grade != 101)
                command.Parameters.AddWithValue("@Grade", Grade);
            else
                command.Parameters.AddWithValue("@Grade", DBNull.Value);
            command.Parameters.AddWithValue("@EnrollmentID", ID);
            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch { RowsAffected = 0; }
            finally { connection.Close(); }
            return RowsAffected > 0;
        }

        public static bool DeleteEnrollment(int ID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "delete from Enrollments where EnrollmentId = @EnrollmentID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EnrollmentID", ID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch { RowsAffected = 0; }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static DataTable GetAllEnrollments()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "select * from Enrollments";
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

        public static DataTable GetActiveStudentsList()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from ActiveStudentsList";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                reader.Close();
            }
            catch {}
            finally { connection.Close(); }
            return dt;
        }

        public static DataTable GetStudentsListForCourse(int CourseID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select Enrollments.StudentID, Persons.FirstName, Persons.LastName, Enrollments.EnrollmentID, Enrollments.Grade " +
                           "from Enrollments " +
                           "inner join Students on Students.StudentID = Enrollments.StudentID " +
                           "inner join Persons on Persons.PersonID = Students.PersonID " +
                           "where CourseID = @CourseID and EndDate is null";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CourseID", CourseID);
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

        public static DataTable GetStudentEnrollments(int StudentID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "select EnrollmentID, CourseID, StartDate, EndDate, Grade " +
                           "from Enrollments " +
                           "where StudentID = @StudentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StudentID", StudentID);
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

        public static int CountEnrollments()
        {
            int counter = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "select count(*) from Enrollments";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int EnrollmentsNumber))
                    counter = EnrollmentsNumber;
            }
            catch { counter = -1; }
            finally { connection.Close(); }

            return counter;
        }

        public static int CountActiveStudents()
        {
            int counter = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "select count(distinct StudentID) from Enrollments " +
                           "where EndDate is null";
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

        public static int CountStudentsEnrolledInCourse(int CourseID)
        {
            int counter = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "select count(Distinct StudentID) from Enrollments " +
                           "where CourseID = @CourseID and EndDate is null";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CourseID", CourseID);

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

        public static int CountStudentEnrollments(int StudentID)
        {
            int counter = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "select count(*) from Enrollments " +
                           "where StudentID = @StudentID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@StudentID", StudentID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int EnrollmentsNumber))
                    counter = EnrollmentsNumber;
            }
            catch { counter = -1; }
            finally { connection.Close(); }

            return counter;
        }

    }
}
