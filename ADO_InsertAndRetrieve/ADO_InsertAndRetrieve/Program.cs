using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_InsertAndRetrieve
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("data source=.; database=student; integrated security=SSPI");
            SqlCommand cmd = new SqlCommand("Retrieve_Record_Proc", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add(new SqlParameter("@id", "120"));
                //cmd.Parameters.Add(new SqlParameter("@name", "Aditya N"));
                //cmd.Parameters.Add(new SqlParameter("@email", "Aditya12@example.com"));
                //cmd.Parameters.Add(new SqlParameter("@join_date", "24 August 2004"));
                //cmd.Parameters.Add(new SqlParameter("@Place", "Bangalore"));
                //int i = cmd.ExecuteNonQuery();
                //if (i > 0)
                //{
                //    Console.WriteLine("Records Inserted Successfully.");
                //}
                
                cmd.Parameters.Add(new SqlParameter("@id", "101"));
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(" name : " + dr[1].ToString());
                    Console.WriteLine(" email : " + dr[2].ToString());
                    Console.WriteLine("join_date : " + dr[3].ToString());
                    Console.WriteLine("Place : " + dr[4].ToString());
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}
