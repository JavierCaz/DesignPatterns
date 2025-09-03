using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Abstract Handler
namespace DesignPatterns.Behavioral.ChainOfResposibility
{
    internal abstract class ExpenseHandler
    {
        protected ExpenseHandler _next;

        public void SetNext(ExpenseHandler next) => _next = next;

        public void HandleExpense(decimal amount)
        {
            if (CanApprove(amount))
            {
                Approve(amount);
            }
            else if (_next != null)
            {
                _next.HandleExpense(amount);
            }
            else
            {
                Console.WriteLine($"No one can approve the expense of ${amount}");
            }
        }

        protected abstract bool CanApprove(decimal amount);
        protected abstract void Approve(decimal amount);
    }
}
