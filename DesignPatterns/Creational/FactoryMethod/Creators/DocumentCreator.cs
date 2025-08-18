using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Creational.FactoryMethod.Products;

namespace DesignPatterns.Creational.FactoryMethod.Creators
{
    internal abstract class DocumentCreator
    {
        public abstract IDocument CreateDocument();
    }
}
