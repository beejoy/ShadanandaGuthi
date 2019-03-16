using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ShadanandaGuthiLibrary.Model;

namespace ShadanandaGuthiLibrary.DataAccess
{
    public class RentYearDA
    {
        public List<RentYear> GetAllRentYears()
        {
            List<RentYear> rentYears = new List<RentYear>();

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = "SELECT year_id, rent_year, is_current_year FROM RentYear ORDER BY rent_year DESC";
                    sqlCommand.Connection = sqlConn;

                    sqlConn.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();

                    while (dataReader.Read())
                    {
                        rentYears.Add(new RentYear((int)dataReader[0], dataReader[1].ToString(), dataReader[2].ToString()=="1"?true:false));
                    }

                }
                catch (Exception)
                {
                    throw new Exception("Error: GetAllRentYears() method couldn't execute properly.");
                }
            }

            return rentYears;
        }

        public bool SaveRentYear(RentYear newRentYear)
        {
            bool result = false;

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "SaveRentYear";
                    sqlCommand.Connection = sqlConn;

                    sqlCommand.Parameters.AddWithValue("@RentYear", newRentYear.TheRentYear);

                    sqlConn.Open();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        result = true;

                }
                catch (Exception)
                {
                    throw new Exception("Error: SaveRentYear() method couldn't execute properly.");
                }
            }
            return result;
        }

        public bool DeleteRentYear(RentYear rentYear)
        {
            bool result = false;

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "DELETE FROM RentYear WHERE year_id = @YearID";
                sqlCommand.Parameters.AddWithValue("@YearID", rentYear.YearID);

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

        public bool DoesRentYearHaveLeasePayment(RentYear rentYear)
        {
            bool result = false;

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                string sql = "SELECT year_id FROM LeasePayment WHERE year_id = @YearID";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConn);
                sqlCommand.Parameters.AddWithValue("@YearID", rentYear.YearID);

                sqlConn.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.HasRows)
                {
                    result = true;
                }
            }

            return result;
        }

    }
}
