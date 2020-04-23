using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    interface IName
    {
        void GetName(string x);
        void Profession(string y);
    }

    interface ILocation
    {
        void GetLocation(string x);
    }

    interface IAge
    {
        void GetAge(int x);
    }

    class User : IName, ILocation, IAge
    {
        public void GetName(string a)
        {
            Console.WriteLine("Name: {0}", a);
        }
        //public void Profession(string a)
        //{
        //    Console.WriteLine("Profession: {0}", a);
        //}
        public void GetLocation(string a)
        {
            Console.WriteLine("Location: {0}", a);
        }
        public void GetAge(int a)
        {
            Console.WriteLine("Age: {0}", a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.GetName("Suresh Dasari");
            //u.Profession("Businessman");
            u.GetLocation("Hyderabad");
            u.GetAge(32);
            Console.ReadLine();

        }

    }
}
