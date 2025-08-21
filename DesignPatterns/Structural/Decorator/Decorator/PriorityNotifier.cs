using DesignPatterns.Structural.Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator.Decorator
{
    internal class PriorityNotifier : NotifierDecorator
    {

        public PriorityNotifier(INotifier notifier) : base(notifier) { }

        public override void Send(string message)
        {
            base.Send("[HIGH PRIORITY] " + message);
        }

    }
}
