using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add("Red");
            arr.Add("Green");
            arr.Add("Yellow");
            arr.Add("Orange");
            arr.Add("Pink");
            arr.Add("Black");
            arr.Insert(6, "Brown");
            arr.Insert(arr.Count, "White");

            Queue q = new Queue();
            q.Enqueue("good");
            q.Enqueue("Color");


            arr.InsertRange(0, q);
            log.Info(arr);

            arr.Remove("Orange");
            log.Info(arr);

            arr.RemoveAt(4);
            log.Info(arr);

            try
            {
                arr.Insert(arr.Count + 1, "Grey");
            }
            catch(Exception e)
            {
                log.Error(e.ToString());
            }


            IEnumerator c = arr.GetEnumerator();
            while(c.MoveNext())
            {
                Object obj = c.Current;
                log.Info(obj);
            }

            IEnumerator e1 = arr.GetEnumerator(2, 2);
            while(e1.MoveNext())
            {
                Object obj1 = e1.Current;
                log.Info(obj1);
            }



            SortedList s = new SortedList();
            //s.Add("FName", "Chetan");
            //s.Add("LName", "Patel");
            //s.Add("Age", 21);
            s.Add(1,2);
            log.Info(s);

            Console.ReadKey();
        }
    }
}
