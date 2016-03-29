using System.Runtime.Serialization;
using System.ServiceModel;

namespace ZooSoapServer
{
    [ServiceContract]
    public interface IAnimalService
    {
        [OperationContract]
        Animal GetFavoriteAnimal(AnimalType animalType);
    }

    public enum AnimalType
    {
        Cat,
        Dog
    }

    [DataContract]
    public class Animal
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public AnimalType Type { get; set; }
    }
}
