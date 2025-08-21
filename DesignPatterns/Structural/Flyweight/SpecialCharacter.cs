using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Unshared ConcreteFlyweight
namespace DesignPatterns.Structural.Flyweight
{
    internal class SpecialCharacter : ICharacter
    {

        private readonly string symbol;
        private readonly string metadata;

        public SpecialCharacter(string symbol, string metadata)
        {
            this.symbol = symbol;
            this.metadata = metadata;
        }

        public void Display(string context)
        {
            Console.WriteLine($"Unshared: '{symbol}' with metadata [{metadata}] at {context}");
        }

    }
}
