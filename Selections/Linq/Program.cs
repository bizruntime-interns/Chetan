using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            //OrderByOpertions
            OrderByOperation O = new OrderByOperation();
            O.OrderBy();

            //ThenByOperations
            List<Student> students = new List<Student>
            {
                new Student(){Id=1,FName="Amit",LName="Singh",Email="amit11@gmail.com"},
                new Student(){Id=1,FName="Arjun",LName="Patel",Email="Arjun@gmail.com"},
                new Student(){Id=1,FName="Arjun",LName="Nata",Email="Arjun@gmail.com"},
                new Student(){Id=1,FName="Arjun",LName="Nata",Email="Arjun@gmail.com"},
                new Student(){Id=1,FName="Amit",LName="Rao",Email="Arjun@gmail.com"}
            };

            List<Student> query = students.OrderBy(stu => stu.FName).ThenBy(stu => stu.LName).ToList();

            foreach (var obj in query)
            {
                Console.WriteLine($"{ obj.FName} { obj.LName}");
            }
            Console.ReadKey();
        }
    }
}
