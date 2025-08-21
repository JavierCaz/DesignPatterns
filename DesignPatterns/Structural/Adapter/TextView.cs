using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Adaptee
namespace DesignPatterns.Structural.Adapter
{
    internal class TextView
    {

        public void DrawText()
        {
            Console.WriteLine("Drawing text");
        }

    }
}
