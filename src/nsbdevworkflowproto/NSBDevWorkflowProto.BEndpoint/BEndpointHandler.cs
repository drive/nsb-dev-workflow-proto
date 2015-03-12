using System;
using NSBDevWorkflowProto.BEndpoint.Message;
using NServiceBus;

namespace NSBDevWorkflowProto.BEndpoint
{
    public class BEndpointHandler : IHandleMessages<BEndpointCommand>
    {
        public void Handle(BEndpointCommand message)
        {
            Console.WriteLine("-------------");
            Console.WriteLine("----- B -----");
            Console.WriteLine("BEndpoint handled a message sent at {0}", message.Sent);
            Console.WriteLine("-------------");
            Console.WriteLine("-------------");
            Console.WriteLine();
        }
    }
}
