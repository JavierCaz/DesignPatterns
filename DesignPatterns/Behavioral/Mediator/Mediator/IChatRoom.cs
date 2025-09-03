using DesignPatterns.Behavioral.Mediator.Colleague;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator.Mediator
{
    internal interface IChatRoom
    {
        void SendMessage(string message, User sender);
    }
}
