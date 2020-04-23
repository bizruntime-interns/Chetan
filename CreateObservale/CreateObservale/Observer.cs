using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateObservale
{
    class Observer : IObserver<int>
    {
        public void OnNext(int value)
        {
            Console.WriteLine(value); 
        }
        public void OnError(Exception error)
        {
            Console.WriteLine($"Error:{error.Message}");
        }

        internal static IObserver<int> Create(Action writeLine, Action<object> p)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            Console.WriteLine("Observation completed");
        }
    }
}
