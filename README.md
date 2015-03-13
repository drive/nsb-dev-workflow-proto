# NServiceBus Development Workflow

An example of an alternative NServiceBus solution structure which allows development to be separated from the final deployment strategy. Contains three theoretical endpoints, A, B, and C which would be deployed to separate (windows) services (thus processes) in a production environment. The default development configuration would result in three separate host processes (or 'console applications') to be started when debugging - when using the NServiceBus.Host NuGet package to setup the endpoint.

This example includes a development only project - NSBDevWorkflowProto.Dev.Endpoint.Host - which starts a process that loads all three endpoints (each with it's own bus configuration). It also includes a crude client which allows sending of messages to handlers defined by the three endpoints.

#### Note
Set the startup projects for the solution to the Client **and** Dev.Endpoint.Host projects

#### TODO:
 * Extract config
 * Create deployment project per endpoint? - to demonstrate packaging of the endpoint for deployment
 * ... 
