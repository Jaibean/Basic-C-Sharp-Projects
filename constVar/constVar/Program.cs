using System;

namespace constVar
{
    class Program
    {
        static void Main(string[] args)
        {
           var day = new string("Sunday");


            const string playerName = "Jaimie";

            Console.WriteLine("Welcome {0}. Today is {1}.", playerName, day);
            Console.ReadLine();
        }
    }
}
