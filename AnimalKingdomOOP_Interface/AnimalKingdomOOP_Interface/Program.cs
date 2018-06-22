using AnimalKingdomOOP_Interface.Classes;
using System;

namespace AnimalKingdomOOP_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
    
            GreatWhiteShark shark = new GreatWhiteShark();

            Console.WriteLine("The Great White Shark");
            Console.WriteLine(shark.Sound());
            Console.WriteLine(shark.Diet());
            Console.WriteLine(shark.Habitat());
            Console.WriteLine($"has {shark.LegCount} legs");
            Console.WriteLine(shark.IsNocturnal);
            Console.WriteLine($" would I make good sushi? {shark.Sushiable}");
            Console.ReadKey();





        }
    }
}
