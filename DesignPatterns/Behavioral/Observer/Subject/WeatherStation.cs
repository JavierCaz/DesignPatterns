using DesignPatterns.Behavioral.Observer.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer.Subject
{
    internal class WeatherStation : IWeatherStation
    {
        private List<IWeatherObserver> _observers = new();
        private float _temperature;

        public void SetTemperature(float temp)
        {
            _temperature = temp;
            Notify();
        }

        public void Attach(IWeatherObserver observer) => _observers.Add(observer);
        public void Detach(IWeatherObserver observer) => _observers.Remove(observer);

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature);
            }
        }

    }
}
