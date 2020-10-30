﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace PruebaWSStat.WebReference {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SUtiFolioStatBinding", Namespace="http://www.comex.com/Util/ws/SUtiFolioStatWSDL")]
    public partial class SUtiFolioStatBindingQSService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback consultarFoliosStatOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SUtiFolioStatBindingQSService() {
            this.Url = global::PruebaWSStat.Properties.Settings.Default.PruebaWSStat_WebReference_SUtiFolioStatBindingQSService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event consultarFoliosStatCompletedEventHandler consultarFoliosStatCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("consultarFoliosStat", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlArrayAttribute("DBA_ConsultarStatsOutputCollection", Namespace="http://xmlns.oracle.com/pcbpel/adapter/db/DBA_ConsultarStats")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public DBA_ConsultarStatsOutput[] consultarFoliosStat([System.Xml.Serialization.XmlElementAttribute(Namespace="http://xmlns.oracle.com/pcbpel/adapter/db/DBA_ConsultarStats")] DBA_ConsultarStatsInput DBA_ConsultarStatsInput) {
            object[] results = this.Invoke("consultarFoliosStat", new object[] {
                        DBA_ConsultarStatsInput});
            return ((DBA_ConsultarStatsOutput[])(results[0]));
        }
        
        /// <remarks/>
        public void consultarFoliosStatAsync(DBA_ConsultarStatsInput DBA_ConsultarStatsInput) {
            this.consultarFoliosStatAsync(DBA_ConsultarStatsInput, null);
        }
        
        /// <remarks/>
        public void consultarFoliosStatAsync(DBA_ConsultarStatsInput DBA_ConsultarStatsInput, object userState) {
            if ((this.consultarFoliosStatOperationCompleted == null)) {
                this.consultarFoliosStatOperationCompleted = new System.Threading.SendOrPostCallback(this.OnconsultarFoliosStatOperationCompleted);
            }
            this.InvokeAsync("consultarFoliosStat", new object[] {
                        DBA_ConsultarStatsInput}, this.consultarFoliosStatOperationCompleted, userState);
        }
        
        private void OnconsultarFoliosStatOperationCompleted(object arg) {
            if ((this.consultarFoliosStatCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.consultarFoliosStatCompleted(this, new consultarFoliosStatCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmlns.oracle.com/pcbpel/adapter/db/DBA_ConsultarStats")]
    public partial class DBA_ConsultarStatsInput {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xmlns.oracle.com/pcbpel/adapter/db/DBA_ConsultarStats")]
    public partial class DBA_ConsultarStatsOutput {
        
        private string stat_folioField;
        
        private string tracking_numberField;
        
        private string appl_cdField;
        
        private string descr_shortField;
        
        private string update_dtField;
        
        private string update_userField;
        
        private string csr_status_cdField;
        
        private string descrField;
        
        private string assigned_userField;
        
        private string open_userField;
        
        private string proj_cdField;
        
        private string tipo_folioField;
        
        private string open_dateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string stat_folio {
            get {
                return this.stat_folioField;
            }
            set {
                this.stat_folioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string tracking_number {
            get {
                return this.tracking_numberField;
            }
            set {
                this.tracking_numberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string appl_cd {
            get {
                return this.appl_cdField;
            }
            set {
                this.appl_cdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string descr_short {
            get {
                return this.descr_shortField;
            }
            set {
                this.descr_shortField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string update_dt {
            get {
                return this.update_dtField;
            }
            set {
                this.update_dtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string update_user {
            get {
                return this.update_userField;
            }
            set {
                this.update_userField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string csr_status_cd {
            get {
                return this.csr_status_cdField;
            }
            set {
                this.csr_status_cdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string descr {
            get {
                return this.descrField;
            }
            set {
                this.descrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string assigned_user {
            get {
                return this.assigned_userField;
            }
            set {
                this.assigned_userField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string open_user {
            get {
                return this.open_userField;
            }
            set {
                this.open_userField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string proj_cd {
            get {
                return this.proj_cdField;
            }
            set {
                this.proj_cdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string tipo_folio {
            get {
                return this.tipo_folioField;
            }
            set {
                this.tipo_folioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string open_date {
            get {
                return this.open_dateField;
            }
            set {
                this.open_dateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void consultarFoliosStatCompletedEventHandler(object sender, consultarFoliosStatCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class consultarFoliosStatCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal consultarFoliosStatCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DBA_ConsultarStatsOutput[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DBA_ConsultarStatsOutput[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591