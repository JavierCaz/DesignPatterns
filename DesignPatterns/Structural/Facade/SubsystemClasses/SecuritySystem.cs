using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade.SubsystemClasses
{
    internal class SecuritySystem
    {

        public void ArmSystem() => Console.WriteLine("Security system ARMED.");
        public void DisarmSystem() => Console.WriteLine("Security system DISARMED.");

    }
}
