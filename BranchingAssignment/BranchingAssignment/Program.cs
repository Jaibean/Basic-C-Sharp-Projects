using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight:");
            int packWeight = Convert.ToInt32(Console.ReadLine());

            if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
            }
            else 
            {
                Console.WriteLine("Please enter the package width:");
                int packWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                int packHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                int packLength = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Your estimated total for shipping this package is: $528.00\nThank you!");

            }

        }
    }
}
