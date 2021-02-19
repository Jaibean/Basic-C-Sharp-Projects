using System;
using System.Collections.Generic;

namespace ConsoleAppliction6part
{
    class Program
    {
        static void Main(string[] args)
        {

            // assignment part one

            // one dimensional array of strings
            string[] stringArray = { "Hello", "my", "name", "is", "jaimie" };

            //// Ask the user to input some text.
            //Console.WriteLine("What is your favorite type of weather?");
            //string userInput = Console.ReadLine();

            ////loop that iterates through each string in stringArray and adds userInput to the end of each string

            //foreach (var i in stringArray)
            //{
            //    Console.WriteLine(i + " " + userInput);
            //}

            //// Assignemnt part two

            ////infinite loop
            //for (var j = 0; j < stringArray.Length; j--)
            //{
            //    Console.WriteLine("value : {0}", j);
            //}
            //Console.ReadLine();

            //// Assignment part three

            //// A loop where the comparison that’s used to determine whether
            //// to continue iterating the loop is a “<” operator.

            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    Console.Write(stringArray[i]);
            //    if (i < stringArray.Length - 1)
            //    {

            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine();

            //// A loop where the comparison that’s used to determine whether
            //// to continue iterating the loop is a “<=” operator.

            //foreach (var i in stringArray)
            //if (stringArray.Length <= 5)
            //{
            //    Console.WriteLine("You are within the index");
            //}
            //else
            //{
            //    Console.WriteLine("You are outside the arrays limitations");
            //}
            //Console.ReadLine();

            // Assignment part four

            List<string> seasonList = new List<string>();
            seasonList.Add("Spring");
            seasonList.Add("Summer");
            seasonList.Add("Fall");
            seasonList.Add("Winter");

            Console.WriteLine("What season is it?");
            string currentSeason = Console.ReadLine();




            Console.WriteLine(seasonList[0]);
            Console.ReadLine();



        }
    }
}
   
