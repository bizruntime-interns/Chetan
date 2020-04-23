using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    public class Faculty
    {
        public string FirstName;
        private string lastname;
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string DOJ;
       // public string subject;
       public void PrintFullName()
        {
            Console.WriteLine("Firstname: " + FirstName + " LastName: " + LastName);
        }
    }

    public class FullTime:Faculty
    {
        public float MonthlySalary;
    }

    public class partTime:Faculty
    {
        public float DaySalary;
    }
    class Program
    {
        static void Main(string[] args)
        {
            FullTime f = new FullTime();
            f.FirstName = "Suhas";
            f.LastName = "Mayya";
            f.DOJ = "1-01-2020";
            f.MonthlySalary = 80000;
            f.PrintFullName();
            Console.ReadKey();
        }
    }
}
