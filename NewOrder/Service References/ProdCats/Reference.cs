﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewOrder.ProdCats {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductClass", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ProductClass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Product_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Product_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Product_descField;
        
        private System.DateTime Prod_eff_dateField;
        
        private System.DateTime Prod_end_dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Service_IDField;
        
        private decimal RateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Product_ID {
            get {
                return this.Product_IDField;
            }
            set {
                if ((object.ReferenceEquals(this.Product_IDField, value) != true)) {
                    this.Product_IDField = value;
                    this.RaisePropertyChanged("Product_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Product_name {
            get {
                return this.Product_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.Product_nameField, value) != true)) {
                    this.Product_nameField = value;
                    this.RaisePropertyChanged("Product_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Product_desc {
            get {
                return this.Product_descField;
            }
            set {
                if ((object.ReferenceEquals(this.Product_descField, value) != true)) {
                    this.Product_descField = value;
                    this.RaisePropertyChanged("Product_desc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.DateTime Prod_eff_date {
            get {
                return this.Prod_eff_dateField;
            }
            set {
                if ((this.Prod_eff_dateField.Equals(value) != true)) {
                    this.Prod_eff_dateField = value;
                    this.RaisePropertyChanged("Prod_eff_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public System.DateTime Prod_end_date {
            get {
                return this.Prod_end_dateField;
            }
            set {
                if ((this.Prod_end_dateField.Equals(value) != true)) {
                    this.Prod_end_dateField = value;
                    this.RaisePropertyChanged("Prod_end_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Service_ID {
            get {
                return this.Service_IDField;
            }
            set {
                if ((object.ReferenceEquals(this.Service_IDField, value) != true)) {
                    this.Service_IDField = value;
                    this.RaisePropertyChanged("Service_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public decimal Rate {
            get {
                return this.RateField;
            }
            set {
                if ((this.RateField.Equals(value) != true)) {
                    this.RateField = value;
                    this.RaisePropertyChanged("Rate");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductRate", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ProductRate : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Product_IDField;
        
        private decimal RateField;
        
        private System.DateTime Rate_eff_dateField;
        
        private System.DateTime Rate_end_dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string State_codeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Product_ID {
            get {
                return this.Product_IDField;
            }
            set {
                if ((object.ReferenceEquals(this.Product_IDField, value) != true)) {
                    this.Product_IDField = value;
                    this.RaisePropertyChanged("Product_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal Rate {
            get {
                return this.RateField;
            }
            set {
                if ((this.RateField.Equals(value) != true)) {
                    this.RateField = value;
                    this.RaisePropertyChanged("Rate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime Rate_eff_date {
            get {
                return this.Rate_eff_dateField;
            }
            set {
                if ((this.Rate_eff_dateField.Equals(value) != true)) {
                    this.Rate_eff_dateField = value;
                    this.RaisePropertyChanged("Rate_eff_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime Rate_end_date {
            get {
                return this.Rate_end_dateField;
            }
            set {
                if ((this.Rate_end_dateField.Equals(value) != true)) {
                    this.Rate_end_dateField = value;
                    this.RaisePropertyChanged("Rate_end_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string State_code {
            get {
                return this.State_codeField;
            }
            set {
                if ((object.ReferenceEquals(this.State_codeField, value) != true)) {
                    this.State_codeField = value;
                    this.RaisePropertyChanged("State_code");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProdCats.GetAllProductsSoap")]
    public interface GetAllProductsSoap {
        
        // CODEGEN: Generating message contract since element name GetAllProductsListResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllProductsList", ReplyAction="*")]
        NewOrder.ProdCats.GetAllProductsListResponse GetAllProductsList(NewOrder.ProdCats.GetAllProductsListRequest request);
        
        // CODEGEN: Generating message contract since element name serviceid from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetProductsByServiceID", ReplyAction="*")]
        NewOrder.ProdCats.GetProductsByServiceIDResponse GetProductsByServiceID(NewOrder.ProdCats.GetProductsByServiceIDRequest request);
        
        // CODEGEN: Generating message contract since element name serviceid from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetProductsByZipAndServiceID", ReplyAction="*")]
        NewOrder.ProdCats.GetProductsByZipAndServiceIDResponse GetProductsByZipAndServiceID(NewOrder.ProdCats.GetProductsByZipAndServiceIDRequest request);
        
        // CODEGEN: Generating message contract since element name state_code from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetEnterpriseProducts", ReplyAction="*")]
        NewOrder.ProdCats.GetEnterpriseProductsResponse GetEnterpriseProducts(NewOrder.ProdCats.GetEnterpriseProductsRequest request);
        
        // CODEGEN: Generating message contract since element name GetProductRatesResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetProductRates", ReplyAction="*")]
        NewOrder.ProdCats.GetProductRatesResponse GetProductRates(NewOrder.ProdCats.GetProductRatesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllProductsListRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllProductsList", Namespace="http://tempuri.org/", Order=0)]
        public NewOrder.ProdCats.GetAllProductsListRequestBody Body;
        
        public GetAllProductsListRequest() {
        }
        
        public GetAllProductsListRequest(NewOrder.ProdCats.GetAllProductsListRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllProductsListRequestBody {
        
        public GetAllProductsListRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllProductsListResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllProductsListResponse", Namespace="http://tempuri.org/", Order=0)]
        public NewOrder.ProdCats.GetAllProductsListResponseBody Body;
        
        public GetAllProductsListResponse() {
        }
        
        public GetAllProductsListResponse(NewOrder.ProdCats.GetAllProductsListResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllProductsListResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public NewOrder.ProdCats.ProductClass[] GetAllProductsListResult;
        
        public GetAllProductsListResponseBody() {
        }
        
        public GetAllProductsListResponseBody(NewOrder.ProdCats.ProductClass[] GetAllProductsListResult) {
            this.GetAllProductsListResult = GetAllProductsListResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProductsByServiceIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProductsByServiceID", Namespace="http://tempuri.org/", Order=0)]
        public NewOrder.ProdCats.GetProductsByServiceIDRequestBody Body;
        
        public GetProductsByServiceIDRequest() {
        }
        
        public GetProductsByServiceIDRequest(NewOrder.ProdCats.GetProductsByServiceIDRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetProductsByServiceIDRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string serviceid;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string state_code;
        
        public GetProductsByServiceIDRequestBody() {
        }
        
        public GetProductsByServiceIDRequestBody(string serviceid, string state_code) {
            this.serviceid = serviceid;
            this.state_code = state_code;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProductsByServiceIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProductsByServiceIDResponse", Namespace="http://tempuri.org/", Order=0)]
        public NewOrder.ProdCats.GetProductsByServiceIDResponseBody Body;
        
        public GetProductsByServiceIDResponse() {
        }
        
        public GetProductsByServiceIDResponse(NewOrder.ProdCats.GetProductsByServiceIDResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetProductsByServiceIDResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public NewOrder.ProdCats.ProductClass[] GetProductsByServiceIDResult;
        
        public GetProductsByServiceIDResponseBody() {
        }
        
        public GetProductsByServiceIDResponseBody(NewOrder.ProdCats.ProductClass[] GetProductsByServiceIDResult) {
            this.GetProductsByServiceIDResult = GetProductsByServiceIDResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProductsByZipAndServiceIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProductsByZipAndServiceID", Namespace="http://tempuri.org/", Order=0)]
        public NewOrder.ProdCats.GetProductsByZipAndServiceIDRequestBody Body;
        
        public GetProductsByZipAndServiceIDRequest() {
        }
        
        public GetProductsByZipAndServiceIDRequest(NewOrder.ProdCats.GetProductsByZipAndServiceIDRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetProductsByZipAndServiceIDRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string serviceid;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int zip;
        
        public GetProductsByZipAndServiceIDRequestBody() {
        }
        
        public GetProductsByZipAndServiceIDRequestBody(string serviceid, int zip) {
            this.serviceid = serviceid;
            this.zip = zip;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProductsByZipAndServiceIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProductsByZipAndServiceIDResponse", Namespace="http://tempuri.org/", Order=0)]
        public NewOrder.ProdCats.GetProductsByZipAndServiceIDResponseBody Body;
        
        public GetProductsByZipAndServiceIDResponse() {
        }
        
        public GetProductsByZipAndServiceIDResponse(NewOrder.ProdCats.GetProductsByZipAndServiceIDResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetProductsByZipAndServiceIDResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public NewOrder.ProdCats.ProductClass[] GetProductsByZipAndServiceIDResult;
        
        public GetProductsByZipAndServiceIDResponseBody() {
        }
        
        public GetProductsByZipAndServiceIDResponseBody(NewOrder.ProdCats.ProductClass[] GetProductsByZipAndServiceIDResult) {
            this.GetProductsByZipAndServiceIDResult = GetProductsByZipAndServiceIDResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetEnterpriseProductsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetEnterpriseProducts", Namespace="http://tempuri.org/", Order=0)]
        public NewOrder.ProdCats.GetEnterpriseProductsRequestBody Body;
        
        public GetEnterpriseProductsRequest() {
        }
        
        public GetEnterpriseProductsRequest(NewOrder.ProdCats.GetEnterpriseProductsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetEnterpriseProductsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string state_code;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int zip;
        
        public GetEnterpriseProductsRequestBody() {
        }
        
        public GetEnterpriseProductsRequestBody(string state_code, int zip) {
            this.state_code = state_code;
            this.zip = zip;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetEnterpriseProductsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetEnterpriseProductsResponse", Namespace="http://tempuri.org/", Order=0)]
        public NewOrder.ProdCats.GetEnterpriseProductsResponseBody Body;
        
        public GetEnterpriseProductsResponse() {
        }
        
        public GetEnterpriseProductsResponse(NewOrder.ProdCats.GetEnterpriseProductsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetEnterpriseProductsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public NewOrder.ProdCats.ProductClass[] GetEnterpriseProductsResult;
        
        public GetEnterpriseProductsResponseBody() {
        }
        
        public GetEnterpriseProductsResponseBody(NewOrder.ProdCats.ProductClass[] GetEnterpriseProductsResult) {
            this.GetEnterpriseProductsResult = GetEnterpriseProductsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProductRatesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProductRates", Namespace="http://tempuri.org/", Order=0)]
        public NewOrder.ProdCats.GetProductRatesRequestBody Body;
        
        public GetProductRatesRequest() {
        }
        
        public GetProductRatesRequest(NewOrder.ProdCats.GetProductRatesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetProductRatesRequestBody {
        
        public GetProductRatesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProductRatesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProductRatesResponse", Namespace="http://tempuri.org/", Order=0)]
        public NewOrder.ProdCats.GetProductRatesResponseBody Body;
        
        public GetProductRatesResponse() {
        }
        
        public GetProductRatesResponse(NewOrder.ProdCats.GetProductRatesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetProductRatesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public NewOrder.ProdCats.ProductRate[] GetProductRatesResult;
        
        public GetProductRatesResponseBody() {
        }
        
        public GetProductRatesResponseBody(NewOrder.ProdCats.ProductRate[] GetProductRatesResult) {
            this.GetProductRatesResult = GetProductRatesResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface GetAllProductsSoapChannel : NewOrder.ProdCats.GetAllProductsSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetAllProductsSoapClient : System.ServiceModel.ClientBase<NewOrder.ProdCats.GetAllProductsSoap>, NewOrder.ProdCats.GetAllProductsSoap {
        
        public GetAllProductsSoapClient() {
        }
        
        public GetAllProductsSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GetAllProductsSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetAllProductsSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetAllProductsSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NewOrder.ProdCats.GetAllProductsListResponse NewOrder.ProdCats.GetAllProductsSoap.GetAllProductsList(NewOrder.ProdCats.GetAllProductsListRequest request) {
            return base.Channel.GetAllProductsList(request);
        }
        
        public NewOrder.ProdCats.ProductClass[] GetAllProductsList() {
            NewOrder.ProdCats.GetAllProductsListRequest inValue = new NewOrder.ProdCats.GetAllProductsListRequest();
            inValue.Body = new NewOrder.ProdCats.GetAllProductsListRequestBody();
            NewOrder.ProdCats.GetAllProductsListResponse retVal = ((NewOrder.ProdCats.GetAllProductsSoap)(this)).GetAllProductsList(inValue);
            return retVal.Body.GetAllProductsListResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NewOrder.ProdCats.GetProductsByServiceIDResponse NewOrder.ProdCats.GetAllProductsSoap.GetProductsByServiceID(NewOrder.ProdCats.GetProductsByServiceIDRequest request) {
            return base.Channel.GetProductsByServiceID(request);
        }
        
        public NewOrder.ProdCats.ProductClass[] GetProductsByServiceID(string serviceid, string state_code) {
            NewOrder.ProdCats.GetProductsByServiceIDRequest inValue = new NewOrder.ProdCats.GetProductsByServiceIDRequest();
            inValue.Body = new NewOrder.ProdCats.GetProductsByServiceIDRequestBody();
            inValue.Body.serviceid = serviceid;
            inValue.Body.state_code = state_code;
            NewOrder.ProdCats.GetProductsByServiceIDResponse retVal = ((NewOrder.ProdCats.GetAllProductsSoap)(this)).GetProductsByServiceID(inValue);
            return retVal.Body.GetProductsByServiceIDResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NewOrder.ProdCats.GetProductsByZipAndServiceIDResponse NewOrder.ProdCats.GetAllProductsSoap.GetProductsByZipAndServiceID(NewOrder.ProdCats.GetProductsByZipAndServiceIDRequest request) {
            return base.Channel.GetProductsByZipAndServiceID(request);
        }
        
        public NewOrder.ProdCats.ProductClass[] GetProductsByZipAndServiceID(string serviceid, int zip) {
            NewOrder.ProdCats.GetProductsByZipAndServiceIDRequest inValue = new NewOrder.ProdCats.GetProductsByZipAndServiceIDRequest();
            inValue.Body = new NewOrder.ProdCats.GetProductsByZipAndServiceIDRequestBody();
            inValue.Body.serviceid = serviceid;
            inValue.Body.zip = zip;
            NewOrder.ProdCats.GetProductsByZipAndServiceIDResponse retVal = ((NewOrder.ProdCats.GetAllProductsSoap)(this)).GetProductsByZipAndServiceID(inValue);
            return retVal.Body.GetProductsByZipAndServiceIDResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NewOrder.ProdCats.GetEnterpriseProductsResponse NewOrder.ProdCats.GetAllProductsSoap.GetEnterpriseProducts(NewOrder.ProdCats.GetEnterpriseProductsRequest request) {
            return base.Channel.GetEnterpriseProducts(request);
        }
        
        public NewOrder.ProdCats.ProductClass[] GetEnterpriseProducts(string state_code, int zip) {
            NewOrder.ProdCats.GetEnterpriseProductsRequest inValue = new NewOrder.ProdCats.GetEnterpriseProductsRequest();
            inValue.Body = new NewOrder.ProdCats.GetEnterpriseProductsRequestBody();
            inValue.Body.state_code = state_code;
            inValue.Body.zip = zip;
            NewOrder.ProdCats.GetEnterpriseProductsResponse retVal = ((NewOrder.ProdCats.GetAllProductsSoap)(this)).GetEnterpriseProducts(inValue);
            return retVal.Body.GetEnterpriseProductsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NewOrder.ProdCats.GetProductRatesResponse NewOrder.ProdCats.GetAllProductsSoap.GetProductRates(NewOrder.ProdCats.GetProductRatesRequest request) {
            return base.Channel.GetProductRates(request);
        }
        
        public NewOrder.ProdCats.ProductRate[] GetProductRates() {
            NewOrder.ProdCats.GetProductRatesRequest inValue = new NewOrder.ProdCats.GetProductRatesRequest();
            inValue.Body = new NewOrder.ProdCats.GetProductRatesRequestBody();
            NewOrder.ProdCats.GetProductRatesResponse retVal = ((NewOrder.ProdCats.GetAllProductsSoap)(this)).GetProductRates(inValue);
            return retVal.Body.GetProductRatesResult;
        }
    }
}