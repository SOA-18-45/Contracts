using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Contracts
{
 
    [ServiceContract]
    public interface IClientService
    {
        [OperationContract]
        Client getClientInfo(Guid id);

    }

    /*
     * Dogadajcie się z IClientRepository jak ma wyglądać klasa Client. 
     * 
    */
    /*
    [DataContract]
    public class Client
    {
        [DataMember]
        public Guid ClientId { get; set; }

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Lastname { get; set; }
        [DataMember]
        public string PESEL { get; set; }
        [DataMember]
        public string address { get; set; }

        [DataMember]
        public string AccountNumber { get; set; }
        [DataMember]
        public double Money { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public double Percentage { get; set; }
        [DataMember]
        public DateTime EndDate { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
   
        [DataMember]
        public Guid DepositID { get; set; }
        [DataMember]
        public string DepositType { get; set; } 
        [DataMember]
        public double InterestRate { get; set; }
        [DataMember]
        public DateTime CreationDate { get; set; }

    }
    */
     
}
