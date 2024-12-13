using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace CourseCenterDataLayer
{
    public class clsInstructorData
    {
        public static bool FindInstructorByID(int ID, ref int PersonID, ref int SpecializationID, ref string Certificates, ref decimal Salary)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "select * from Instructors where InstructorID = @InstructorID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InstructorID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];

                    if (reader["SpecializationID"] != DBNull.Value)
                        SpecializationID = (int)reader["SpecializationID"];
                    else
                        SpecializationID = -1;

                    if (reader["Certificates"] != DBNull.Value)
                        Certificates = (string)reader["Certificates"];
                    else
                        Certificates = string.Empty;

                    if (reader["Salary"] != DBNull.Value)
                        Salary = (decimal)reader["Salary"];
                    else
                        Salary = -1;

                    IsFound = true;
                }
                reader.Close();
            }
            catch { IsFound = false; }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool IsInstructorExist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "select * from Instructors where InstructorID = @InstructorID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InstructorID", ID);

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
            string query = "select * from Instructors where PersonID = @PersonID";
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

        public static int GetPersonIDByInstructorID(int ID)
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "select PersonID from Instructors where InstructorID = @InstructorID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InstructorID", ID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int SelectedID))
                    PersonID = SelectedID;
            }
            catch { PersonID = -1; }
            finally { connection.Close(); }

            return PersonID;
        }

        public static int AddNewInstructor(int PersonID, int SpecializationID, string Certificates, decimal Salary)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "insert into Instructors values (@PersonID, @SpecializationID, @Certificates, @Salary) " +
                           "select SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            if (SpecializationID != -1)
                command.Parameters.AddWithValue("@SpecializationID", SpecializationID);
            else
                command.Parameters.AddWithValue("@SpecializationID", DBNull.Value);

            if (Certificates != string.Empty)
                command.Parameters.AddWithValue("@Certificates", Certificates);
            else
                command.Parameters.AddWithValue("@Certificates", DBNull.Value);

            if (Salary != -1)
                command.Parameters.AddWithValue("@Salary", Salary);
            else
                command.Parameters.AddWithValue("@Salary", DBNull.Value);

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

        public static bool UpdateInstructor(int ID, int PersonID, int SpecializationID, string Certificates, decimal Salary)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "update Instructors set PersonID = @PersonID, SpecializationID = @SpecializationID" +
                           ", Certificates = @Certificates, Salary = @Salary where InstructorID = @InstructorID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            if (SpecializationID != -1)
                command.Parameters.AddWithValue("@SpecializationID", SpecializationID);
            else
                command.Parameters.AddWithValue("@SpecializationID", DBNull.Value);

            if (Certificates != string.Empty)
                command.Parameters.AddWithValue("@Certificates", Certificates);
            else
                command.Parameters.AddWithValue("@Certificates", DBNull.Value);

            if (Salary != -1)
                command.Parameters.AddWithValue("@Salary", Salary);
            else
                command.Parameters.AddWithValue("@Salary", DBNull.Value);

            command.Parameters.AddWithValue("@InstructorID", ID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch { RowsAffected = 0; }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static bool DeleteInstructor(int ID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "delete from Instructors where InstructorID = @InstructorID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InstructorID", ID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch { RowsAffected = 0; }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static DataTable GetAllInstructors()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from Instructors";

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

        public static int CountInstructors()
        {
            int counter = 0;
            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select count(*) from Instructors";

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
