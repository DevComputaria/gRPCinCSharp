using Grpc.Net.Client;
using GrpcServer;
using System;

namespace GrpcClient
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var input = new HelloRequest { Name = "DevComputaria" };
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);

            var reply = await client.SayHelloAsync(input);
            Console.ReadLine();
        }
    }
}
