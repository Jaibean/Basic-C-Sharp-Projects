using System;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Concole Application Assigment");
            Console.ReadLine();


            // asking for an input from user in integer form 
            Console.WriteLine("What is your lucky number?");
            int yourLuckyNumber = Convert.ToInt32(Console.ReadLine());


            // taking the user input yourLuckyNumber and multiplying by 50
            // then printing the product to the console
            int product = yourLuckyNumber * 50;
            Console.WriteLine(product);
            Console.ReadLine();


            // asking user for another input
            Console.WriteLine("What is the number of the day you were born?");
            int yourBirthDay = Convert.ToInt32(Console.ReadLine());

            // adds 25 to user input and prints to console
            int total = yourBirthDay + 25;
            Console.WriteLine(yourBirthDay);
            Console.ReadLine();


            // asking user for another input
            Console.WriteLine("How many hours of sleep did you get last night?");
            double hoursSlept = Convert.ToDouble(Console.ReadLine());

            // divides user iput by 12.5
            double quotient = hoursSlept / 12.5;
            Console.WriteLine(yourBirthDay);
            Console.ReadLine();


            // asking user for another input
            Console.WriteLine("How old are you?");
            int yourAge = Convert.ToInt32(Console.ReadLine());

            // check id user is older than 50
            bool overFifty = yourAge > 50;
            Console.WriteLine(overFifty);
            Console.ReadLine();

            // asking user for another input
            Console.WriteLine("What is the year your were born?");
            int brithYear = Convert.ToInt32(Console.ReadLine());

            // divides user iput by 7 and outputs remainder 
            int remainder = brithYea % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();


        }
    }
}
