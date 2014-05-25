using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;


namespace Contracts
{
    [ServiceContract]
    public interface ICanDoExternalTransfer
    {
        [OperationContract]
        bool TransferMoney(string clientAccountNumber, string recieverAccountNumber, double amount);

        [OperationContract]
        List<Transfer> GetPreviousTransfers(string accountNumber);
    }

    [DataContract]
    public class Transfer
    {
        [DataMember]
        public Guid ID { get; set; }
        
        [DataMember]
        public Guid clientID { get; set; }

        [DataMember]
        public string clientAccountNumber { get; set; }

        [DataMember]
        public string recieverAccountNumber { get; set; }

        [DataMember]
        public double amount { get; set; }

        [DataMember]
        public bool wasSuccessful { get; set; }

        [DataMember]
        public string description { get; set; }

        [DataMember]
        public DateTime date { get; set; }
    }

}