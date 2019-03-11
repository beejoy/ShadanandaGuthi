using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShadanandaGuthiLibrary.Model;
using System.Data;
using System.Data.SqlClient;

namespace ShadanandaGuthiLibrary.DataAccess
{
    public class LeaseDA
    {
        // TODO - To be implemented GetCurrentTenantsByLandID
        public List<Tenant> GetCurrentTenantsByLandID(int landID)
        {
            List<Tenant> tenants = new List<Tenant>();

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "GetCurrentTenantsByLandID";
                    sqlCommand.Connection = sqlConn;

                    sqlCommand.Parameters.AddWithValue("@LandID", landID);

                    sqlConn.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();

                    while (dataReader.Read())
                    {
                        tenants.Add(new Tenant((int)dataReader[0], dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString()));
                    }

                }
                catch (Exception)
                {
                    throw new Exception("Error: GetCurrent" +
                        "TenantsByLandID() method couldn't execute properly.");
                }
            }

            return tenants;
        }

        public DataTable GetLeaseByLandID(int landID, bool activeLeaseOnly = false)
        {
            DataTable leasesDT = new DataTable();

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "GetLeaseByLandID";
                    sqlCommand.Parameters.AddWithValue("@LandID", landID);
                    sqlCommand.Parameters.AddWithValue("@IsCurrent", activeLeaseOnly ? 1 : 0);
                    sqlCommand.Connection = sqlConn;

                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                    sqlConn.Open();
                    adapter.Fill(leasesDT);

                }
                catch (Exception)
                {
                    throw new Exception("Error : LeaseDA.GetLeaseByLandID() method.");
                }
            }

            return leasesDT;
        }

        public DataTable GetLeaseByTenantID(int tenantID)
        {
            DataTable leasesDT = new DataTable();

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "GetLeaseByTenantID";
                    sqlCommand.Parameters.AddWithValue("@TenantID", tenantID);
                    sqlCommand.Connection = sqlConn;

                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                    sqlConn.Open();
                    adapter.Fill(leasesDT);

                }
                catch (Exception)
                {
                    throw new Exception("Error : LeaseDA.GetLeaseByTenantID() method.");
                }
            }

            return leasesDT;
        }

        public bool IsDuplicateLease(Lease leaseToCheck)
        {
            bool result = false;

            return result;
        }

        public bool SaveLease(Lease newLease)
        {
            bool result = false;

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "SaveLease";
                    sqlCommand.Connection = sqlConn;

                    sqlCommand.Parameters.AddWithValue("@LandID", newLease.LeaseLand.LandID);
                    sqlCommand.Parameters.AddWithValue("@TenantID", newLease.LeaseTenant.TenantID);
                    sqlCommand.Parameters.AddWithValue("@LeaseFrom", newLease.LeaseFrom);
                    sqlCommand.Parameters.AddWithValue("@AnnualRent", newLease.AnnualRent);
                    sqlCommand.Parameters.AddWithValue("@Remarks", newLease.Remarks);

                    sqlConn.Open();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        result = true;

                }
                catch (Exception)
                {
                    throw new Exception("Error: SaveLease() method couldn't execute properly.");
                }
            }

            return result;
        }

        public bool TransferLease(Tenant currentTenant, Lease transferLease)
        {
            bool result = false;

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "TransferLease";
                    sqlCommand.Connection = sqlConn;

                    sqlCommand.Parameters.AddWithValue("@LandID", transferLease.LeaseLand.LandID);
                    sqlCommand.Parameters.AddWithValue("@CurrentTenantID", currentTenant.TenantID);
                    sqlCommand.Parameters.AddWithValue("@NewTenantID", transferLease.LeaseTenant.TenantID);
                    sqlCommand.Parameters.AddWithValue("@LeaseFrom", transferLease.LeaseFrom);
                    sqlCommand.Parameters.AddWithValue("@AnnualRent", transferLease.AnnualRent);
                    sqlCommand.Parameters.AddWithValue("@Remarks", transferLease.Remarks);

                    sqlConn.Open();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        result = true;

                }
                catch (Exception)
                {
                    throw new Exception("Error: TransferLease() method couldn't execute properly.");
                }
            }

            return result;
        }
    }
}
