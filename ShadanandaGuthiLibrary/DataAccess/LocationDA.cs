using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ShadanandaGuthiLibrary.Model;

namespace ShadanandaGuthiLibrary.DataAccess
{
    public class LocationDA
    {
        SqlConnection sqlConn;

        #region Constructor and Destructor
        public LocationDA()
        {
            sqlConn = new SqlConnection(GlobalConfig.ConnString());
        }
        
        ~LocationDA()
        {
            if (sqlConn.State == ConnectionState.Open)
                sqlConn.Close();

            sqlConn = null;
        }
        #endregion

        public DataTable GetAllLocations()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT location_id, location, local_level FROM Location ORDER BY location";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConn);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                sqlConn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: GetAllLocations() method couldn't execute properly.");
            }
            finally
            {
                sqlConn.Close();
            }

            return dt;
        }

        public List<Location> GetLocations()
        {
            List<Location> locations = new List<Location>();

            string sql = "SELECT location_id, location, local_level FROM Location ORDER BY location";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConn);
            sqlConn.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            while(dataReader.Read())
            {
                locations.Add(new Location((int)dataReader[0], dataReader[1].ToString(), dataReader[2].ToString()));
            }
            sqlConn.Close();

            return locations;
        }

        public List<Location> GetLocationsHavingLands()
        {
            List<Location> locations = new List<Location>();

            string sql = "SELECT DISTINCT Location.location_id, location, local_level FROM Location INNER JOIN Land ON Location.location_id = Land.location_id ORDER BY location";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConn);
            sqlConn.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                locations.Add(new Location((int)dataReader[0], dataReader[1].ToString(), dataReader[2].ToString()));
            }
            sqlConn.Close();

            return locations;
        }

        public bool IsDuplicateLocation (Location locationToCheck)
        {
            bool result = false;

            try
            {
                string sql = "SELECT location_id, location FROM Location WHERE location = @previousVDC";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConn);
                sqlCommand.Parameters.Add("@previousVDC", SqlDbType.NVarChar);
                sqlCommand.Parameters["@previousVDC"].Value = locationToCheck.LocationPreviousVDC;

                sqlConn.Open();
                SqlDataReader dataReader= sqlCommand.ExecuteReader();

                if (dataReader.HasRows)
                    result = true;
            }
            catch (Exception)
            {
                throw new Exception("Error: IsDuplicateLocation() method couldn't execute properly.");
            }
            finally
            {
                sqlConn.Close();
            }

            return result;
        }

        public bool SaveLocation(Location newLocation)
        {
            bool result = false;

            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SaveLocation";
                sqlCommand.Connection = sqlConn;

                sqlCommand.Parameters.AddWithValue("@Location", newLocation.LocationPreviousVDC);
                sqlCommand.Parameters.AddWithValue("@LocalLevel", newLocation.LocationNewLevel);

                sqlConn.Open();
                int rowsAffected = sqlCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                    result = true;

            }
            catch (Exception)
            {
                throw new Exception("Error: SaveLocation() method couldn't execute properly.");
            }
            finally
            {
                sqlConn.Close();
            }

            return result;
        }
    }
}
