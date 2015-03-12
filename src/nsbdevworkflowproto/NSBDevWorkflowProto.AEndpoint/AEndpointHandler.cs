using System;
using NSBDevWorkflowProto.AEndpoint.Message;
using NServiceBus;

namespace NSBDevWorkflowProto.AEndpoint
{
    public class AEndpointHandler : IHandleMessages<AEndpointCommand>
    {
        public void Handle(AEndpointCommand message)
        {
            Console.WriteLine("-------------");
            Console.WriteLine("----- A -----");
            Console.WriteLine("AEndpoint handled a message sent at {0}", message.Sent);
            Console.WriteLine("-------------");
            Console.WriteLine("-------------");
            Console.WriteLine();
        }
    }
}
