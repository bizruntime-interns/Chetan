using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedAM
{
    class Program
    {
        class Base
        {
            protected int num1;
        }
        class Derived : Base
        {
            public int num2;
            static void Main(string[] args)
            {
                Base ob1 = new Base();
                Derived ob2 = new Derived();
                ob2.num1 = 20; 
                ob2.num2 = 90;
                Console.WriteLine("Number2 value {0}", ob2.num2);
                Console.WriteLine("Number1 value which is protected {0}", ob2.num1);
                Console.ReadLine();
            }
        }
    }
}
