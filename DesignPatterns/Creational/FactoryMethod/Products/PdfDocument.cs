using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Products
{
    internal class PdfDocument : IDocument
    {
        public void Print() => Console.WriteLine("Printing PDF Document");
    }
}
