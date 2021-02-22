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

            Math myMethod1 = new Math();
            Console.WriteLine(myMethod1.Method1(randomInt));
            Console.WriteLine(myMethod1.Method2(randomInt));
            Console.WriteLine(myMethod1.Method3(randomInt));



        }
    }
}
