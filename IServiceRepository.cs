using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Contracts
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    [ServiceContract]
    public interface IServiceRepository
    {
        [OperationContract]
        public void RegisterService(string name, string address);

        [OperationContract]
        public void UnregisterService(string name);

        [OperationContract]
        public string GetServiceLocation(string name);

        [OperationContract]
        public bool IsAlive(string name);
    }

    [DataContract]
    public class AccountInfo
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Address { get; set; }

    }
}