using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace LoginPage.Models
{
    public class db
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RKT2BEC;Initial Catalog=Login;Integrated Security=True");

        public int RegistrationCheck(Registration reg)
        {
            SqlCommand com = new SqlCommand("Sp_Reg", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Id", reg.Id);
            com.Parameters.AddWithValue("@Username", reg.Username);
            com.Parameters.AddWithValue("@Email", reg.Email);
            com.Parameters.AddWithValue("@Password", reg.Password);
            SqlParameter oblogin = new SqlParameter();
            //oblogin.Direction = ParameterDirection.Output;
            com.Parameters.Add(oblogin);
            con.Open();
            com.ExecuteNonQuery();
            int res = Convert.ToInt32(oblogin.Value);
            con.Close();
            return res;
        }
    }
}
