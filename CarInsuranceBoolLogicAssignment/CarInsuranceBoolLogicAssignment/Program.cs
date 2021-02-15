using System;

namespace CarInsuranceBoolLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int yourAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Answer True or False.");
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            bool qualified = yourAge >= 15 && DUI != true && speedingTickets <= 3;
            Console.WriteLine(qualified);


        }
    }
}
