using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Terminal Expression
namespace DesignPatterns.Behavioral.Interpreter.Expression
{
    internal class VariableExpression : IExpression
    {
        private string _name;
        public VariableExpression(string name) => _name = name;
        public int Interpret(Context context) => context.GetVariable(_name);
    }
}
