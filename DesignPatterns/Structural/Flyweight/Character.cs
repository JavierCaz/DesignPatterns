using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Shared ConcreteFlyweight
namespace DesignPatterns.Structural.Flyweight
{
    internal class Character : ICharacter
    {

        private readonly char symbol;
        private readonly string fontFamily;
        private readonly int fontSize;

        public Character(char symbol, string fontFamily, int fontSize)
        {
            this.symbol = symbol;
            this.fontFamily = fontFamily;
            this.fontSize = fontSize;
        }

        public void Display(string context)
        {
            Console.WriteLine($"Shared: '{symbol}' in {fontFamily} ({fontSize}px) at {context}");
        }

    }
}
