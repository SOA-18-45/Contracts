using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Contracts
{
    [DataContract]
    public class AccountDetails
    {
        public Guid Id { get; set; }
        public string AccountNumber { get; set; }
        [DataMember]
        public int ClientId { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public long Money { get; set; }
        [DataMember]
        public string Pesel { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public double Percentage { get; set; }
        [DataMember]
        public DateTime EndDate { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }


    }

    [ServiceContract]
    public interface IAccountRepository
    {
        [OperationContract]
        long createAccount(int clientId, AccountDetails details);

        [OperationContract]
        AccountDetails getAccountInformation(long accountNumber);
    }
}
