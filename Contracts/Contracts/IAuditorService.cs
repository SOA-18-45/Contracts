using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

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
        List<BasicAccountInfo> GetAccounts();
        [OperationContract]
        List<BasicAccountInfo> GetAccountsByType(string type);
        [OperationContract]
        List<Audit> GetAllAuditsData();
    }

    [DataContract]
    public class BasicAccountInfo
    {
        [DataMember]
        public string AccountNumber { get; set; }
        [DataMember]
        public double Money { get; set; }
    }

    [DataContract]
    public enum AuditType { ClientCount, AccountCount, AccountByTypeCount, Accounts, AccountsByType }

    [DataContract]
    public class Audit
    {
        [Key]
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string AuditDate { get; set; }
        [DataMember]
        public AuditType Type { get; set; }
    }
}
