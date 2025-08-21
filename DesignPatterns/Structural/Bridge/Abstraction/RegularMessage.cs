using DesignPatterns.Structural.Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.Abstraction
{
    internal class RegularMessage : Message
    {

        public RegularMessage(IMessageSender sender) : base(sender) { }

        public override void Send(string subject, string body)
        {
            sender.SendMessage(subject, body);
        }

    }
}
