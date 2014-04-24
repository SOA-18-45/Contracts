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
        int TransferMoney(long accountNumber1, long accountNumber2, decimal value);
    }
}
