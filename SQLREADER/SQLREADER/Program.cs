using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLREADER
{
    class Program
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("data source=.; database=student; integrated security=SSPI");

            try
            {
                con.Open();
                SqlCommand reader = new SqlCommand("select * from student", con);
                SqlDataReader rdr = reader.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0].ToString() + " " + rdr[1].ToString() + " " + rdr[2].ToString());
                }
            }
            catch (SqlException e)
            {
                log.Error(e.ToString());
            }
            finally
            {               
                con.Close();
            }
            
        }
    }
}
