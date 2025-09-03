using DesignPatterns.Behavioral.Mediator.Colleague;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator.Mediator
{
    internal class ChatRoom : IChatRoom
    {
        private List<User> _users = new();

        public void Register(User user)
        {
            _users.Add(user);
            user.SetChatRoom(this);
        }

        public void SendMessage(string message, User sender)
        {
            foreach (var user in _users)
            {
                if (user != sender)
                {
                    user.Receive(message, sender.Name);
                }
            }
        }

    }
}
