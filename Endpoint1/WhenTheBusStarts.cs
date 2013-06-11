using System.Threading;
using Messages;
using NServiceBus;

namespace Endpoint1
{
    public class WhenTheBusStarts : IWantToRunWhenBusStartsAndStops
    {
        public IBus Bus { get; set; }

        public void Start()
        {
            while (true)
            {
                Bus.Send("endpoint2", new Ping("Hello!"));
                Thread.Sleep(1000);
            }
        }

        public void Stop()
        {
            
        }
    }
}