using ChatApp.Domain.Entities;
using ChatApp.Domain.Interfaces;

namespace ChatApp.Application.UseCases
{
    public class SendMessageUseCase
    {
        private readonly IMessageRepository _repository;

        // Залежність від інтерфейсу (принцип інверсії залежностей)
        public SendMessageUseCase(IMessageRepository repository)
        {
            _repository = repository;
        }

        public void Execute(string text, string sender)
        {
            var message = new Message(text, sender);
            _repository.Add(message);
        }
    }
}