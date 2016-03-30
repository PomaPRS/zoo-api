using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using Swashbuckle.SwaggerGen.Annotations;
using ZooRestServer.Models;

namespace ZooRestServer.Controllers
{
    public interface IAnimalsController
    {
        Animal Get(AnimalType animalType);
    }

    [Route("api/[controller]")]
    public class AnimalsController : Controller, IAnimalsController
    {
        public AnimalsController()
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

        [HttpGet("favorite/{animalType}")]
        [SwaggerOperation("GetFavoriteAnimal")]
        public Animal Get(AnimalType animalType)
        {
            return FavoriteAnimals[animalType];
        }
    }
}
