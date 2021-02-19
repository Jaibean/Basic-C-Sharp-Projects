using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

            //// do while loop
            //do
            //{
            //    switch (number)
            //    {

            //            case 62:
            //                Console.WriteLine("Yoy guessed 62. Try again.");
            //                Console.WriteLine("Guess a number?");
            //                number = Convert.ToInt32(Console.ReadLine());
            //                break;
            //            case 29:
            //                Console.WriteLine("You guessed 29. Try again.");
            //                Console.WriteLine("Guess a number?");
            //                number = Convert.ToInt32(Console.ReadLine());
            //                break;
            //            case 55:
            //                Console.WriteLine("You guessed 55. Try again.");
            //                Console.WriteLine("Guess a number?");
            //                number = Convert.ToInt32(Console.ReadLine());
            //                break;
            //            case 12:
            //                Console.WriteLine("You guessed the number 12. That is correct!");
            //                isGuessed = true;
            //                break;
            //            default:
            //                Console.WriteLine("You are wrong, guess again.");
            //                Console.WriteLine("What is your guess?");
            //                number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        }
            //    }
            //     while (!isGuessed);

            //     Console.Read();

            //while loop

            while (!isGuessed)
            {

                switch (number)
                {

                    case 62:
                        Console.WriteLine("Yoy guessed 62. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed the number 12. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong, guess again.");
                        Console.WriteLine("What is your guess?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.Read();
        }
    }
}
