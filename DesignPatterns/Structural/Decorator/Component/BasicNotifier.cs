using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator.Component
{
    internal class BasicNotifier : INotifier
    {

        public void Send(string message)
        {
            Console.WriteLine("Sending notification: " + message);
        }

    }
}
