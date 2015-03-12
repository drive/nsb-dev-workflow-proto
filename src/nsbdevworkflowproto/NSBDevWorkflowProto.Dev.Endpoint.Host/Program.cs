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
            configAEndpoint.AssembliesToScan(AllAssemblies.Except("NSBDevWorkflowProto.BEndpoint.dll"));
            Bus.Create(configAEndpoint).Start();

            var configBEndpoint = new BusConfiguration();
            configBEndpoint.EndpointName("BEndpoint");
            configBEndpoint.UsePersistence<InMemoryPersistence>();
            configAEndpoint.AssembliesToScan(AllAssemblies.Except("NSBDevWorkflowProto.AEndpoint.dll"));
            Bus.Create(configBEndpoint).Start();

            Console.ReadLine();
        }
    }
}
