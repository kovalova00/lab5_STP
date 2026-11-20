using System;

namespace ChatApp.Domain.Entities
{
    public class Message
    {
        public Guid Id { get; private set; }
        public string Text { get; private set; }
        public string Sender { get; private set; }
        public DateTime Timestamp { get; private set; }

        public Message(string text, string sender)
        {
            Id = Guid.NewGuid();
            Text = text;
            Sender = sender;
            Timestamp = DateTime.Now;
        }
    }
}