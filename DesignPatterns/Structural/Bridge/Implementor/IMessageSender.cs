using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.Implementor
{
    internal interface IMessageSender
    {
        void SendMessage(string subject, string body);
    }
}
