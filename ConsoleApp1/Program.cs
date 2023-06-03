using System;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Number Generator");

            Console.Write("Enter the minimum number: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the maximum number: ");
            int max = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int randomNumber = rnd.Next(min, max + 1);

            Console.WriteLine($"Random number between {min} and {max}: {randomNumber}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
