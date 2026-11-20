using System.Collections.Generic;
using ChatApp.Domain.Entities;

namespace ChatApp.Domain.Interfaces
{
    public interface IMessageRepository
    {
        void Add(Message message);
        IEnumerable<Message> GetAll();
    }
}