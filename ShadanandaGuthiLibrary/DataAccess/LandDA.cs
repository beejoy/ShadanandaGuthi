using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShadanandaGuthiLibrary.Model;

namespace ShadanandaGuthiLibrary.DataAccess
{
    public class LandDA
    {
        public List<Land> GetLands()
        {
            //List<Location> locations = new List<Location>();

            //string sql = "SELECT location_id, location, local_level FROM Location ORDER BY location";
            //SqlCommand sqlCommand = new SqlCommand(sql, sqlConn);
            //sqlConn.Open();
            //SqlDataReader dataReader = sqlCommand.ExecuteReader();

            //while (dataReader.Read())
            //{
            //    locations.Add(new Location((int)dataReader[0], dataReader[1].ToString(), dataReader[2].ToString()));
            //}
            //sqlConn.Close();

            //return locations;
            List<Land> lands = new List<Land>();

            //string sql = "SELECT land_id, location_id, plot_no, land_area FROM Land";

            return lands;
        }

        /// <summary>
        /// Saves the record for land object passed as the parameter.
        /// </summary>
        /// <param name="newLand"></param>
        /// <returns>TRUE for success, FALSE otherwise</returns>
        public bool SaveLand(Land newLand)
        {
            bool result = false;

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "SaveLand";
                    sqlCommand.Connection = sqlConn;

                    sqlCommand.Parameters.AddWithValue("@LocationID", newLand.LandLocation.LocationID);
                    sqlCommand.Parameters.AddWithValue("@PlotNumber", newLand.PlotNumber);
                    sqlCommand.Parameters.AddWithValue("@LandArea", newLand.LandArea);

                    sqlConn.Open();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        result = true;

                }
                catch (Exception)
                {
                    throw new Exception("Error: SaveLocation() method couldn't execute properly.");
                }
            }

            return result;
        }

        /// <summary>
        /// Checks in the database if there is any matching record for the land object passed as the parameter.
        /// </summary>
        /// <param name="landToCheck"></param>
        /// <returns>Returns TRUE if there is already a record in the database, otherwirse returns FALSE.</returns>
        public bool IsDuplicateLand(Land landToCheck)
        {
            bool result = false;

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                try
                {
                    string sql = "SELECT land_id, location_id, plot_no FROM Land WHERE location_id = @locationID AND plot_no = @plotNumber";
                    SqlCommand sqlCommand = new SqlCommand(sql, sqlConn);
                    sqlCommand.Parameters.Add("@locationID", SqlDbType.Int);
                    sqlCommand.Parameters["@locationID"].Value = landToCheck.LandLocation.LocationID;

                    sqlCommand.Parameters.Add("@plotNumber", SqlDbType.NVarChar);
                    sqlCommand.Parameters["@plotNumber"].Value = landToCheck.PlotNumber;

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
