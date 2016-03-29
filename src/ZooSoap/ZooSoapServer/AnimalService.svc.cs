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
                new Animal() {Name = "Lucy", Type = AnimalType.Cat},
                new Animal() {Name = "Rocky", Type = AnimalType.Dog}
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
