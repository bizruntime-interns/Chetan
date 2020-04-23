using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var Fruits = new List<string>();
            Fruits.Add("Apple");
            Fruits.Add("Mango");
            Fruits.Add("Chickoo");
            Fruits.Add("Bannana");

            foreach (string fruit in Fruits)
            {
                Console.WriteLine(fruit + " ");
            }

            var Cars = new List<string>() { "Ferrai", "Mustang", "Audi R8", "Land Rover" };
            Cars.RemoveAt(3);
            //Cars.Remove("Mustang");
            foreach (string car in Cars)
            {
                Console.WriteLine(car + " ");
            }
            Console.ReadKey();
        }
    }
}
