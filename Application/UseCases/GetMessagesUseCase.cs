using System.Collections.Generic;
using ChatApp.Domain.Entities;
using ChatApp.Domain.Interfaces;

namespace ChatApp.Application.UseCases
{
    public class GetMessagesUseCase
    {
        private readonly IMessageRepository _repository;

        public GetMessagesUseCase(IMessageRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Message> Execute()
        {
            return _repository.GetAll();
        }
    }
}