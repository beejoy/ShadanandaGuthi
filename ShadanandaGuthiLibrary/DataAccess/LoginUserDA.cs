using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShadanandaGuthiLibrary.Model;

namespace ShadanandaGuthiLibrary.DataAccess
{
    public class LoginUserDA
    {
        public bool VerifyLogin(LoginUser loginUser)
        {
            bool result = false;

            using (SqlConnection sqlConn = new SqlConnection(GlobalConfig.ConnString()))
            {
                string sql = "SELECT user_id, fullname FROM LoginUser WHERE username = @UserName AND  password = @Password";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConn);
                sqlCommand.Parameters.AddWithValue("UserName", loginUser.Username);
                sqlCommand.Parameters.AddWithValue("@Password", loginUser.Password);

                sqlConn.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.HasRows)
                {
                    loginUser.UserID = int.Parse(dataReader[0].ToString());
                    result = true;
                }
            }

            return result;
        }
    }
}
