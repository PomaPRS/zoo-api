﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZooSoapClient.AnimalService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AnimalType", Namespace="http://schemas.datacontract.org/2004/07/ZooSoapServer")]
    public enum AnimalType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Cat = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Dog = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Animal", Namespace="http://schemas.datacontract.org/2004/07/ZooSoapServer")]
    [System.SerializableAttribute()]
    public partial class Animal : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ZooSoapClient.AnimalService.Appearance AppearanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ZooSoapClient.AnimalService.AnimalType TypeField;
        
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
        public ZooSoapClient.AnimalService.Appearance Appearance {
            get {
                return this.AppearanceField;
            }
            set {
                if ((object.ReferenceEquals(this.AppearanceField, value) != true)) {
                    this.AppearanceField = value;
                    this.RaisePropertyChanged("Appearance");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ZooSoapClient.AnimalService.AnimalType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Appearance", Namespace="http://schemas.datacontract.org/2004/07/ZooSoapServer")]
    [System.SerializableAttribute()]
    public partial class Appearance : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double HeightMetersField;
        
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
        public string Color {
            get {
                return this.ColorField;
            }
            set {
                if ((object.ReferenceEquals(this.ColorField, value) != true)) {
                    this.ColorField = value;
                    this.RaisePropertyChanged("Color");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double HeightMeters {
            get {
                return this.HeightMetersField;
            }
            set {
                if ((this.HeightMetersField.Equals(value) != true)) {
                    this.HeightMetersField = value;
                    this.RaisePropertyChanged("HeightMeters");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AnimalService.IAnimalService")]
    public interface IAnimalService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnimalService/GetFavoriteAnimal", ReplyAction="http://tempuri.org/IAnimalService/GetFavoriteAnimalResponse")]
        ZooSoapClient.AnimalService.Animal GetFavoriteAnimal(ZooSoapClient.AnimalService.AnimalType animalType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnimalService/GetFavoriteAnimal", ReplyAction="http://tempuri.org/IAnimalService/GetFavoriteAnimalResponse")]
        System.Threading.Tasks.Task<ZooSoapClient.AnimalService.Animal> GetFavoriteAnimalAsync(ZooSoapClient.AnimalService.AnimalType animalType);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAnimalServiceChannel : ZooSoapClient.AnimalService.IAnimalService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AnimalServiceClient : System.ServiceModel.ClientBase<ZooSoapClient.AnimalService.IAnimalService>, ZooSoapClient.AnimalService.IAnimalService {
        
        public AnimalServiceClient() {
        }
        
        public AnimalServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AnimalServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AnimalServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AnimalServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ZooSoapClient.AnimalService.Animal GetFavoriteAnimal(ZooSoapClient.AnimalService.AnimalType animalType) {
            return base.Channel.GetFavoriteAnimal(animalType);
        }
        
        public System.Threading.Tasks.Task<ZooSoapClient.AnimalService.Animal> GetFavoriteAnimalAsync(ZooSoapClient.AnimalService.AnimalType animalType) {
            return base.Channel.GetFavoriteAnimalAsync(animalType);
        }
    }
}
