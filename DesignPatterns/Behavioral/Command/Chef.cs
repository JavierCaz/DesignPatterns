using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Receiver
namespace DesignPatterns.Behavioral.Command
{
    internal class Chef
    {
        public void CookBurger() => Console.WriteLine("Chef is cooking a burger.");
        public void CookPasta() => Console.WriteLine("Chef is cooking pasta.");

    }
}
