using System;
using NServiceBus;

namespace NSBDevWorkflowProto.CEndpoint.Message
{
    public class CEndpointCommand : ICommand
    {
        public DateTime Sent { get; set; }
    }
}
