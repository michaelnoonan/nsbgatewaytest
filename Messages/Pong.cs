using NServiceBus;

namespace Messages
{
    public class Pong : IMessage
    {
        public Pong(string message)
        {
            Message = message;
        }

        public string Message { get; protected set; }
    }
}