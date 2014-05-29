using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Runtime.Serialization;


namespace Contracts
{
    [ServiceContract]
    public interface IDepositRepository
    {
        [OperationContract]
        Guid CreateDeposit(Guid ClientID, String AccountNumber, string DepositType, double InterestRate);
        [OperationContract]
        DepositDetails GetDepositDetails(Guid DepositID);
    }

    [DataContract]
    public class DepositDetails
    {
        [DataMember]
        public Guid DepositID { get; set; }
        [DataMember]
        public Guid ClientID { get; set; }
        [DataMember]
        public String AccountNumber { get; set; }
        [DataMember]
        public string DepositType { get; set; } // Current Account, Time Deposit
        [DataMember]
        public double InterestRate { get; set; }
        [DataMember]
        public DateTime CreationDate { get; set; }
    }
}
