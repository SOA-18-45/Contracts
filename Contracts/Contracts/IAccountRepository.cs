using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Contracts
{
    [ServiceContract]
    public interface IAccountRepository
    {
        [OperationContract]
        string CreateAccount(Guid clientId, AccountDetails details);

        [OperationContract]
        AccountDetails GetAccountInformation(string accountNumber);

        [OperationContract]
        void UpdateAccountInformation(AccountDetails details);
    }

    [DataContract]
    public class AccountDetails
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public Guid ClientId { get; set; }
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
    }
}
