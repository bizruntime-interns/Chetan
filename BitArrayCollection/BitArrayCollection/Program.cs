using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArrayCollection
{
    class Program
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            BitArray a = new BitArray(5);
            BitArray b = new BitArray(5);
            a[0] = b[1] = false;
            a[1] = b[2] = true;
            a[2] = b[0] = false;
            a[3] = b[3] = true;
            a[4] = b[4] = false;

            log.Info(a);
            log.Info(b);

            log.Info("And:");
            log.Info(a.And(b));
            Console.ReadKey();

        }
    }
}
