using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;


namespace Contracts
{
    [ServiceContract]
    public interface ICanTransferMoney
    {
        [OperationContract]
        int TransferMoney(string AccountNumber1, string AccountNumber2, decimal value); //pozwala na wykonanie przelewu na podstawie numeru kont
        
        [OperationContract]
        int TransferMoney(Guid AccountGuid1, Guid AccountGuid2, decimal value); // pozwala na wykonanie przelewu na podstawie numeru Guid kont

        [OperationContract]
        int TransferHistory(DateTime DateFrom, DateTime DateTo, String AccountNumber); // pozwala na zwrócenie historii przelewów dla danego numeru konta w podanych zakresie czasowym

        [OperationContract]
        int TransferHistory(DateTime DateFrom, DateTime DateTo, Guid AccountGuid); // pozwala na zwrócenie historii przelewów dla danego numeru Guid konta w podanych zakresie czasowym

        
        [OperationContract]
        int TransferHistory(DateTime DateFrom, DateTime DateTo); // pozwala na zwrócenie historii przelewów dla WSZYSTKICH kont w podanych zakresie czasowym
    }
}
