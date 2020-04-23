using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalAM
{
    class Program
    {  
        internal class BaseClass
        {
            public static int intM = 0;
        }
        public class TestAccess
        {
            static void Main()
            {
                var myBase = new BaseClass();    
                BaseClass.intM = 444;
                Console.ReadKey();
            }
        }
    }
}
