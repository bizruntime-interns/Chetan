using System;
using System.Threading;

namespace Creating_thread
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create child thread
            Thread t1 = new Thread(new ThreadStart(PrintInfo));
            // start newly created thread
            t1.Start();
            Console.WriteLine("Main Thread Completed");
            Console.ReadLine();
        }

        static void PrintInfo()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("i value: {0}", i);
            }
            Console.WriteLine("Child Thread Completed");
        }
    }
}
