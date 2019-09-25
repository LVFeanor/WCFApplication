using System;
using System.ServiceModel;

namespace Client
{
    class Client
    {
        static void Main(string[] args)
        {
            Uri address = new Uri("http://localhost:4000/IContract");

            BasicHttpBinding binding = new BasicHttpBinding();

            EndpointAddress endpoint = new EndpointAddress(address);

            ChannelFactory<IContract> factory = new ChannelFactory<IContract>(binding, endpoint);

            IContract channel = factory.CreateChannel();

            Console.WriteLine("Введите своё имя: ");
            string name = Console.ReadLine();
            channel.SayHello(name);
            Console.WriteLine("Введите число фибоначчи: ");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Резуьтат: {0}", channel.Fib(f));

            Console.ReadKey();
        }
    }
}
