﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kgss_test.EHealth {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:be:fgov:ehealth:etee:kgss:1_0:protocol", ConfigurationName="EHealth.KgssPortType")]
    public interface KgssPortType {
        
        // CODEGEN: Generating message contract since the operation GetNewKey is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EteeResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RequestType))]
        kgss_test.EHealth.GetNewKeyResponse1 GetNewKey(kgss_test.EHealth.GetNewKeyRequest1 request);
        
        // CODEGEN: Generating message contract since the operation GetKey is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EteeResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RequestType))]
        kgss_test.EHealth.GetKeyResponse1 GetKey(kgss_test.EHealth.GetKeyRequest1 request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:be:fgov:ehealth:etee:kgss:1_0:protocol")]
    public partial class GetNewKeyRequest : RequestType {
        
        private SealedContentType sealedNewKeyRequestField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SealedContentType SealedNewKeyRequest {
            get {
                return this.sealedNewKeyRequestField;
            }
            set {
                this.sealedNewKeyRequestField = value;
                this.RaisePropertyChanged("SealedNewKeyRequest");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:be:fgov:ehealth:etee:kgss:1_0:protocol")]
    public partial class SealedContentType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private byte[] sealedContentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", Order=0)]
        public byte[] SealedContent {
            get {
                return this.sealedContentField;
            }
            set {
                this.sealedContentField = value;
                this.RaisePropertyChanged("SealedContent");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:be:fgov:ehealth:commons:1_0:core")]
    public partial class LocalisedString : object, System.ComponentModel.INotifyPropertyChanged {
        
        private LangageType langField;
        
        private bool langFieldSpecified;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public LangageType Lang {
            get {
                return this.langField;
            }
            set {
                this.langField = value;
                this.RaisePropertyChanged("Lang");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LangSpecified {
            get {
                return this.langFieldSpecified;
            }
            set {
                this.langFieldSpecified = value;
                this.RaisePropertyChanged("LangSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:be:fgov:ehealth:commons:1_0:core")]
    public enum LangageType {
        
        /// <remarks/>
        FR,
        
        /// <remarks/>
        NL,
        
        /// <remarks/>
        EN,
        
        /// <remarks/>
        DE,
        
        /// <remarks/>
        NA,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:be:fgov:ehealth:etee:commons:1_0:etee")]
    public partial class ErrorType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codeField;
        
        private LocalisedString[] messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("Code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Message", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public LocalisedString[] Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("Message");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:be:fgov:ehealth:etee:commons:1_0:etee")]
    public partial class EteeResponseType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private EteeResponseTypeStatus statusField;
        
        private ErrorType[] errorField;
        
        private string idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public EteeResponseTypeStatus Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("Status");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Error", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public ErrorType[] Error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
                this.RaisePropertyChanged("Error");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:be:fgov:ehealth:etee:commons:1_0:etee")]
    public partial class EteeResponseTypeStatus : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codeField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("Code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("Message");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:be:fgov:ehealth:commons:1_0:protocol")]
    public partial class RequestType : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:be:fgov:ehealth:etee:kgss:1_0:protocol")]
    public partial class GetNewKeyResponse : EteeResponseType {
        
        private SealedContentType sealedNewKeyResponseField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SealedContentType SealedNewKeyResponse {
            get {
                return this.sealedNewKeyResponseField;
            }
            set {
                this.sealedNewKeyResponseField = value;
                this.RaisePropertyChanged("SealedNewKeyResponse");
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetNewKeyRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:be:fgov:ehealth:etee:kgss:1_0:protocol", Order=0)]
        public kgss_test.EHealth.GetNewKeyRequest GetNewKeyRequest;
        
        public GetNewKeyRequest1() {
        }
        
        public GetNewKeyRequest1(kgss_test.EHealth.GetNewKeyRequest GetNewKeyRequest) {
            this.GetNewKeyRequest = GetNewKeyRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetNewKeyResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:be:fgov:ehealth:etee:kgss:1_0:protocol", Order=0)]
        public kgss_test.EHealth.GetNewKeyResponse GetNewKeyResponse;
        
        public GetNewKeyResponse1() {
        }
        
        public GetNewKeyResponse1(kgss_test.EHealth.GetNewKeyResponse GetNewKeyResponse) {
            this.GetNewKeyResponse = GetNewKeyResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:be:fgov:ehealth:etee:kgss:1_0:protocol")]
    public partial class GetKeyRequest : RequestType {
        
        private SealedContentType sealedKeyRequestField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SealedContentType SealedKeyRequest {
            get {
                return this.sealedKeyRequestField;
            }
            set {
                this.sealedKeyRequestField = value;
                this.RaisePropertyChanged("SealedKeyRequest");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:be:fgov:ehealth:etee:kgss:1_0:protocol")]
    public partial class GetKeyResponse : EteeResponseType {
        
        private SealedContentType sealedKeyResponseField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SealedContentType SealedKeyResponse {
            get {
                return this.sealedKeyResponseField;
            }
            set {
                this.sealedKeyResponseField = value;
                this.RaisePropertyChanged("SealedKeyResponse");
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetKeyRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:be:fgov:ehealth:etee:kgss:1_0:protocol", Order=0)]
        public kgss_test.EHealth.GetKeyRequest GetKeyRequest;
        
        public GetKeyRequest1() {
        }
        
        public GetKeyRequest1(kgss_test.EHealth.GetKeyRequest GetKeyRequest) {
            this.GetKeyRequest = GetKeyRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetKeyResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:be:fgov:ehealth:etee:kgss:1_0:protocol", Order=0)]
        public kgss_test.EHealth.GetKeyResponse GetKeyResponse;
        
        public GetKeyResponse1() {
        }
        
        public GetKeyResponse1(kgss_test.EHealth.GetKeyResponse GetKeyResponse) {
            this.GetKeyResponse = GetKeyResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface KgssPortTypeChannel : kgss_test.EHealth.KgssPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class KgssPortTypeClient : System.ServiceModel.ClientBase<kgss_test.EHealth.KgssPortType>, kgss_test.EHealth.KgssPortType {
        
        public KgssPortTypeClient() {
        }
        
        public KgssPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public KgssPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KgssPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KgssPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        kgss_test.EHealth.GetNewKeyResponse1 kgss_test.EHealth.KgssPortType.GetNewKey(kgss_test.EHealth.GetNewKeyRequest1 request) {
            return base.Channel.GetNewKey(request);
        }
        
        public kgss_test.EHealth.GetNewKeyResponse GetNewKey(kgss_test.EHealth.GetNewKeyRequest GetNewKeyRequest) {
            kgss_test.EHealth.GetNewKeyRequest1 inValue = new kgss_test.EHealth.GetNewKeyRequest1();
            inValue.GetNewKeyRequest = GetNewKeyRequest;
            kgss_test.EHealth.GetNewKeyResponse1 retVal = ((kgss_test.EHealth.KgssPortType)(this)).GetNewKey(inValue);
            return retVal.GetNewKeyResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        kgss_test.EHealth.GetKeyResponse1 kgss_test.EHealth.KgssPortType.GetKey(kgss_test.EHealth.GetKeyRequest1 request) {
            return base.Channel.GetKey(request);
        }
        
        public kgss_test.EHealth.GetKeyResponse GetKey(kgss_test.EHealth.GetKeyRequest GetKeyRequest) {
            kgss_test.EHealth.GetKeyRequest1 inValue = new kgss_test.EHealth.GetKeyRequest1();
            inValue.GetKeyRequest = GetKeyRequest;
            kgss_test.EHealth.GetKeyResponse1 retVal = ((kgss_test.EHealth.KgssPortType)(this)).GetKey(inValue);
            return retVal.GetKeyResponse;
        }
    }
}