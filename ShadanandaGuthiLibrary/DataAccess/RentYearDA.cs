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
    }
}
