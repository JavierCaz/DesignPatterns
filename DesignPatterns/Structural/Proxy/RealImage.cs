using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Real Subject
namespace DesignPatterns.Structural.Proxy
{
    internal class RealImage : IImage
    {

        private readonly string filename;

        public RealImage(string filename)
        {
            this.filename = filename;
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"Loading image from disk: {filename}");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying image: {filename}");
        }

    }
}
