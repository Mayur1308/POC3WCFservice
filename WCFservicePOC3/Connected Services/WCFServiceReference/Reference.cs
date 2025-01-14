﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFservicePOC3.WCFServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateStringKey", ReplyAction="http://tempuri.org/IService1/CreateStringKeyResponse")]
        void CreateStringKey(string keyName, string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateStringKey", ReplyAction="http://tempuri.org/IService1/CreateStringKeyResponse")]
        System.Threading.Tasks.Task CreateStringKeyAsync(string keyName, string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateDwordKey", ReplyAction="http://tempuri.org/IService1/CreateDwordKeyResponse")]
        void CreateDwordKey(string keyName, int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateDwordKey", ReplyAction="http://tempuri.org/IService1/CreateDwordKeyResponse")]
        System.Threading.Tasks.Task CreateDwordKeyAsync(string keyName, int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ModifyStringKey", ReplyAction="http://tempuri.org/IService1/ModifyStringKeyResponse")]
        void ModifyStringKey(string keyName, string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ModifyStringKey", ReplyAction="http://tempuri.org/IService1/ModifyStringKeyResponse")]
        System.Threading.Tasks.Task ModifyStringKeyAsync(string keyName, string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ModifyDwordKey", ReplyAction="http://tempuri.org/IService1/ModifyDwordKeyResponse")]
        void ModifyDwordKey(string keyName, int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ModifyDwordKey", ReplyAction="http://tempuri.org/IService1/ModifyDwordKeyResponse")]
        System.Threading.Tasks.Task ModifyDwordKeyAsync(string keyName, int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteKey", ReplyAction="http://tempuri.org/IService1/DeleteKeyResponse")]
        void DeleteKey(string keyName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteKey", ReplyAction="http://tempuri.org/IService1/DeleteKeyResponse")]
        System.Threading.Tasks.Task DeleteKeyAsync(string keyName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReadKeyFromRegistry", ReplyAction="http://tempuri.org/IService1/ReadKeyFromRegistryResponse")]
        object ReadKeyFromRegistry(string keyName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReadKeyFromRegistry", ReplyAction="http://tempuri.org/IService1/ReadKeyFromRegistryResponse")]
        System.Threading.Tasks.Task<object> ReadKeyFromRegistryAsync(string keyName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WCFservicePOC3.WCFServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WCFservicePOC3.WCFServiceReference.IService1>, WCFservicePOC3.WCFServiceReference.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void CreateStringKey(string keyName, string value) {
            base.Channel.CreateStringKey(keyName, value);
        }
        
        public System.Threading.Tasks.Task CreateStringKeyAsync(string keyName, string value) {
            return base.Channel.CreateStringKeyAsync(keyName, value);
        }
        
        public void CreateDwordKey(string keyName, int value) {
            base.Channel.CreateDwordKey(keyName, value);
        }
        
        public System.Threading.Tasks.Task CreateDwordKeyAsync(string keyName, int value) {
            return base.Channel.CreateDwordKeyAsync(keyName, value);
        }
        
        public void ModifyStringKey(string keyName, string value) {
            base.Channel.ModifyStringKey(keyName, value);
        }
        
        public System.Threading.Tasks.Task ModifyStringKeyAsync(string keyName, string value) {
            return base.Channel.ModifyStringKeyAsync(keyName, value);
        }
        
        public void ModifyDwordKey(string keyName, int value) {
            base.Channel.ModifyDwordKey(keyName, value);
        }
        
        public System.Threading.Tasks.Task ModifyDwordKeyAsync(string keyName, int value) {
            return base.Channel.ModifyDwordKeyAsync(keyName, value);
        }
        
        public void DeleteKey(string keyName) {
            base.Channel.DeleteKey(keyName);
        }
        
        public System.Threading.Tasks.Task DeleteKeyAsync(string keyName) {
            return base.Channel.DeleteKeyAsync(keyName);
        }
        
        public object ReadKeyFromRegistry(string keyName) {
            return base.Channel.ReadKeyFromRegistry(keyName);
        }
        
        public System.Threading.Tasks.Task<object> ReadKeyFromRegistryAsync(string keyName) {
            return base.Channel.ReadKeyFromRegistryAsync(keyName);
        }
    }
}
