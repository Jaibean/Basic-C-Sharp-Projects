using System;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {


            Number num1;
            num1.amount = 5;
            Console.WriteLine(num1.amount);
            Console.ReadLine();

        }

        struct Number
        {
            public decimal amount;
        }
    }
}
