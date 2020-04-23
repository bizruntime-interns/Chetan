using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>()
            {
                new Student(){Id= 1, Name = "Abhi", AddressId = 1},
                new Student(){Id= 2, Name = "Bharat", AddressId = 0},
                new Student(){Id= 3, Name = "Dixit", AddressId = 5},
                new Student(){Id= 4, Name = "Arun", AddressId = 0},
                new Student(){Id= 5, Name = "Daya", AddressId = 2},
            };

            List<Address> Addresses = new List<Address>()
            {
                new Address(){Id=1,AddressLine="Line 1"},
                new Address(){Id=2,AddressLine="Line 2"},
                new Address(){Id=3,AddressLine="Line 3"},
                new Address(){Id=4,AddressLine="Line 4"},
                new Address(){Id=5,AddressLine="Line 5"},
            };

            var JoinQuery = (from student in Students
                             join address in Addresses
                             on student.AddressId equals address.Id
                             select new
                             {
                                 StudentName = student.Name,
                                 Line = address.AddressLine
                             }).ToList();

            log.Info(JoinQuery);

            Console.ReadKey();
        }
    }
}
