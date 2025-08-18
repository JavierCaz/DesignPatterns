using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    internal interface ICarBuilder
    {

        void SetEngine(string engine);
        void SetWheels(int count);
        void SetGPS(bool hasGPS);
        void SetSunroof(bool hasSunroof);
        void SetColor(string color);
        Car Build();

    }
}
