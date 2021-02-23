using System;

namespace ClassTwoParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number");
            int randomInt = Convert.ToInt32(Console.ReadLine());



            Param myMethod = new Param(randomInt, 7);
            
           

        }
    }
}
