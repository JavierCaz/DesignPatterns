using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResposibility
{
    internal class Manager : ExpenseHandler
    {
        protected override bool CanApprove(decimal amount) => amount <= 1000;
        protected override void Approve(decimal amount) => Console.WriteLine($"Manager approved ${amount}");
    }
}
