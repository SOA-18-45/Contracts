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
        int GetRORCount();
        [OperationContract]
        IEnumerable<BasicAccountInfo> GetAccounts();
        [OperationContract]
        bool AuditAll();
    }

    [DataContract]
    public class BasicAccountInfo
    {
        [DataMember]
        string AccountNumber;
        [DataMember]
        decimal money;
    }
}
