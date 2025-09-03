using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Terminal Expression
namespace DesignPatterns.Behavioral.Interpreter.Expression
{
    internal class NumberExpression : IExpression
    {
        private int _number;
        public NumberExpression(int number) => _number = number;
        public int Interpret(Context context) => _number;
    }
}
