﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GPH_QuickMessageServiceClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="GPH_QuickMessageServiceLib", ConfigurationName="ServiceReference1.GPH_QuickMessageService", CallbackContract=typeof(GPH_QuickMessageServiceCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface GPH_QuickMessageService {
        
        [System.ServiceModel.OperationContractAttribute(Action="GPH_QuickMessageServiceLib/GPH_QuickMessageService/JoinTheConversation", ReplyAction="GPH_QuickMessageServiceLib/GPH_QuickMessageService/JoinTheConversationResponse")]
        int JoinTheConversation(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="GPH_QuickMessageServiceLib/GPH_QuickMessageService/JoinTheConversation", ReplyAction="GPH_QuickMessageServiceLib/GPH_QuickMessageService/JoinTheConversationResponse")]
        System.Threading.Tasks.Task<int> JoinTheConversationAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GPH_QuickMessageServiceLib/GPH_QuickMessageService/ReceiveMessage")]
        void ReceiveMessage(string userName, string[] addressList, string userMessage);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GPH_QuickMessageServiceLib/GPH_QuickMessageService/ReceiveMessage")]
        System.Threading.Tasks.Task ReceiveMessageAsync(string userName, string[] addressList, string userMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="GPH_QuickMessageServiceLib/GPH_QuickMessageService/LeaveTheConversation", ReplyAction="GPH_QuickMessageServiceLib/GPH_QuickMessageService/LeaveTheConversationResponse")]
        int LeaveTheConversation(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="GPH_QuickMessageServiceLib/GPH_QuickMessageService/LeaveTheConversation", ReplyAction="GPH_QuickMessageServiceLib/GPH_QuickMessageService/LeaveTheConversationResponse")]
        System.Threading.Tasks.Task<int> LeaveTheConversationAsync(string userName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface GPH_QuickMessageServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GPH_QuickMessageServiceLib/GPH_QuickMessageService/NotifyUserJoinedTheConversatio" +
            "n")]
        void NotifyUserJoinedTheConversation(string userName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GPH_QuickMessageServiceLib/GPH_QuickMessageService/NotifyUserOfMessage")]
        void NotifyUserOfMessage(string userName, string userMessage);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GPH_QuickMessageServiceLib/GPH_QuickMessageService/NotifyUserLeftTheConversation")]
        void NotifyUserLeftTheConversation(string userName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface GPH_QuickMessageServiceChannel : GPH_QuickMessageService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GPH_QuickMessageServiceClient : System.ServiceModel.DuplexClientBase<GPH_QuickMessageService>, GPH_QuickMessageService {
        
        public GPH_QuickMessageServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public GPH_QuickMessageServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public GPH_QuickMessageServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public GPH_QuickMessageServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public GPH_QuickMessageServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public int JoinTheConversation(string userName) {
            return base.Channel.JoinTheConversation(userName);
        }
        
        public System.Threading.Tasks.Task<int> JoinTheConversationAsync(string userName) {
            return base.Channel.JoinTheConversationAsync(userName);
        }
        
        public void ReceiveMessage(string userName, string[] addressList, string userMessage) {
            base.Channel.ReceiveMessage(userName, addressList, userMessage);
        }
        
        public System.Threading.Tasks.Task ReceiveMessageAsync(string userName, string[] addressList, string userMessage) {
            return base.Channel.ReceiveMessageAsync(userName, addressList, userMessage);
        }
        
        public int LeaveTheConversation(string userName) {
            return base.Channel.LeaveTheConversation(userName);
        }
        
        public System.Threading.Tasks.Task<int> LeaveTheConversationAsync(string userName) {
            return base.Channel.LeaveTheConversationAsync(userName);
        }
    }
}
