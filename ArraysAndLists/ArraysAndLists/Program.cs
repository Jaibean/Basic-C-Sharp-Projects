using System;
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
        int pickedArray = Convert.ToString(Console.ReadLine(stringArray[pickedArray]));

        // one-dimensional Array of integers.
        int[] intArray = { 8, 5, 9, 2500, 108 };
        //Ask the user to select an index of the Array
        Console.WriteLine("Pick a number bewtween 0 and 4");
        //display the integer at that index on the screen.
        int pickedIndex = Console.ReadLine(intArray[pickedIndex]);


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
        int pickedList = Console.ReadLine(intList[pickedList]);




        //Console.WriteLine("Pick an index of the below array");
        //int pickedArray2 = Convert.ToInt32(Console.ReadLine());


        //Arrays - must declare length 

        //instantiation an array of 5 values and assigning the values to each index
        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;
        //printing index 3 to the console 
        //Console.WriteLine(numArray[3]);
        //Console.ReadLine();

        //instatiating array with values in a list view
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //even faster way to instatiating an array, domt have to say you are creating a new array 
        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //changing the value of index 5
        //numArray2[5] = 650;
        //printing that change to the console to check it worked
        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();

        //Lists

        //instatiating a list. no length needed to be declared 
        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        //intList.Remove(10);

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();

        //instatiating a list of strings
        //List<string> intList = new List<string>();
        //intList.Add("Hello");
        //intList.Add("Jaimie");
        //intList.Remove("Jaimie);

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();


        //store an image as binary information in a database. Large quantities 
        //byte[] byteArray = new byte[5000]

    }
}

