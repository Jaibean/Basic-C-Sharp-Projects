using System;

namespace AssingmentClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pick a number");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Class1 obj1 = new Class1();
            obj1.Method1(userInput);

            Console.ReadLine();
        }
    }
}
