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
        Guid CreateClient(string name, string lastName, string PESEL, string address);

        [OperationContract]
        Client GetClientInformationById(Guid idClient);

        [OperationContract]
        Client GetClientInformationByName(string name, string lastName);

        [OperationContract]
        void RemoveClientByName(string name, string lastName);

        [OperationContract]
        void RemoveClientById(Guid idClient);
    }
    [DataContract]
    public class Client
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
