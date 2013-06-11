using Messages;
using NServiceBus;

namespace Endpoint1
{
    public class PongHandler : IHandleMessages<Pong>
    {
        public void Handle(Pong message)
        {
            
        }
    }
}