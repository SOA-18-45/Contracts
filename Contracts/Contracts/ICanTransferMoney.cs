using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;


namespace Contracts
{
    [ServiceContract]
    public interface ICanTransferMoney
    {
        [OperationContract]
        int TransferMoney(string AccountNumber1, string AccountNumber2, double value); //pozwala na wykonanie przelewu na podstawie numeru kont
        
        [OperationContract]
        int TransferMoneyGuid(Guid AccountGuid1, Guid AccountGuid2, double value); // pozwala na wykonanie przelewu na podstawie numeru Guid kont

        [OperationContract]
        List<HistoryItem> TransferHistory(DateTime DateFrom, DateTime DateTo, String AccountNumber); // pozwala na zwrócenie historii przelewów dla danego numeru konta w podanych zakresie czasowym

        [OperationContract]
        List<HistoryItem> TransferHistoryAccountGuid(DateTime DateFrom, DateTime DateTo, Guid AccountGuid); // pozwala na zwrócenie historii przelewów dla danego numeru Guid konta w podanych zakresie czasowym
        
        [OperationContract]
        List<HistoryItem> TransferHistory(DateTime DateFrom, DateTime DateTo); // pozwala na zwrócenie historii przelewów dla WSZYSTKICH kont w podanych zakresie czasowym
    }
    
    [DataContract]
    public class HistoryItem
    {
        [DataMember]
        public Guid ID { get; set; }
        [DataMember]
        public string AccountFrom { get; set; }
        [DataMember]
        public string AccountTo { get; set; }
        [DataMember]
        public double Value { get; set; }
        [DataMember]
        public DateTime TransactionDate { get; set; }
    }
}
