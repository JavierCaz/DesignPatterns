using DesignPatterns.Structural.Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator.Decorator
{
    internal class NotifierDecorator : INotifier
    {

        protected INotifier wrappee;

        protected NotifierDecorator(INotifier notifier)
        {
            wrappee = notifier;
        }

        public virtual void Send(string message)
        {
            wrappee.Send(message);
        }

    }
}
