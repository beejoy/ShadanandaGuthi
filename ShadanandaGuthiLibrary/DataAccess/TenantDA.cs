using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ShadanandaGuthiLibrary.Model;

namespace ShadanandaGuthiLibrary.DataAccess
{
    public class TenantDA
    {
        public Tenant GetTenantByID(int tenantID)
        {
            Tenant tenant = new Tenant();

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = "SELECT tenant_id, fullname, address, mobile_no, father FROM Tenant WHERE tenant_id = @TenantID";
                    sqlCommand.Parameters.Add("@TenantID", SqlDbType.Int);
                    sqlCommand.Parameters["@TenantID"].Value = tenantID;
                    sqlCommand.Connection = sqlConn;

                    sqlConn.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();

                    while (dataReader.Read())
                    {
                        tenant.TenantID = (int)dataReader[0];
                        tenant.Fullname = dataReader[1].ToString();
                        tenant.Address = dataReader[2].ToString();
                        tenant.MobileNumber = dataReader[3].ToString();
                        tenant.Father= dataReader[4].ToString();
                    }

                }
                catch (Exception)
                {
                    throw new Exception("Error: GetTenantByID() method couldn't execute properly.");
                }
            }

            return tenant;
        }

        public List<Tenant> GetTenantsByLandID(int landID)
        {
            List<Tenant> tenants = new List<Tenant>();

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "GetTenantsByLandID";
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
                    throw new Exception("Error: GetTenantsByLandID() method couldn't execute properly.");
                }
            }

            return tenants;
        }

        public List<Tenant> GetAllTenants(string filter = "")
        {
            List<Tenant> tenants = new List<Tenant>();

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.Text;
                    if (filter == "")
                    {
                        sqlCommand.CommandText = "SELECT tenant_id, fullname, address, mobile_no, father FROM Tenant ORDER BY fullname, address";
                    }
                    else
                    {
                        sqlCommand.CommandText = $"SELECT tenant_id, fullname, address, mobile_no, father FROM Tenant WHERE fullname LIKE N'{filter}%' ORDER BY fullname, address";
                    }

                    sqlCommand.Connection = sqlConn;

                    sqlConn.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();

                    while (dataReader.Read())
                    {
                        tenants.Add(new Tenant((int)dataReader[0], dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString()));
                    }

                }
                catch (Exception)
                {
                    throw new Exception("Error: GetAllTenants() method couldn't execute properly.");
                }
            }

            return tenants;
        }

        public List<Tenant> GetActiveTenants(string filter = "")
        {
            List<Tenant> tenants = new List<Tenant>();

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.Text;
                    if (filter == "")
                    {
                        sqlCommand.CommandText = "SELECT tenant_id, fullname, address, mobile_no, father FROM ActiveTenantsView ORDER BY fullname, address";
                    }
                    else
                    {
                        sqlCommand.CommandText = $"SELECT tenant_id, fullname, address, mobile_no, father FROM ActiveTenantsView WHERE fullname LIKE N'{filter}%' ORDER BY fullname, address";
                    }

                    sqlCommand.Connection = sqlConn;

                    sqlConn.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();

                    while (dataReader.Read())
                    {
                        tenants.Add(new Tenant((int)dataReader[0], dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString()));
                    }

                }
                catch (Exception)
                {
                    throw new Exception("Error: GetActiveTenants() method couldn't execute properly.");
                }
            }

            return tenants;
        }

        public List<Tenant> GetAllTenantsExcept(int tenantID)
        {
            List<Tenant> tenants = new List<Tenant>();

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "GetAllTenantsExcept";
                    sqlCommand.Parameters.AddWithValue("@TenantID", tenantID);
                    sqlCommand.Connection = sqlConn;

                    sqlConn.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();

                    while (dataReader.Read())
                    {
                        tenants.Add(new Tenant((int)dataReader[0], dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString()));
                    }

                }
                catch (Exception)
                {
                    throw new Exception("Error: GetAllTenantsExcept() method couldn't execute properly.");
                }
            }

            return tenants;
        }

        public bool DeregisterLease(int leaseID)
        {
            bool result = false;

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                string sql = "UPDATE Lease SET is_current = 0 WHERE lease_id = @LeaseID";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConn);
                sqlCommand.Parameters.AddWithValue("@LeaseID", leaseID);

                sqlConn.Open();

                int rowsAffected = sqlCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    result = true;
                }
            }
            
            return result;
        }

        public bool DoesTenantHaveLease(int tenantID)
        {
            bool result = false;

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                string sql = "SELECT land_id FROM Lease WHERE tenant_id = @TenantID";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConn);
                sqlCommand.Parameters.AddWithValue("@TenantID", tenantID);

                sqlConn.Open();
                int rowsAffected = sqlCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    result = true;
                }
            }

            return result;
        }

        public bool SaveTenant(Tenant newTenant)
        {
            bool result = false;

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "SaveTenant";
                    sqlCommand.Connection = sqlConn;

                    sqlCommand.Parameters.AddWithValue("@Fullname", newTenant.Fullname);
                    sqlCommand.Parameters.AddWithValue("@Address", newTenant.Address);
                    sqlCommand.Parameters.AddWithValue("@MobileNumber", newTenant.MobileNumber);
                    sqlCommand.Parameters.AddWithValue("@Father", newTenant.Father);

                    sqlConn.Open();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        result = true;

                }
                catch (Exception)
                {
                    throw new Exception("Error: SaveTenant() method couldn't execute properly.");
                }
            }

            return result;
        }

        public bool UpdateTenant(Tenant tenant)
        {
            bool result = false;

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "UpdateTenant";
                    sqlCommand.Connection = sqlConn;

                    sqlCommand.Parameters.AddWithValue("@TenantID", tenant.TenantID);
                    sqlCommand.Parameters.AddWithValue("@Fullname", tenant.Fullname);
                    sqlCommand.Parameters.AddWithValue("@Address", tenant.Address);
                    sqlCommand.Parameters.AddWithValue("@MobileNumber", tenant.MobileNumber);
                    sqlCommand.Parameters.AddWithValue("@Father", tenant.Father);

                    sqlConn.Open();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        result = true;

                }
                catch (Exception)
                {
                    throw new Exception("Error: UpdateTenant() method couldn't execute properly.");
                }
            }

            return result;
        }

        public bool DeleteTenant(Tenant tenant)
        {
            bool result = false;

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "DeleteTenant";
                sqlCommand.Parameters.AddWithValue("@TenantID", tenant.TenantID);

                sqlCommand.Connection = sqlConn;

                sqlConn.Open();

                int rowsAffected = sqlCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    result = true;
                }
            }

            return result;
        }

        public bool IsDuplicateTenant(Tenant tenantToCheck)
        {
            bool result = false;

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                try
                {
                    string sql = "SELECT tenant_id, fullname, address, father FROM Tenant WHERE fullname = @FullName AND address = @Address AND father = @Father";
                    SqlCommand sqlCommand = new SqlCommand(sql, sqlConn);
                    sqlCommand.Parameters.Add("@FullName", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@FullName"].Value = tenantToCheck.Fullname;

                    sqlCommand.Parameters.Add("@Address", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@Address"].Value = tenantToCheck.Address;

                    sqlCommand.Parameters.Add("@Father", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@Father"].Value = tenantToCheck.Father;

                    sqlConn.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();

                    if (dataReader.HasRows)
                        result = true;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return result;
        }
    }
}
