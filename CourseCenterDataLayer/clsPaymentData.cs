using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCenterDataLayer
{
    public class clsPaymentData
    {
        public static bool FindPaymentByID(int ID, ref int StudentID, ref int EnrollmentID, ref decimal OriginalCost
            , ref byte DiscountPercentage, ref decimal CostAfterDiscount, ref decimal ActualPayAmount
            , ref DateTime LastUpdatedDate, ref int PaymentMethodID, ref bool IsPaid)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from Payments where PaymentID = @PaymentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    StudentID = (int)reader["StudentID"];
                    EnrollmentID = (int)reader["EnrollmentID"];
                    OriginalCost = (decimal)reader["OriginalCost"];
                    DiscountPercentage = (byte)reader["DiscountPercentage"];
                    CostAfterDiscount = (decimal)reader["CostAfterDiscount"];
                    ActualPayAmount = (decimal)reader["ActualPayAmount"];
                    LastUpdatedDate = (DateTime)reader["LastUpdatedDate"];
                    IsPaid = (bool)reader["IsPaid"];

                    if (reader["PaymentMethodID"] != DBNull.Value)
                        PaymentMethodID = (int)reader["PaymentMethodID"];
                    else
                        PaymentMethodID = -1;

                    IsFound = true;
                }

                reader.Close();
            }
            catch { IsFound = false; }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool FindPaymentByEnrollmentID(ref int ID, ref int StudentID, int EnrollmentID, ref decimal OriginalCost
            , ref byte DiscountPercentage, ref decimal CostAfterDiscount, ref decimal ActualPayAmount
            , ref DateTime LastUpdatedDate, ref int PaymentMethodID, ref bool IsPaid)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from Payments where EnrollmentID = @EnrollmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EnrollmentID", EnrollmentID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ID = (int)reader["PaymentID"];
                    StudentID = (int)reader["StudentID"];
                    OriginalCost = (decimal)reader["OriginalCost"];
                    DiscountPercentage = (byte)reader["DiscountPercentage"];
                    CostAfterDiscount = (decimal)reader["CostAfterDiscount"];
                    ActualPayAmount = (decimal)reader["ActualPayAmount"];
                    LastUpdatedDate = (DateTime)reader["LastUpdatedDate"];
                    IsPaid = (bool)reader["IsPaid"];

                    if (reader["PaymentMethodID"] != DBNull.Value)
                        PaymentMethodID = (int)reader["PaymentMethodID"];
                    else
                        PaymentMethodID = -1;

                    IsFound = true;
                }
                reader.Close();
            }
            catch { IsFound = false; }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool IsPaymentExist(int ID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from Payments where PaymentID = @PaymentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", ID);

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

        public static int AddNewPayment(int StudentID, int EnrollmentID, decimal OriginalCost, byte DiscountPercentage
            , decimal ActualPayAmount, int PaymentMethodID)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "insert into Payments(StudentID, EnrollmentID, OriginalCost, DiscountPercentage, ActualPayAmount, PaymentMethodID) " +
                           "values (@StudentID, @EnrollmentID, @OriginalCost, @DiscountPercentage, @ActualPayAmount, @PaymentMethodID) " +
                           "select SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@StudentID", StudentID);
            command.Parameters.AddWithValue("@EnrollmentID", EnrollmentID);
            command.Parameters.AddWithValue("@OriginalCost", OriginalCost);
            command.Parameters.AddWithValue("@DiscountPercentage", DiscountPercentage);
            command.Parameters.AddWithValue("@ActualPayAmount", ActualPayAmount);

            if (PaymentMethodID != -1)
                command.Parameters.AddWithValue("@PaymentMethodID", PaymentMethodID);
            else
                command.Parameters.AddWithValue("@PaymentMethodID", DBNull.Value);

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

        public static bool UpdatePayment(int ID, int StudentID, int EnrollmentID, decimal OriginalCost
            , byte DiscountPercentage, decimal ActualPayAmount, int PaymentMethodID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "update Payments set StudentID = @StudentID, EnrollmentID = @EnrollmentID, OriginalCost = @OriginalCost " +
                ", DiscountPercentage = @DiscountPercentage, ActualPayAmount = @ActualPayAmount" +
                ", PaymentMethodID = @PaymentMethodID where PaymentID = @PaymentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@StudentID", StudentID);
            command.Parameters.AddWithValue("@EnrollmentID", EnrollmentID);
            command.Parameters.AddWithValue("@OriginalCost", OriginalCost);
            command.Parameters.AddWithValue("@DiscountPercentage", DiscountPercentage);
            command.Parameters.AddWithValue("@ActualPayAmount", ActualPayAmount);

            if (PaymentMethodID != -1)
                command.Parameters.AddWithValue("@PaymentMethodID", PaymentMethodID);
            else
                command.Parameters.AddWithValue("@PaymentMethodID", DBNull.Value);

            command.Parameters.AddWithValue("@PaymentID", ID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch { RowsAffected = 0; }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static bool DeletePayment(int ID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "Delete from Payments where PaymentID = @PaymentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", ID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch { RowsAffected = 0; }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        public static bool DeletePaymentByEnrollmentID(int EnrollmentID)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);
            string query = "Delete from Payments where EnrollmentID = @EnrollmentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EnrollmentID", EnrollmentID);
            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch { RowsAffected = 0; }
            finally { connection.Close(); }
            return RowsAffected > 0;
        }

        public static bool IsPaidAnyAmount(int EnrollmentID)
        {
            int Amount = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select ActualPayAmount from Payments where EnrollmentID = @EnrollmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EnrollmentID", EnrollmentID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int NewResult))
                    Amount = NewResult;
            }
            catch { }
            finally { connection.Close(); }

            return Amount > 0;
        }

        public static bool IsPaidFullAmount(int PaymentID)
        {
            bool IsPaid = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select IsPaid from Payments where PaymentID = @PaymentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && bool.TryParse(result.ToString(), out bool NewResult))
                    IsPaid = NewResult;
            }
            catch { }
            finally { connection.Close(); }

            return IsPaid;
        }

        public static bool IsEnrolmentPaidFullAmount(int EnrollmentID)
        {
            bool IsPaid = false;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select IsPaid from Payments where EnrollmentID = @EnrollmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EnrollmentID", EnrollmentID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && bool.TryParse(result.ToString(), out bool NewResult))
                    IsPaid = NewResult;
            }
            catch { }
            finally { connection.Close(); }

            return IsPaid;
        }

        public static DataTable GetAllPayments()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select * from Payments";

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

        public static int CountUnPaidPayments()
        {
            int counter = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select count(*) from Payments where IsPaid = 0";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                counter = (int)command.ExecuteScalar();
            }
            catch { counter = -1; }
            finally { connection.Close(); }

            return counter;
        }

        public static decimal GetTotalPayments()
        {
            decimal TotalPayments = 0;

            SqlConnection connection = new SqlConnection(clsCourseCenterDataSettings.connectionString);

            string query = "select sum(ActualPayAmount) from Payments where ActualPayAmount > 0 ";

            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && decimal.TryParse(result.ToString(), out decimal Total))
                    TotalPayments = Total;
            }
            catch { }
            finally { connection.Close(); }

            return TotalPayments;
        }

    }

}
