using System;
using ZooSoapClient.AnimalService;

namespace ZooSoapClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new AnimalServiceClient())
            {
                var favoriteCat = client.GetFavoriteAnimal(AnimalType.Cat);
                var favoriteDog = client.GetFavoriteAnimal(AnimalType.Dog);

                Console.WriteLine("Favorite Cat: {0}, {1}, {2}", 
                    favoriteCat.Name, 
                    favoriteCat.Appearance.Color, 
                    favoriteCat.Appearance.HeightMeters);
                Console.WriteLine("Favorite Dog: {0}, {1}, {2}", 
                    favoriteDog.Name,
                    favoriteDog.Appearance.Color,
                    favoriteDog.Appearance.HeightMeters);
            }
        }
    }
}
