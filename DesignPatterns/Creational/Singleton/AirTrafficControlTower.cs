using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Singleton Class
namespace DesignPatterns.Creational.Singleton
{
    internal class AirTrafficControlTower
    {
        //Static Instance Field
        private static AirTrafficControlTower _instance;
        private static readonly object _lock = new object();

        // Private constructor
        private AirTrafficControlTower() { }

        // Public accessor
        public static AirTrafficControlTower Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new AirTrafficControlTower();
                    return _instance;
                }
            }
        }

        public void Coordinate(string flight)
        {
            Console.WriteLine($"Coordinating flight {flight}");
        }
    }
}
