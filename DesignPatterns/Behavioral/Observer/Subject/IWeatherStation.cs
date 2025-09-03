using DesignPatterns.Behavioral.Observer.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer.Subject
{
    internal interface IWeatherStation
    {
        void Attach(IWeatherObserver observer);
        void Detach(IWeatherObserver observer);
        void Notify();

    }
}
