﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClientTestWeb.WebServiceSample {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.52uyou.com/", ConfigurationName="WebServiceSample.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: 命名空间 http://www.52uyou.com/ 的元素名称 HelloWorldResult 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.52uyou.com/HelloWorld", ReplyAction="*")]
        WebClientTestWeb.WebServiceSample.HelloWorldResponse HelloWorld(WebClientTestWeb.WebServiceSample.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.52uyou.com/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WebClientTestWeb.WebServiceSample.HelloWorldResponse> HelloWorldAsync(WebClientTestWeb.WebServiceSample.HelloWorldRequest request);
        
        // CODEGEN: 命名空间 http://www.52uyou.com/ 的元素名称 message 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.52uyou.com/ReverseString", ReplyAction="*")]
        WebClientTestWeb.WebServiceSample.ReverseStringResponse ReverseString(WebClientTestWeb.WebServiceSample.ReverseStringRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.52uyou.com/ReverseString", ReplyAction="*")]
        System.Threading.Tasks.Task<WebClientTestWeb.WebServiceSample.ReverseStringResponse> ReverseStringAsync(WebClientTestWeb.WebServiceSample.ReverseStringRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://www.52uyou.com/", Order=0)]
        public WebClientTestWeb.WebServiceSample.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WebClientTestWeb.WebServiceSample.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://www.52uyou.com/", Order=0)]
        public WebClientTestWeb.WebServiceSample.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WebClientTestWeb.WebServiceSample.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.52uyou.com/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReverseStringRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReverseString", Namespace="http://www.52uyou.com/", Order=0)]
        public WebClientTestWeb.WebServiceSample.ReverseStringRequestBody Body;
        
        public ReverseStringRequest() {
        }
        
        public ReverseStringRequest(WebClientTestWeb.WebServiceSample.ReverseStringRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.52uyou.com/")]
    public partial class ReverseStringRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string message;
        
        public ReverseStringRequestBody() {
        }
        
        public ReverseStringRequestBody(string message) {
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReverseStringResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReverseStringResponse", Namespace="http://www.52uyou.com/", Order=0)]
        public WebClientTestWeb.WebServiceSample.ReverseStringResponseBody Body;
        
        public ReverseStringResponse() {
        }
        
        public ReverseStringResponse(WebClientTestWeb.WebServiceSample.ReverseStringResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.52uyou.com/")]
    public partial class ReverseStringResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ReverseStringResult;
        
        public ReverseStringResponseBody() {
        }
        
        public ReverseStringResponseBody(string ReverseStringResult) {
            this.ReverseStringResult = ReverseStringResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WebClientTestWeb.WebServiceSample.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WebClientTestWeb.WebServiceSample.WebService1Soap>, WebClientTestWeb.WebServiceSample.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClientTestWeb.WebServiceSample.HelloWorldResponse WebClientTestWeb.WebServiceSample.WebService1Soap.HelloWorld(WebClientTestWeb.WebServiceSample.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WebClientTestWeb.WebServiceSample.HelloWorldRequest inValue = new WebClientTestWeb.WebServiceSample.HelloWorldRequest();
            inValue.Body = new WebClientTestWeb.WebServiceSample.HelloWorldRequestBody();
            WebClientTestWeb.WebServiceSample.HelloWorldResponse retVal = ((WebClientTestWeb.WebServiceSample.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebClientTestWeb.WebServiceSample.HelloWorldResponse> WebClientTestWeb.WebServiceSample.WebService1Soap.HelloWorldAsync(WebClientTestWeb.WebServiceSample.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebClientTestWeb.WebServiceSample.HelloWorldResponse> HelloWorldAsync() {
            WebClientTestWeb.WebServiceSample.HelloWorldRequest inValue = new WebClientTestWeb.WebServiceSample.HelloWorldRequest();
            inValue.Body = new WebClientTestWeb.WebServiceSample.HelloWorldRequestBody();
            return ((WebClientTestWeb.WebServiceSample.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClientTestWeb.WebServiceSample.ReverseStringResponse WebClientTestWeb.WebServiceSample.WebService1Soap.ReverseString(WebClientTestWeb.WebServiceSample.ReverseStringRequest request) {
            return base.Channel.ReverseString(request);
        }
        
        public string ReverseString(string message) {
            WebClientTestWeb.WebServiceSample.ReverseStringRequest inValue = new WebClientTestWeb.WebServiceSample.ReverseStringRequest();
            inValue.Body = new WebClientTestWeb.WebServiceSample.ReverseStringRequestBody();
            inValue.Body.message = message;
            WebClientTestWeb.WebServiceSample.ReverseStringResponse retVal = ((WebClientTestWeb.WebServiceSample.WebService1Soap)(this)).ReverseString(inValue);
            return retVal.Body.ReverseStringResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebClientTestWeb.WebServiceSample.ReverseStringResponse> WebClientTestWeb.WebServiceSample.WebService1Soap.ReverseStringAsync(WebClientTestWeb.WebServiceSample.ReverseStringRequest request) {
            return base.Channel.ReverseStringAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebClientTestWeb.WebServiceSample.ReverseStringResponse> ReverseStringAsync(string message) {
            WebClientTestWeb.WebServiceSample.ReverseStringRequest inValue = new WebClientTestWeb.WebServiceSample.ReverseStringRequest();
            inValue.Body = new WebClientTestWeb.WebServiceSample.ReverseStringRequestBody();
            inValue.Body.message = message;
            return ((WebClientTestWeb.WebServiceSample.WebService1Soap)(this)).ReverseStringAsync(inValue);
        }
    }
}
