﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IObservable_interface
{
     internal class MyObserver<T>:IObserver<T>
    {
        private string _name = null;

        public MyObserver(string subscriberName="Subscriber")
        {
            _name = subscriberName;
        }

        public virtual void OnCompleted()
        {
            Console.WriteLine($"observable complted by {_name}");
        }

        public virtual void OnError(Exception error)
        {
            Console.WriteLine($"error occured while {_name} was observing {error.Message}");
        }

        public virtual void OnNext(T value)
        {
            Console.WriteLine($"{_name} received {value.ToString()}");
        }
    }
}
