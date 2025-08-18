using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    internal class Circle : IShape
    {

        public int Radius { get; set; }

        public IShape Clone()
        {
            return new Circle { Radius = this.Radius };
        }

        public void Draw() => Console.WriteLine($"Drawing Circle with radius {Radius}");

    }
}
