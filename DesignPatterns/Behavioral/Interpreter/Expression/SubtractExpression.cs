using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Non-Terminal Expression
namespace DesignPatterns.Behavioral.Interpreter.Expression
{
    internal class SubtractExpression : IExpression
    {
        private IExpression _left, _right;
        public SubtractExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }
        public int Interpret(Context context) => _left.Interpret(context) - _right.Interpret(context);
    }
}
