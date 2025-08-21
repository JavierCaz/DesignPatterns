using DesignPatterns.Structural.Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.Abstraction
{
    internal class UrgentMessage : Message
    {

        public UrgentMessage(IMessageSender sender) : base(sender) { }

        public override void Send(string subject, string body)
        {
            sender.SendMessage("URGENT: " + subject, body.ToUpper());
        }

    }
}
