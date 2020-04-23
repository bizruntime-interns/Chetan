using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Properties
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "&&", "Chetan", "*&$$(" };
           foreach (var name in names)
           {
                Console.WriteLine(name.ToUpper());
           }
            Console.WriteLine("before removing:" + names[2]);
            names.Add("Patel");
            names.Remove(names[0]);
            Console.WriteLine("After removing:" + names[2]);
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            };
            Console.ReadKey();
        }
    }
}
