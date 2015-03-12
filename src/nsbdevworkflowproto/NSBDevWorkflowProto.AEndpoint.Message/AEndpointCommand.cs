using System;
using NServiceBus;

namespace NSBDevWorkflowProto.AEndpoint.Message
{
    public class AEndpointCommand : ICommand
    {
        public DateTime Sent { get; set; }
    }
}
