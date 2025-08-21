using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.Implementor
{
    internal class SMSSender : IMessageSender
    {

        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"SMS -> Subject: {subject}, Body: {body}");
        }

    }
}
