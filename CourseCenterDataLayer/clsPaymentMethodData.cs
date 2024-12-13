using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CourseCenterDataLayer
{
    public class clsPaymentMethodData
    {
        public static bool FindPaymentMethodByID(int ID, ref string MethodName, ref string Description, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from PaymentMethods where PaymentMethodID = @PaymentMethodID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentMethodID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    MethodName = (string)reader["MethodName"];

                    if (reader["Description"] != DBNull.Value)
                        Description = (string)reader["Description"];
                    else
                        Description = string.Empty;

                    IsActive = (bool)reader["IsActive"];

                    IsFound = true;
                }
                reader.Close();
            }
            catch { IsFound = false; }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool FindPaymentMethodByName(ref int ID, string MethodName, ref string Description, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from PaymentMethods where MethodName = @MethodName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MethodName", MethodName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ID = (int)reader["PaymentMethodID"];

                    if (reader["Description"] != DBNull.Value)
                        Description = (string)reader["Description"];
                    else
                        Description = string.Empty;

                    IsActive = (bool)reader["IsActive"];

                    IsFound = true;
                }
                reader.Close();
            }
            catch { IsFound = false; }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool IsPaymentMethodExistByID(int ID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select count(1) from PaymentMethods where PaymentMethodID = @PaymentMethodID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentMethodID", ID);

            try
            {
                connection.Open();
                int count = (int)command.ExecuteScalar();

                IsFound = count > 0;
            }
            catch { IsFound = false; }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool AddNewPaymentMethod(int ID, string MethodName, string Description, bool IsActive)
        {
            byte RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "insert into PaymentMethods values (@PaymentMethodID, @MethodName, @Description, @IsActive)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentMethodID", ID);
            command.Parameters.AddWithValue("@MethodName", MethodName);

            if (Description != string.Empty)
                command.Parameters.AddWithValue("@Description", Description);
            else
                command.Parameters.AddWithValue("@Description", DBNull.Value);

            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();
                RowsAffected = (byte)command.ExecuteNonQuery();
            }
            catch { RowsAffected = 0; }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static bool UpdatePaymentMethod(int ID, string MethodName, string Description, bool IsActive)
        {
            byte RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "update PaymentMethods " +
                   "set PaymentMethodID = @PaymentMethodID, MethodName = @MethodName, Description = @Description, IsActive = @IsActive " +
                   "where PaymentMethodID = @PaymentMethodID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentMethodID", ID);
            command.Parameters.AddWithValue("@MethodName", MethodName);

            if (Description != string.Empty)
                command.Parameters.AddWithValue("@Description", Description);
            else
                command.Parameters.AddWithValue("@Description", DBNull.Value);

            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();
                RowsAffected = (byte)command.ExecuteNonQuery();
            }
            catch { RowsAffected = 0; }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static bool DeletePaymentMethod(int ID)
        {
            byte RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "Delete from PaymentMethods where PaymentMethodID = @PaymentMethodID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentMethodID", ID);

            try
            {
                connection.Open();
                RowsAffected = (byte)command.ExecuteNonQuery();
            }
            catch { RowsAffected = 0; }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static DataTable GetAllPaymentMethods()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select PaymentMethodID, MethodName, Description, IsActive from PaymentMethods";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);
            }
            catch { }
            finally { connection.Close(); }

            return dt;
        }

        public static DataTable GetActivePaymentMethods()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from PaymentMethods where IsActive = 1";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);
            }
            catch { }
            finally { connection.Close(); }

            return dt;
        }

    }
}
