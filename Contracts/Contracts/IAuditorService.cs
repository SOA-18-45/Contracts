using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{

    [ServiceContract]
    public interface IAudtitorService
    {
        [OperationContract]
        int GetClientCount();
        [OperationContract]
        int GetAccountCount();
        [OperationContract]
        int GetAccountCountByType(string type);
        [OperationContract]
        IEnumerable<BasicAccountInfo> GetAccounts();
        [OperationContract]
        IEnumerable<BasicAccountInfo> GetAccountsByType(string type);
        [OperationContract]
        IEnumerable<Audit> GetAllAuditsData();
    }

    [DataContract]
    public class BasicAccountInfo
    {
        [DataMember]
        string AccountNumber;
        [DataMember]
        decimal Money;
    }

    [DataContract]
    enum AuditType { ClientCount, AccountCount, AccountByTypeCount, Accounts, AccountsByType }

    [DataContract]
    public class Audit
    {
        [DataMember]
        string AuditDate;
        [DataMember]
        AuditType Type;
        [DataMember]
        string Auditor;
    }
}
