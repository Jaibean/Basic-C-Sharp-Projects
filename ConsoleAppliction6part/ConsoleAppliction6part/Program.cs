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

            //    // Assignment part four

            //    List<string> seasonList = new List<string>() { "Spring", "Summer", "Fall", "Winter" };

            //    string currentSeason;
            //    // loop iterating through the list and then displays the index of the list that contains matching text on the screen

            //    do
            //    {
            //        Console.WriteLine("Pick a season from the list: Spring, Summer, Fall, Winter");
            //        currentSeason = Console.ReadLine();

            //        for (int i = 0; i < seasonList.Count; i++)
            //        {
            //            if (currentSeason == seasonList[i])
            //            {
            //                Console.WriteLine("You chose the season with an index of: " + i);
            //            }
            //        }
            //        if (!seasonList.Contains(currentSeason))
            //        {
            //            Console.WriteLine("Not a match, try again");

            //        }

            //    }
            //    while (!seasonList.Contains(currentSeason));

            //    Console.ReadLine();
            //}

            // Assignment part five

            //List<string> shoppingList = new List<string>() { "Onion", "Spinach", "Pasta", "Avocado", "Onion", "Peppers", "Mushrooms" };


            //// loop iterating through the list, displays indicies of the list that contain matching text on the screen

            //string chosenItem;

            //do
            //{
            //    Console.WriteLine("Select text to search for in the list");
            //    chosenItem = Console.ReadLine();

            //    for (int i = 0; i < shoppingList.Count; i++)
            //    {
            //        if (chosenItem == shoppingList[i])
            //        {
            //            Console.WriteLine("You chose: " + i);

            //        }
            //    }
            //    if (!shoppingList.Contains(chosenItem))
            //    {
            //        Console.WriteLine("Not a match, try again");

            //    }

            //}
            //while (!shoppingList.Contains(chosenItem));

            //Console.ReadLine();

            //Assignment part six

            List<string> shoppingList2 = new List<string>() { "Onion", "Spinach", "Pasta", "Avocado", "Onion", "Peppers", "Mushrooms", "Spinach" };

            // new list to add items, discluding the dupes
            List<string> shoppingList3 = new List<string>();
           

            // foreach loop that evaluates each item in list and displays message showing the string and weather or not it has already appeared
            foreach (string i in shoppingList2)
            {
              if (shoppingList3.Contains(i) )
                {
                    Console.WriteLine(i + " is a duplicate");
                }
                else
                {
                    Console.WriteLine(i);
                    shoppingList3.Add(i);
                }
            
            }
            
        }
    }

}
   
