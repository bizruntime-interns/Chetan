using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("FName", "Chetan");
            ht.Add("LName", "Patel");
            ht.Add("Age", 21);
            ht[1] = "Engineer";
            try
            {
                ht.Add(1, "Engineer");
            }
            catch
            {
                Console.WriteLine("Element with key 1 exsist");
            }
            foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine("key={0} value={1}", item.Key, item.Value);
            }
            Console.WriteLine("Accessing values using keys");
            foreach(var items1 in ht.Keys)
            {
                Console.WriteLine("key={0}", items1);
            }
            Console.WriteLine("After removal");
            ht.Remove("LName");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine("key={0} value={1}", item.Key, item.Value);
            }
            Console.ReadKey();
        }
    }
}
