using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfServiceLibraryPOC3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void CreateStringKey(string keyName, string value);
        
        [OperationContract]
        void CreateDwordKey(string keyName, int value);

        [OperationContract]
        void ModifyStringKey(string keyName, string value);
        
        [OperationContract]
        void ModifyDwordKey(string keyName, int value);

        [OperationContract]
        void DeleteKey(string keyName);

        [OperationContract]
        object ReadKeyFromRegistry(string keyName);

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfServiceLibraryPOC3.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
