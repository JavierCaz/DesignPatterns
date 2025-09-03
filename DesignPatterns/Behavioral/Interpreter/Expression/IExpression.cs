using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Interpreter.Expression
{
    internal interface IExpression
    {
        int Interpret(Context context);
    }
}
