using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create child threads

            Thread t1 = new Thread(new ThreadStart(PrintInfo1));

            Thread t2 = new Thread(new ThreadStart(PrintInfo2));

            t1.Start();
            t2.Start();
            Console.ReadLine();
        }

        static void PrintInfo1()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("i value: {0}", i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("First method completed");
        }

        static void PrintInfo2()

        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("i value: {0}", i);
            }
            Console.WriteLine("Second method completed");
        }
    }
}
