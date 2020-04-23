using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multipleclass
{
    class Car
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            CarColor myobj = new CarColor();
            Console.WriteLine(myobj.color);

            CarType myobj1 = new CarType();
            myobj1.printout("Mustang");
            Console.ReadKey();
        }
    }
}
