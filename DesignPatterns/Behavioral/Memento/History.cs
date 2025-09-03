using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Caretaker
namespace DesignPatterns.Behavioral.Memento
{
    internal class History
    {
        private Stack<TextMemento> _history = new();

        public void Backup(TextEditor editor) => _history.Push(editor.Save());

        public void Undo(TextEditor editor)
        {
            if (_history.Count > 0)
            {
                var memento = _history.Pop();
                editor.Restore(memento);
            }
        }

    }
}
