using DesignPatterns.Behavioral.Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Context
namespace DesignPatterns.Behavioral.Strategy
{
    internal class PaymentProcessor
    {
        private IPaymentStrategy _strategy;

        public PaymentProcessor(IPaymentStrategy strategy) => _strategy = strategy;

        public void SetStrategy(IPaymentStrategy strategy) => _strategy = strategy;

        public void ProcessPayment(decimal amount) => _strategy.Pay(amount);

    }
}
