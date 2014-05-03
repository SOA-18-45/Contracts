using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Contracts
{
    [DataContract]
    public class AccountInfo
    {
        [DataMember]
        public string ServiceName { get; set; }

        [DataMember]
        public string ServiceAddress { get; set; }
    }

    [ServiceContract]
    public interface IServiceRepository
    {
        [OperationContract]
        public void registerService(string serviceName, string serviceAddress);

        [OperationContract]
        public void unregisterService(string serviceName);

        [OperationContract]
        public string getServiceAddress(string serviceName);

        [OperationContract]
        public void isAlive(string serviceName);
    }
}
