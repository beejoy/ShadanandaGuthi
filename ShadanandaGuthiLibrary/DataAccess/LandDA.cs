using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ShadanandaGuthiLibrary.Model;

namespace ShadanandaGuthiLibrary.DataAccess
{
    public class LandDA
    {
        public List<Land> GetLands()
        {
            List<Land> lands = new List<Land>();

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "GetAllLands";
                    sqlCommand.Connection = sqlConn;

                    sqlConn.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();

                    while (dataReader.Read())
                    {
                        lands.Add(new Land((int)dataReader[0], new Location((int)dataReader[1], dataReader[2].ToString(), dataReader[3].ToString()), dataReader[4].ToString(), dataReader[5].ToString()));
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Error : LandDA.GetLands() method.");
                }
            }

            return lands;
        }

        public List<Land> GetLandsByLocation(Location location)
        {
            List<Land> lands = new List<Land>();

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "GetLandsByLocationID";
                    sqlCommand.Parameters.AddWithValue("@LocationID", location.LocationID);
                    sqlCommand.Connection = sqlConn;

                    sqlConn.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();

                    while (dataReader.Read())
                    {
                        lands.Add(new Land((int)dataReader[0], new Location((int)dataReader[1], dataReader[2].ToString(), dataReader[3].ToString()), dataReader[4].ToString(), dataReader[5].ToString()));
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Error : LandDA.GetLandsByLocation() method.");
                }
            }

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
