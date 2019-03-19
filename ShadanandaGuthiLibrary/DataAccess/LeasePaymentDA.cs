using System;
using System.Data;
using System.Data.SqlClient;
using ShadanandaGuthiLibrary.Model;

namespace ShadanandaGuthiLibrary.DataAccess
{
    public class LeasePaymentDA
    {
        public DataTable GetLeasePaymentDetailsByTenantIDYearID(int tenantID, int yearID)
        {
            DataTable paymentDetailsDT = new DataTable();

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "GetPaymentDetailsByTenantIDYearID";
                    sqlCommand.Parameters.AddWithValue("@TenantID", tenantID);
                    sqlCommand.Parameters.AddWithValue("@YearID", yearID);
                    sqlCommand.Connection = sqlConn;

                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                    sqlConn.Open();
                    adapter.Fill(paymentDetailsDT);

                }
                catch (Exception)
                {
                    throw new Exception("Error : LeasePaymentDA.GetPaymentDetailsByTenantIDYearID() method.");
                }
            }

            return paymentDetailsDT;
        }

        public DataTable GetAllPaymentDetailsByRentYearID(int yearID)
        {
            DataTable paymentDetailsDT = new DataTable();

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "GetAllPaymentDetailsByRentYearID";
                    sqlCommand.Parameters.AddWithValue("@YearID", yearID);
                    sqlCommand.Connection = sqlConn;

                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                    sqlConn.Open();
                    adapter.Fill(paymentDetailsDT);

                }
                catch (Exception)
                {
                    throw new Exception("Error : LeasePaymentDA.GetAllPaymentDetailsByRentYearID() method.");
                }
            }

            return paymentDetailsDT;
        }

        public bool IsDuplicatePayment(int leaseID, int yearID)
        {
            bool result = false;

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                string sql = "SELECT payment_id, payment_date FROM LeasePayment WHERE lease_id = @LeaseID AND year_id = @YearID";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConn);

                sqlCommand.Parameters.AddWithValue("@LeaseID", leaseID);
                sqlCommand.Parameters.AddWithValue("@YearID", yearID);

                sqlConn.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.HasRows)
                    result = true;

            }

            return result;
        }

        public bool SaveLeasePayment(LeasePayment leasePayment)
        {
            bool result = false;

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "SaveLeasePayment";
                    sqlCommand.Connection = sqlConn;

                    sqlCommand.Parameters.AddWithValue("@LeaseID", leasePayment.LeaseID);
                    sqlCommand.Parameters.AddWithValue("@YearID", leasePayment.YearID);
                    sqlCommand.Parameters.AddWithValue("@LeaseRent", leasePayment.LeaseRent);
                    sqlCommand.Parameters.AddWithValue("@PaymentDate", leasePayment.PaymentDate);
                    sqlCommand.Parameters.AddWithValue("@ReceiptNumber", leasePayment.ReceiptNumber);
                    sqlCommand.Parameters.AddWithValue("@Remarks", leasePayment.Remarks);

                    sqlConn.Open();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        result = true;

                }
                catch (Exception)
                {
                    throw new Exception("Error: SaveLeasePayment() method couldn't execute properly.");
                }
            }

            return result;
        }
    }
}
