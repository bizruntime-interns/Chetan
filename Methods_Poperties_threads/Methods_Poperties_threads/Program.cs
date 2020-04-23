using System;
using System.Threading;

namespace Methods_Poperties_threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = Thread.CurrentThread;

            Console.WriteLine("Thread Id:{0}", t1.ManagedThreadId);
            Console.WriteLine("Is Background Thread:{0}", t1.IsBackground);
            Console.WriteLine("Thread Culture:{0}", t1.CurrentCulture);
        }
    }
}
