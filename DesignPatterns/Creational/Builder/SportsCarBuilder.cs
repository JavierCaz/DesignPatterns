using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    internal class SportsCarBuilder : ICarBuilder
    {

        private Car _car = new Car();

        public void SetEngine(string engine) => _car.Engine = engine;
        public void SetWheels(int count) => _car.Wheels = count;
        public void SetGPS(bool hasGPS) => _car.HasGPS = hasGPS;
        public void SetSunroof(bool hasSunroof) => _car.HasSunroof = hasSunroof;
        public void SetColor(string color) => _car.Color = color;

        public Car Build() => _car;

    }
}
