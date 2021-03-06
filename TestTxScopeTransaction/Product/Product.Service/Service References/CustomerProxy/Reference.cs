﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Product.Service.CustomerProxy {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerInfo", Namespace="http://schemas.datacontract.org/2004/07/Customer.Domain")]
    [System.SerializableAttribute()]
    public partial class CustomerInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal MoneyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Money {
            get {
                return this.MoneyField;
            }
            set {
                if ((this.MoneyField.Equals(value) != true)) {
                    this.MoneyField = value;
                    this.RaisePropertyChanged("Money");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomerProxy.ICustomerContract", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface ICustomerContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerContract/Get", ReplyAction="http://tempuri.org/ICustomerContract/GetResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Product.Service.CustomerProxy.CustomerInfo))]
        Product.Service.CustomerProxy.CustomerInfo Get(object id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerContract/Save", ReplyAction="http://tempuri.org/ICustomerContract/SaveResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Product.Service.CustomerProxy.CustomerInfo))]
        object Save(Product.Service.CustomerProxy.CustomerInfo entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerContract/Update", ReplyAction="http://tempuri.org/ICustomerContract/UpdateResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        void Update(Product.Service.CustomerProxy.CustomerInfo entity);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerContractChannel : Product.Service.CustomerProxy.ICustomerContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerContractClient : System.ServiceModel.ClientBase<Product.Service.CustomerProxy.ICustomerContract>, Product.Service.CustomerProxy.ICustomerContract {
        
        public CustomerContractClient() {
        }
        
        public CustomerContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Product.Service.CustomerProxy.CustomerInfo Get(object id) {
            return base.Channel.Get(id);
        }
        
        public object Save(Product.Service.CustomerProxy.CustomerInfo entity) {
            return base.Channel.Save(entity);
        }
        
        public void Update(Product.Service.CustomerProxy.CustomerInfo entity) {
            base.Channel.Update(entity);
        }
    }
}
