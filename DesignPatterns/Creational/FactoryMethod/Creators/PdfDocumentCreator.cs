using DesignPatterns.Creational.FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Creators
{
    internal class PdfDocumentCreator : DocumentCreator
    {
        public override IDocument CreateDocument() => new PdfDocument();
    }
}
