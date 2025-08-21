using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade.SubsystemClasses
{
    internal class LightSystem
    {

        public void TurnOnLights() => Console.WriteLine("Lights turned ON.");
        public void TurnOffLights() => Console.WriteLine("Lights turned OFF.");

    }
}
