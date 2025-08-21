using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Proxy
namespace DesignPatterns.Structural.Proxy
{
    internal class ImageProxy : IImage
    {

        private readonly string filename;
        private RealImage realImage;

        public ImageProxy(string filename)
        {
            this.filename = filename;
        }

        public void Display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(filename); // Lazy loading
            }
            realImage.Display();
        }

    }
}
