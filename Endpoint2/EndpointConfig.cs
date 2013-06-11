


using System.Collections.Generic;
using System.Reflection;

namespace Endpoint2
{
    using NServiceBus;

	/*
		This class configures this endpoint as a Server. More information about how to configure the NServiceBus host
		can be found here: http://particular.net/articles/the-nservicebus-host
	*/
	public class EndpointConfig : IConfigureThisEndpoint, IWantCustomInitialization
    {
	    private IStartableBus _bus;

	    public void Init()
	    {
	        _bus = Configure
	            .With(GetAssembliesToScan())
                .DefaultBuilder()
                .RunGatewayWithInMemoryPersistence()
                .DisableTimeoutManager()
	            .InMemoryFaultManagement()
	            .InMemorySubscriptionStorage()
	            .UnicastBus().CreateBus();
	    }

	    private IEnumerable<Assembly> GetAssembliesToScan()
	    {
	        yield return Assembly.Load("Messages");
	        yield return Assembly.Load("Endpoint2");
	    }
    }
}