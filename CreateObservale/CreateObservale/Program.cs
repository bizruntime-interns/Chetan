using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using System.Reactive.Linq;

namespace CreateObservale
{
    class Program
    {
        static void Main(string[] args)
        { 
            //create the observable
            var observable = Observable.Range(5, 8);

            //subscribe to the observable
            var subscription = observable.Subscribe(new Observer());

            subscription.Dispose();
        }
    }
}
