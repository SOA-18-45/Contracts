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
        
        [DataMember]
        public string BindingType { get; set; }
    }

    [ServiceContract]
    public interface IServiceRepository
    {
        [OperationContract]
        void registerService(string serviceName, string serviceAddress, string bindingType);

        [OperationContract]
        void unregisterService(string serviceName);

        [OperationContract]
        string getServiceAddress(string serviceName, string bindingType);

        [OperationContract]
        void isAlive(string serviceName);
    }
}
