using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Flyweight Factory
namespace DesignPatterns.Structural.Flyweight
{
    internal class CharacterFactory
    {

        private readonly Dictionary<string, ICharacter> characters = new();

        public ICharacter GetCharacter(char symbol, string fontFamily, int fontSize)
        {
            string key = $"{symbol}_{fontFamily}_{fontSize}";

            if (!characters.ContainsKey(key))
            {
                characters[key] = new Character(symbol, fontFamily, fontSize);
            }

            return characters[key];
        }

    }
}
