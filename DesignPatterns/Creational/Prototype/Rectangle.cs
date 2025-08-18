using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    internal class Rectangle : IShape
    {

        public int Width { get; set; }
        public int Height { get; set; }

        public IShape Clone()
        {
            return new Rectangle { Width = this.Width, Height = this.Height };
        }

        public void Draw() => Console.WriteLine($"Drawing Rectangle {Width}x{Height}");

    }
}
