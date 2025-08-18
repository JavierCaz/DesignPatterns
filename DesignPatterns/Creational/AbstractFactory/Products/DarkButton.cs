using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Products
{
    internal class DarkButton : IButton
    {
        public void Render() => Console.WriteLine("Dark Button");
    }
}
