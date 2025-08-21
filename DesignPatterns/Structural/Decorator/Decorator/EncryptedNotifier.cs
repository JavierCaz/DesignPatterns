using DesignPatterns.Structural.Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator.Decorator
{
    internal class EncryptedNotifier : NotifierDecorator
    {

        public EncryptedNotifier(INotifier notifier) : base(notifier) { }

        public override void Send(string message)
        {
            string encrypted = "[ENCRYPTED] " + message;
            base.Send(encrypted);
        }

    }
}
