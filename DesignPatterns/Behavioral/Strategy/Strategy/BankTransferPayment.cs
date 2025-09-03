using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.Strategy
{
    internal class BankTransferPayment : IPaymentStrategy
    {
        public void Pay(decimal amount) =>
                Console.WriteLine($"Paid ${amount} using Bank Transfer.");

    }
}
