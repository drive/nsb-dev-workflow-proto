using System;
using NServiceBus;

namespace NSBDevWorkflowProto.BEndpoint.Message
{
    public class BEndpointCommand : ICommand
    {
        public DateTime Sent { get; set; }
    }
}
