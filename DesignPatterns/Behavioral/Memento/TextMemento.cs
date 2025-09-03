using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Memento
namespace DesignPatterns.Behavioral.Memento
{
    internal class TextMemento
    {
        public string Content { get; }

        public TextMemento(string content) => Content = content;

    }
}
