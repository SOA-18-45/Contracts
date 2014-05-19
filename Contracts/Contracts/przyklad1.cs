using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Contracts
{
    [ServiceContract]
    public interface IServiceRepository
    {
        void RegisterService(string serviceName, string serviceAddress);
        void UnregisterService(string serviceName);

        string GetServiceAddress(string serviceName);

        void IsAlive(string serviceName);
    }
}
