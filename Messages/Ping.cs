using NServiceBus;

namespace Messages
{
    public class Ping : ICommand
    {
        public Ping(string message)
        {
            Message = message;
        }

        public string Message { get; protected set; }
    }
}
