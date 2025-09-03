using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Originator
namespace DesignPatterns.Behavioral.Memento
{
    internal class TextEditor
    {
        private string _content = "";

        public void Type(string text) => _content += text;

        public string GetContent() => _content;

        public TextMemento Save() => new TextMemento(_content);

        public void Restore(TextMemento memento) => _content = memento.Content;

    }
}
