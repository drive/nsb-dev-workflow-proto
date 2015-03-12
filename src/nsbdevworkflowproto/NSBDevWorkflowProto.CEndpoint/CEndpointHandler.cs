using System;
using NSBDevWorkflowProto.CEndpoint.Message;
using NServiceBus;

namespace NSBDevWorkflowProto.CEndpoint
{
    public class BEndpointHandler : IHandleMessages<CEndpointCommand>
    {
        public void Handle(CEndpointCommand message)
        {
            Console.WriteLine("-------------");
            Console.WriteLine("----- C -----");
            Console.WriteLine("CEndpoint handled a message sent at {0}", message.Sent);
            Console.WriteLine("-------------");
            Console.WriteLine("-------------");
            Console.WriteLine();
        }
    }
}
