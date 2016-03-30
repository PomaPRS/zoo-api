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
        public Appearance Appearance { get; set; }
    }
    
    public class Appearance
    {
        public double HeightMeters { get; set; }
        public string Color { get; set; }
    }
}
