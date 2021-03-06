﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ATMS_Server
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/ATMS_Server")]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private bool BoolValueField;
        
        private string StringValueField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue
        {
            get
            {
                return this.BoolValueField;
            }
            set
            {
                this.BoolValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue
        {
            get
            {
                return this.StringValueField;
            }
            set
            {
                this.StringValueField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="ATMS_Server", ConfigurationName="IServerInterface", CallbackContract=typeof(IServerInterfaceCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
public interface IServerInterface
{
    
    [System.ServiceModel.OperationContractAttribute(Action="ATMS_Server/IServerInterface/GetData", ReplyAction="ATMS_Server/IServerInterface/GetDataResponse")]
    string GetData(int value);
    
    [System.ServiceModel.OperationContractAttribute(Action="ATMS_Server/IServerInterface/GetData", ReplyAction="ATMS_Server/IServerInterface/GetDataResponse")]
    System.Threading.Tasks.Task<string> GetDataAsync(int value);
    
    [System.ServiceModel.OperationContractAttribute(Action="ATMS_Server/IServerInterface/ReturnPoke", ReplyAction="ATMS_Server/IServerInterface/ReturnPokeResponse")]
    string ReturnPoke();
    
    [System.ServiceModel.OperationContractAttribute(Action="ATMS_Server/IServerInterface/ReturnPoke", ReplyAction="ATMS_Server/IServerInterface/ReturnPokeResponse")]
    System.Threading.Tasks.Task<string> ReturnPokeAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="ATMS_Server/IServerInterface/getListOfUsers", ReplyAction="ATMS_Server/IServerInterface/getListOfUsersResponse")]
    string getListOfUsers();
    
    [System.ServiceModel.OperationContractAttribute(Action="ATMS_Server/IServerInterface/getListOfUsers", ReplyAction="ATMS_Server/IServerInterface/getListOfUsersResponse")]
    System.Threading.Tasks.Task<string> getListOfUsersAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="ATMS_Server/IServerInterface/GetDataUsingDataContract", ReplyAction="ATMS_Server/IServerInterface/GetDataUsingDataContractResponse")]
    ATMS_Server.CompositeType GetDataUsingDataContract(ATMS_Server.CompositeType composite);
    
    [System.ServiceModel.OperationContractAttribute(Action="ATMS_Server/IServerInterface/GetDataUsingDataContract", ReplyAction="ATMS_Server/IServerInterface/GetDataUsingDataContractResponse")]
    System.Threading.Tasks.Task<ATMS_Server.CompositeType> GetDataUsingDataContractAsync(ATMS_Server.CompositeType composite);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IServerInterfaceCallback
{
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="ATMS_Server/IServerInterface/updateClient")]
    void updateClient(string data);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IServerInterfaceChannel : IServerInterface, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class ServerInterfaceClient : System.ServiceModel.DuplexClientBase<IServerInterface>, IServerInterface
{
    
    public ServerInterfaceClient(System.ServiceModel.InstanceContext callbackInstance) : 
            base(callbackInstance)
    {
    }
    
    public ServerInterfaceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
            base(callbackInstance, endpointConfigurationName)
    {
    }
    
    public ServerInterfaceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
            base(callbackInstance, endpointConfigurationName, remoteAddress)
    {
    }
    
    public ServerInterfaceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(callbackInstance, endpointConfigurationName, remoteAddress)
    {
    }
    
    public ServerInterfaceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(callbackInstance, binding, remoteAddress)
    {
    }
    
    public string GetData(int value)
    {
        return base.Channel.GetData(value);
    }
    
    public System.Threading.Tasks.Task<string> GetDataAsync(int value)
    {
        return base.Channel.GetDataAsync(value);
    }
    
    public string ReturnPoke()
    {
        return base.Channel.ReturnPoke();
    }
    
    public System.Threading.Tasks.Task<string> ReturnPokeAsync()
    {
        return base.Channel.ReturnPokeAsync();
    }
    
    public string getListOfUsers()
    {
        return base.Channel.getListOfUsers();
    }
    
    public System.Threading.Tasks.Task<string> getListOfUsersAsync()
    {
        return base.Channel.getListOfUsersAsync();
    }
    
    public ATMS_Server.CompositeType GetDataUsingDataContract(ATMS_Server.CompositeType composite)
    {
        return base.Channel.GetDataUsingDataContract(composite);
    }
    
    public System.Threading.Tasks.Task<ATMS_Server.CompositeType> GetDataUsingDataContractAsync(ATMS_Server.CompositeType composite)
    {
        return base.Channel.GetDataUsingDataContractAsync(composite);
    }
}
