using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResposibility
{
    internal class TeamLead : ExpenseHandler
    {
        protected override bool CanApprove(decimal amount) => amount <= 100;
        protected override void Approve(decimal amount) => Console.WriteLine($"Team Lead approved ${amount}");
    }
}
