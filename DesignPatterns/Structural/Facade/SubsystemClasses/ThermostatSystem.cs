using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade.SubsystemClasses
{
    internal class ThermostatSystem
    {
        public void SetTemperature(int degrees) => Console.WriteLine($"Temperature set to {degrees}°C.");
    }
}
