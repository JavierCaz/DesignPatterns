using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer.Observer
{
    internal class Computer :IWeatherObserver
    {
        public void Update(float temperature) =>
                Console.WriteLine($"Computer Display: Temperature updated to {temperature}°C");

    }
}
