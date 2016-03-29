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

                Console.WriteLine("Favorite Cat: {0}", favoriteCat.Name);
                Console.WriteLine("Favorite Dog: {0}", favoriteDog.Name);
            }
        }
    }
}
