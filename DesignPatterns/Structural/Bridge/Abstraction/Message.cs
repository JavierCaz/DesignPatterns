using DesignPatterns.Structural.Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.Abstraction
{
    internal abstract class Message
    {

        protected IMessageSender sender;

        protected Message(IMessageSender sender)
        {
            this.sender = sender;
        }

        public abstract void Send(string subject, string body);

    }
}
