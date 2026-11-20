using System;
using System.Collections.Generic;
using ChatApp.Domain.Entities;
using ChatApp.Domain.Interfaces;

namespace ChatApp.Infrastructure.Repositories
{
    public class InMemoryMessageRepository : IMessageRepository
    {
        // Тут ми зберігаємо повідомлення в оперативній пам'яті
        private readonly List<Message> _messages = new List<Message>();

        public void Add(Message message)
        {
            _messages.Add(message);
        }

        public IEnumerable<Message> GetAll()
        {
            return _messages;
        }
    }
}