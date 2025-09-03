using DesignPatterns.Behavioral.Command.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Invoker
namespace DesignPatterns.Behavioral.Command
{
    internal class Waiter
    {
        private IOrder _order;
        public void TakeOrder(IOrder order) => _order = order;
        public void PlaceOrder() => _order.Execute();
    }
}
