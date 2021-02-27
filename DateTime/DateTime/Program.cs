using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)


        {

            Console.WriteLine(DateTime.Now);
            Console.ReadLine();

            Console.WriteLine("Pick a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            // Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.

            TimeSpan thenAndNow = DateTime.Now - userInput;
            Console.WriteLine("It will be " + thenAndNow + "hours untill " + userInput);
            Console.ReadLine();




        }
    }
}
