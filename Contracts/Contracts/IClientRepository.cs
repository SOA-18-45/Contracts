using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Contracts
{
    [ServiceContract]
    public interface IClientRepository
    {
        [OperationContract]
        long CreateClient(string name, string lastName, string PESEL, string address);

        [OperationContract]
        ServiceClient GetClientInformationById(Guid idClient);

        [OperationContract]
        ServiceClient GetClientInformationByName(string name, string lastName);

        [OperationContract]
        bool RemoveClientByName(string name, string lastName);

        [OperationContract]
        bool RemoveClientById(Guid idClient);
    }
    [DataContract]
    public class ServiceClient
    {
        [DataMember]
        public Guid IdClient { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Lastname { get; set; }
        [DataMember]
        public string PESEL { get; set; }
        [DataMember]
        public string address { get; set; }
    }
}
