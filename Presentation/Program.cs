using System;
using ChatApp.Domain.Interfaces;
using ChatApp.Infrastructure.Repositories;
using ChatApp.Application.UseCases;

namespace ChatApp.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Створюємо конкретну реалізацію репозиторію (Infrastructure)
            IMessageRepository repository = new InMemoryMessageRepository();

            // 2. Передаємо її в use cases (Application) через конструктор (Dependency Injection)
            var sendMessageUseCase = new SendMessageUseCase(repository);
            var getMessagesUseCase = new GetMessagesUseCase(repository);

            // 3. Використовуємо (Presentation)
            Console.WriteLine("--- Чат-месенджер запущено ---");
            
            sendMessageUseCase.Execute("Привіт!", "Олександра");
            sendMessageUseCase.Execute("Як справи?", "Олександра");
            sendMessageUseCase.Execute("Все добре, пишу лабораторну", "Співрозмовник");

            Console.WriteLine("\nІсторія повідомлень:");
            foreach (var msg in getMessagesUseCase.Execute())
            {
                Console.WriteLine($"[{msg.Timestamp:HH:mm}] {msg.Sender}: {msg.Text}");
            }
            
            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}