using System;
using NServiceBus;

namespace NSBDevWorkflowProto.Dev.Endpoint.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var configAEndpoint = new BusConfiguration();
            configAEndpoint.EndpointName("AEndpoint");
            configAEndpoint.UsePersistence<InMemoryPersistence>();
            configAEndpoint.AssembliesToScan(AllAssemblies.Except("NSBDevWorkflowProto.BEndpoint.dll").And("NSBDevWorkflowProto.CEndpoint.dll"));
            Bus.Create(configAEndpoint).Start();

            var configBEndpoint = new BusConfiguration();
            configBEndpoint.EndpointName("BEndpoint");
            configBEndpoint.UsePersistence<InMemoryPersistence>();
            configAEndpoint.AssembliesToScan(AllAssemblies.Except("NSBDevWorkflowProto.AEndpoint.dll").And("NSBDevWorkflowProto.CEndpoint.dll"));
            Bus.Create(configBEndpoint).Start();

            var configCEndpoint = new BusConfiguration();
            configCEndpoint.EndpointName("CEndpoint");
            configCEndpoint.UsePersistence<InMemoryPersistence>();
            configCEndpoint.AssembliesToScan(AllAssemblies.Except("NSBDevWorkflowProto.AEndpoint.dll").And("NSBDevWorkflowProto.BEndpoint.dll"));
            Bus.Create(configCEndpoint).Start();

            Console.ReadLine();
        }
    }
}
