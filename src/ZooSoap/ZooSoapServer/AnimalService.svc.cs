using System.Collections.Generic;
using System.Linq;

namespace ZooSoapServer
{
    public class AnimalService : IAnimalService
    {
        public AnimalService()
        {
            FavoriteAnimals = new List<Animal>()
            {
                new Animal()
                {
                    Name = "Lucy",
                    Type = AnimalType.Cat,
                    Appearance = new Appearance()
                    {
                        Color = "white",
                        HeightMeters = 0.157
                    }
                },
                new Animal()
                {
                    Name = "Rocky",
                    Type = AnimalType.Dog,
                    Appearance = new Appearance()
                    {
                        Color = "dark green",
                        HeightMeters = 0.5
                    }
                }
            }
            .ToDictionary(x => x.Type);
        }

        private Dictionary<AnimalType, Animal> FavoriteAnimals { get; }

        public Animal GetFavoriteAnimal(AnimalType animalType)
        {
            return FavoriteAnimals[animalType];
        }
    }
}
