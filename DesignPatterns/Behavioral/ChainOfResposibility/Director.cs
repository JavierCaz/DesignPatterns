using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResposibility
{
    internal class Director : ExpenseHandler
    {
        protected override bool CanApprove(decimal amount) => amount <= 10000;
        protected override void Approve(decimal amount) => Console.WriteLine($"Director approved ${amount}");
    }
}
