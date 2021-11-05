using System;
using System.Threading.Tasks;
using Grpc.Net.Client;

namespace Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Client started !");

            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var customerClient = new Customer.CustomerClient(channel);
            var clientRequested = new CustomerLookupModel { UserId = 2 };
            var reply = await customerClient.GetCustomerInfoAsync(clientRequested);
            Console.WriteLine($"{reply.FirstName} {reply.LastName}");
        }
    }
}
