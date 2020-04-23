using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Login.Models
{
    public class db
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RKT2BEC;Initial Catalog=Login;Integrated Security=True");
        public int LoginCheck(Ad_login user)
        {
            SqlCommand com = new SqlCommand("Sp_Login",con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Username", user.Username);
            com.Parameters.AddWithValue("@Password", user.Password);
            SqlParameter oblogin = new SqlParameter();
            oblogin.ParameterName = "@Isvalid";
            oblogin.SqlDbType = SqlDbType.Bit;
            oblogin.Direction = ParameterDirection.Output;
            com.Parameters.Add(oblogin);
            con.Open();
            com.ExecuteNonQuery();
            int res = Convert.ToInt32(oblogin.Value);
            con.Close();
            return res;

        }
    }
}
