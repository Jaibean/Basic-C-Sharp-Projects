﻿using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // one dimensional array of strings
        string[] stringArray = { "Hello", "my", "name", "is", "jaimie" };
        //Ask the user to select an index of the Array
        Console.WriteLine("Pick a number bewtween 0 and 4");
        //display the integer at that index on the screen.
        int pickedArray = Console.WriteLine();
        if (pickedArray > 4 || pickedArray < 0)
            {
                Console.WriteLine("That index does not exisit.");
            }
            Console.ReadLine();
        
        // one-dimensional Array of integers.
        int[] intArray = { 8, 5, 9, 2500, 108 };
        //Ask the user to select an index of the Array
        Console.WriteLine("Pick a number bewtween 0 and 4");
        //display the integer at that index on the screen.
        int pickedIndex = Console.ReadLine(intArray[pickedIndex]);
        if (pickedIndex > 4 || pickedIndex < 0)
           {
               Console.WriteLine("That index does not exisit.");
           }
            Console.ReadLine();


        //list of strings
        List<string> intList = new List<string>();
        intList.Add("what");
        intList.Add("will");
        intList.Add("you");
        intList.Add("chose");
        intList.Add("here");
        //select an index of the list
        Console.WriteLine("Pick a number bewtween 0 and 4");
        //display the content at that index in cosole
        int pickedList = Convert.ToInt32(Console.ReadLine());

        if (pickedList > 5 || pickedList < 0)
            {
                Console.WriteLine("That index does not exisit.");
            }
        Console.ReadLine();

            //Console.WriteLine("Pick an index of the below array");
            //int pickedArray2 = Convert.ToInt32(Console.ReadLine());

        }

    }