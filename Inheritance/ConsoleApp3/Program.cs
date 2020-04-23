using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Base
    {
       protected string city = "Delhi";
       protected string state = "Delhi";


    }

    class Drived : Base
    {
        public void DisplayCityAndState()
        {
            Console.WriteLine(" City == " + city + " state == " + state);
        }

        public static void Main()
        {
            Drived dp = new Drived();
            Console.WriteLine("the city = {0}", dp.city);
            Console.WriteLine("the state = {0}", dp.state);
            Console.ReadKey();
        }

    }
}
