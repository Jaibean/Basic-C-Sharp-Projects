using System;

namespace ClassesAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask the user what number they want to do the math operations on
            Console.WriteLine("Pick an integer");
            int randomInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now pick a decimal");
            decimal randomDec = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Pick a number");
            string randomString = Console.ReadLine();

            Math myMethod1 = new Math();
            Console.WriteLine(myMethod1.Method1(randomInt));
            Console.WriteLine(myMethod1.Method2(randomDec));
            Console.WriteLine(myMethod1.Method3(randomString));



        }
    }
}
