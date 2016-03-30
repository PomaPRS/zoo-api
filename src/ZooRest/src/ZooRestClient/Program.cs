using System;
using Zoo.Api;

namespace ZooRestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalApi = new AnimalsApi();
            var animal = animalApi.GetFavoriteAnimal("cat");
            Console.WriteLine("Name: {0}", animal.Name);
        }
    }
}
