using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // First line of the program
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt for package weight
            Console.WriteLine("Please enter the package weight:");
            float weight = float.Parse(Console.ReadLine());

            // If weight is too heavy, exit
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Prompt for width
            Console.WriteLine("Please enter the package width:");
            float width = float.Parse(Console.ReadLine());

            // Prompt for height
            Console.WriteLine("Please enter the package height:");
            float height = float.Parse(Console.ReadLine());

            // Prompt for length
            Console.WriteLine("Please enter the package length:");
            float length = float.Parse(Console.ReadLine());

            // If dimension total is more than 50, exit
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Calculate quote: (width * height * length * weight) / 100
            float quote = (width * height * length * weight) / 100;

            // Display final quote as currency with two decimals
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
        }
    }
}
