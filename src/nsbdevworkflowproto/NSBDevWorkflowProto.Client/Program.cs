using System;
using NSBDevWorkflowProto.AEndpoint.Message;
using NSBDevWorkflowProto.BEndpoint.Message;
using NSBDevWorkflowProto.CEndpoint.Message;
using NServiceBus;

namespace NSBDevWorkflowProto.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            BusConfiguration busConfig = new BusConfiguration();
            busConfig.UsePersistence<InMemoryPersistence>();

            ISendOnlyBus bus = Bus.CreateSendOnly(busConfig);

            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("'a' to send an AEndpointCommand");
            Console.WriteLine("'b' to send an BEndpointCommand");
            Console.WriteLine("'c' to send an CEndpointCommand");
            Console.WriteLine("'q' to exit");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();
                bool @break = false;
                switch(key.KeyChar)
                {
                    case 'q':
                        {
                            @break = true;
                            break;
                        }
                    case 'a':
                        {
                            bus.Send(new AEndpointCommand { Sent = DateTime.Now });
                            Console.WriteLine("Sent AEndpointCommand");
                            break;
                        }
                    case 'b':
                        {
                            bus.Send(new BEndpointCommand { Sent = DateTime.Now });
                            Console.WriteLine("Sent BEndpointCommand");
                            break;
                        }
                    case 'c':
                        {
                            bus.Send(new CEndpointCommand { Sent = DateTime.Now });
                            Console.WriteLine("Sent CEndpointCommand");
                            break;
                        }
                    default:
                        break;
                }

                Console.WriteLine();

                if (@break)
                    break;
            }

        }
    }
}
