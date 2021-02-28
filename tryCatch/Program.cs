using System;

namespace tryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int currentYear = 2021;
 


            try
            {
                Console.WriteLine("How old are you?");
                int userAge = Convert.ToInt32(Console.ReadLine());
                int yearBorn = currentYear - userAge;
                if (userAge <= 0)
                {
                    throw new Exception();
                }
                Console.WriteLine("You were born in {0}", yearBorn);

            }
   
            catch (Exception)
            {
                Console.WriteLine("Please type in your age as a whole number.");
                Console.ReadLine();
                return;
              
            }
           
            Console.ReadLine();
        }
    }
}