﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TransferGuardConsoleApplication.TransferGuardServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResultRequest", Namespace="http://hl7.paml.com/ws/")]
    [System.SerializableAttribute()]
    public partial class ResultRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string SiteIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string SiteID {
            get {
                return this.SiteIDField;
            }
            set {
                if ((object.ReferenceEquals(this.SiteIDField, value) != true)) {
                    this.SiteIDField = value;
                    this.RaisePropertyChanged("SiteID");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResultResponse", Namespace="http://hl7.paml.com/ws/")]
    [System.SerializableAttribute()]
    public partial class ResultResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private TransferGuardConsoleApplication.TransferGuardServiceReference.Result[] ResultsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public TransferGuardConsoleApplication.TransferGuardServiceReference.Result[] Results {
            get {
                return this.ResultsField;
            }
            set {
                if ((object.ReferenceEquals(this.ResultsField, value) != true)) {
                    this.ResultsField = value;
                    this.RaisePropertyChanged("Results");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Result", Namespace="http://hl7.paml.com/ws/")]
    [System.SerializableAttribute()]
    public partial class Result : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string HL7MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string HL7Message {
            get {
                return this.HL7MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.HL7MessageField, value) != true)) {
                    this.HL7MessageField = value;
                    this.RaisePropertyChanged("HL7Message");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderRequest", Namespace="http://hl7.paml.com/ws/")]
    [System.SerializableAttribute()]
    public partial class OrderRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string HL7MessageField;
        
        private string SiteIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string HL7Message {
            get {
                return this.HL7MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.HL7MessageField, value) != true)) {
                    this.HL7MessageField = value;
                    this.RaisePropertyChanged("HL7Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string SiteID {
            get {
                return this.SiteIDField;
            }
            set {
                if ((object.ReferenceEquals(this.SiteIDField, value) != true)) {
                    this.SiteIDField = value;
                    this.RaisePropertyChanged("SiteID");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderResponse", Namespace="http://hl7.paml.com/ws/")]
    [System.SerializableAttribute()]
    public partial class OrderResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string MessageIDField;
        
        private string SiteIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string MessageID {
            get {
                return this.MessageIDField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageIDField, value) != true)) {
                    this.MessageIDField = value;
                    this.RaisePropertyChanged("MessageID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string SiteID {
            get {
                return this.SiteIDField;
            }
            set {
                if ((object.ReferenceEquals(this.SiteIDField, value) != true)) {
                    this.SiteIDField = value;
                    this.RaisePropertyChanged("SiteID");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://hl7.paml.com/ws/", ConfigurationName="TransferGuardServiceReference.ITransferService")]
    public interface ITransferService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hl7.paml.com/ws/ITransferService/GetPendingResultCount", ReplyAction="http://hl7.paml.com/ws/ITransferService/GetPendingResultCountResponse")]
        int GetPendingResultCount(TransferGuardConsoleApplication.TransferGuardServiceReference.ResultRequest resultRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hl7.paml.com/ws/ITransferService/GetResults", ReplyAction="http://hl7.paml.com/ws/ITransferService/GetResultsResponse")]
        TransferGuardConsoleApplication.TransferGuardServiceReference.ResultResponse GetResults(TransferGuardConsoleApplication.TransferGuardServiceReference.ResultRequest resultRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hl7.paml.com/ws/ITransferService/GetBase64Results", ReplyAction="http://hl7.paml.com/ws/ITransferService/GetBase64ResultsResponse")]
        TransferGuardConsoleApplication.TransferGuardServiceReference.ResultResponse GetBase64Results(TransferGuardConsoleApplication.TransferGuardServiceReference.ResultRequest resultRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hl7.paml.com/ws/ITransferService/PlaceOrder", ReplyAction="http://hl7.paml.com/ws/ITransferService/PlaceOrderResponse")]
        TransferGuardConsoleApplication.TransferGuardServiceReference.OrderResponse PlaceOrder(TransferGuardConsoleApplication.TransferGuardServiceReference.OrderRequest orderRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hl7.paml.com/ws/ITransferService/PlaceBase64Order", ReplyAction="http://hl7.paml.com/ws/ITransferService/PlaceBase64OrderResponse")]
        TransferGuardConsoleApplication.TransferGuardServiceReference.OrderResponse PlaceBase64Order(TransferGuardConsoleApplication.TransferGuardServiceReference.OrderRequest orderRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hl7.paml.com/ws/ITransferService/GetVersion", ReplyAction="http://hl7.paml.com/ws/ITransferService/GetVersionResponse")]
        string GetVersion();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITransferServiceChannel : TransferGuardConsoleApplication.TransferGuardServiceReference.ITransferService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TransferServiceClient : System.ServiceModel.ClientBase<TransferGuardConsoleApplication.TransferGuardServiceReference.ITransferService>, TransferGuardConsoleApplication.TransferGuardServiceReference.ITransferService {
        
        public TransferServiceClient() {
        }
        
        public TransferServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TransferServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TransferServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TransferServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetPendingResultCount(TransferGuardConsoleApplication.TransferGuardServiceReference.ResultRequest resultRequest) {
            return base.Channel.GetPendingResultCount(resultRequest);
        }
        
        public TransferGuardConsoleApplication.TransferGuardServiceReference.ResultResponse GetResults(TransferGuardConsoleApplication.TransferGuardServiceReference.ResultRequest resultRequest) {
            return base.Channel.GetResults(resultRequest);
        }
        
        public TransferGuardConsoleApplication.TransferGuardServiceReference.ResultResponse GetBase64Results(TransferGuardConsoleApplication.TransferGuardServiceReference.ResultRequest resultRequest) {
            return base.Channel.GetBase64Results(resultRequest);
        }
        
        public TransferGuardConsoleApplication.TransferGuardServiceReference.OrderResponse PlaceOrder(TransferGuardConsoleApplication.TransferGuardServiceReference.OrderRequest orderRequest) {
            return base.Channel.PlaceOrder(orderRequest);
        }
        
        public TransferGuardConsoleApplication.TransferGuardServiceReference.OrderResponse PlaceBase64Order(TransferGuardConsoleApplication.TransferGuardServiceReference.OrderRequest orderRequest) {
            return base.Channel.PlaceBase64Order(orderRequest);
        }
        
        public string GetVersion() {
            return base.Channel.GetVersion();
        }
    }
}
