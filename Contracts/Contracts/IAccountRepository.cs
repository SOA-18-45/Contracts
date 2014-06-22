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
        string CreateAccount(string pesel, AccountDetails details); //returns null if fails

        //[OperationContract]
        //string CreateAccountByName(string firstName, string lastName, AccountDetails details); //returns null if fails

        [OperationContract]
        AccountDetails GetAccountInformation(string accountNumber); //returns null if fails

        [OperationContract]
        List<AccountDetails> GetAccountsById(Guid clientId); //returns null if fails

        [OperationContract]
        List<AccountDetails> GetAllAccounts(); //returns null if fails

        [OperationContract]
        bool UpdateAccountInformation(AccountDetails details); //returns 'false' if fails
    }

    public class AccountRepositoryMessage
    {
        public string Action { get; set; }
        public string Arguments { get; set; }
    }

    public class CreateAccountMessage
    {
        public string Pesel { get; set; }
        public AccountDetails AccountDetails { get; set; }
    }

    public class GetAccountInformationMessage
    {
        public string AccountNumber { get; set; }
    }

    public class GetAccountsByIdMessage
    {
        public Guid ClientID { get; set; }
    }

    public class UpdateAccountInformationMessage
    {
        public AccountDetails AccountDetails { get; set; }
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
