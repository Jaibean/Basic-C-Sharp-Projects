using System;

namespace ClassTwoParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number");
            int randomInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick another number, if you want");
            string randomStr = Console.ReadLine();
            

            Param myMethod = new Param();

            if (randomStr == "")
            {
                Console.WriteLine(myMethod.Method1(randomInt));

            }
            else
            {
                int number = Convert.ToInt32(randomStr);
                Console.WriteLine(myMethod.Method1(randomInt, number));
            }

            Console.ReadLine();
        }
    }
}
