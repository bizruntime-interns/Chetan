using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_CRUD_OPerations
{
    class Program
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            new Program().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                try 
                {
                    // Creating Connection  
                    con = new SqlConnection("data source=.; database=student; integrated security=SSPI");
                }
                catch(Exception e)
                {
                    log.Error(e);
                }


                // writing sql query
                SqlCommand cm = new SqlCommand("Alter table student add Place nvarchar(50)", con);
                // SqlCommand cm = new SqlCommand("update student set id='104' where name='Raju'",con);
                // SqlCommand cm = new SqlCommand("insert into student(id, name, email, join_date)values('102', 'Raju', 'Raju66@example.com', '1/02/2006')", con);  

                // Opening Connection  
                con.Open();

                try
                {
                    // Executing the SQL query  
                    cm.ExecuteNonQuery();

                    // Displaying a message  
                    log.Info("Operation Successfully completed");
                }
                catch(SqlException e)
                {
                    log.Error("Error Generated:" + e.ToString());
                }
            }

            catch (InvalidOperationException e)
            {
                log.Error("OOPs, something went wrong." + e);
            }

            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}
