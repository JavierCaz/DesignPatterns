using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Director
namespace DesignPatterns.Creational.Builder
{
    internal class CarDirector
    {

        public void ConstructSportsCar(ICarBuilder builder)
        {
            builder.SetEngine("V8");
            builder.SetWheels(4);
            builder.SetGPS(true);
            builder.SetSunroof(true);
            builder.SetColor("Red");
        }

    }
}
