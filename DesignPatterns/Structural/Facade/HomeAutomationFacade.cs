using DesignPatterns.Structural.Facade.SubsystemClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    internal class HomeAutomationFacade
    {

        private readonly LightSystem lights;
        private readonly ThermostatSystem thermostat;
        private readonly SecuritySystem security;

        public HomeAutomationFacade()
        {
            lights = new LightSystem();
            thermostat = new ThermostatSystem();
            security = new SecuritySystem();
        }

        public void LeaveHome()
        {
            lights.TurnOffLights();
            thermostat.SetTemperature(18);
            security.ArmSystem();
            Console.WriteLine("Home is set for leaving.");
        }

        public void ArriveHome()
        {
            lights.TurnOnLights();
            thermostat.SetTemperature(22);
            security.DisarmSystem();
            Console.WriteLine("Welcome home!");
        }
    }
}
