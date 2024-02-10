using System;
namespace PetlaForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> pets = new List<string> { "cat", "dog", "parrot", "guinea pig" };

            foreach (string pet in pets)
            {
                Console.WriteLine(pet);

                if (pet == "dog")
                {
                    Console.WriteLine("End");

                    break;
                    //continue;
                }
            }
        }
    }
}