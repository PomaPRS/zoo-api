namespace ZooRestServer.Models
{
    public enum AnimalType
    {
        Cat,
        Dog
    }
    
    public class Animal
    {
        public string Name { get; set; }
        public AnimalType Type { get; set; }
    }
}
