using DesignPatterns.Behavioral.Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator.Colleague
{
    internal abstract class User
    {
        protected IChatRoom _chatRoom;
        public string Name { get; }

        public User(string name) => Name = name;

        public void SetChatRoom(IChatRoom chatRoom) => _chatRoom = chatRoom;

        public void Send(string message) => _chatRoom.SendMessage(message, this);

        public abstract void Receive(string message, string sender);

    }
}
