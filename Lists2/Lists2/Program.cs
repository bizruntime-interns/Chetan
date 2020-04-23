using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of digits of fibonacci digits to be displayed");
            int n = Convert.ToInt32(Console.ReadLine());
            var fib = new List<int> { 0, 1 };
            while (n-2!= 0)
            {  
                int f = fib[fib.Count - 1];
                int l = fib[fib.Count - 2];
                fib.Add(f + l);
                n = n - 1;
            }
            Console.WriteLine("Fibonacci series");
            foreach (int i in fib)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
