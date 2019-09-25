using System;
using System.ServiceModel;

namespace Server
{
    class Server
    {
        static void Main(string[] args)
        {
            Console.Title = "SERVER";

            Uri address = new Uri("http://localhost:4000/IContract");

            BasicHttpBinding binding = new BasicHttpBinding();

            Type contract = typeof(IContract);

            ServiceHost host = new ServiceHost(typeof(Service));

            host.AddServiceEndpoint(contract, binding, address);

            host.Open();

            Console.WriteLine("Сервер готов к работе");
            Console.ReadKey();

            host.Close();
        }
    }
}
