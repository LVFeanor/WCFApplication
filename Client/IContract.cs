using System;
using System.ServiceModel;

namespace Client
{
    [ServiceContract]
    interface IContract
    {
        [OperationContract]
        void SayHello(string name);
        [OperationContract]
        int Fib(int n);
    }
}
