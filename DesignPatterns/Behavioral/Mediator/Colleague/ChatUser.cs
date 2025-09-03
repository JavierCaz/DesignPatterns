using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator.Colleague
{
    internal class ChatUser : User
    {
        public ChatUser(string name) : base(name) { }

        public override void Receive(string message, string sender)
        {
            Console.WriteLine($"{Name} received message from {sender}: {message}");
        }

    }
}
