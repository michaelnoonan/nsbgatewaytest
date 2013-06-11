using Messages;
using NServiceBus;

namespace Endpoint2
{
    public class PingHandler : IHandleMessages<Ping>
    {
        public IBus Bus { get; set; }

        public void Handle(Ping message)
        {
            var reply = new Pong(message.Message + " Pong!");
            Bus.Reply(reply);
        }
    }
}