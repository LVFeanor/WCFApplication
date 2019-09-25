using System;

namespace Server
{
    class Service : IContract
    {
        public void SayHello(string name)
        {
            Console.WriteLine("Следуй за белым кроликом {0}", name);
        }

        public int Fib(int n)
        {
            Console.WriteLine("Расчёт числа Фибоначи...");
            int result = 0;
            int temp1 = 0;
            int temp2 = 1;
            for (int i = 2; i <= n; i++)
            {
                result = temp1 + temp2;
                Console.WriteLine($"Фибоначчи = {result}");
                temp1 = temp2;
                temp2 = result;
            }
            return result;
        }
    }
}
