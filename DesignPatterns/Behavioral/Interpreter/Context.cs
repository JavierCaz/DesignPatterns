using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Interpreter
{
    internal class Context
    {
        private Dictionary<string, int> _variables = new();

        public void SetVariable(string name, int value) => _variables[name] = value;
        public int GetVariable(string name) => _variables.TryGetValue(name, out var value) ? value : 0;
    }
}
