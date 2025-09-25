using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Product
namespace DesignPatterns.Creational.Builder
{
    internal class Car
    {

        public string Engine { get; set; }
        public int Wheels { get; set; }
        public bool HasGPS { get; set; }
        public bool HasSunroof { get; set; }
        public string Color { get; set; }

        public void ShowSpecs()
        {
            Console.WriteLine($"Engine: {Engine}, Wheels: {Wheels}, GPS: {HasGPS}, Sunroof: {HasSunroof}, Color: {Color}");
        }

    }
}
