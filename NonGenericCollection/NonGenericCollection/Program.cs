using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {


            Queue myqueue = new Queue();
            myqueue.Enqueue("Chetan");
            myqueue.Enqueue("Patel");
            Console.WriteLine(" total numbers of elements in queue are: " + myqueue.Count);          
            myqueue.Dequeue();
            Console.WriteLine(" total numbers of elements in queue are: " + myqueue.Count);
            Console.ReadKey();
        
        }
    }
}
