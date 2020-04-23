using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IObservable_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo();
        }

        static void Demo()
        {
            var observable=new MyRangeObservable(5, 8);

            var observer = new MyObserver<int>();
            var subscription = observable.Subscribe(observer);

            subscription.Dispose();
        }
    }
}
