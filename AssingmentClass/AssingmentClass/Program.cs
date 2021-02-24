using System;

namespace AssingmentClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pick a number");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick another number");
            int userInput2 = Convert.ToInt32(Console.ReadLine());



            Class1 obj1 = new Class1();
            obj1.Method1(userInput);
            obj1.Method2(out int x, out int y);
            obj1.Method2(out string x, string y);
            obj1.Method3();

            Console.ReadLine();

            
        }
    }
}
