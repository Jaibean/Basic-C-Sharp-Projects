using System;

namespace EnumApp
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("What day of the week is it?");
            string day = Console.ReadLine();

            Days obj1;
            try
            {
                obj1 = (Days)Enum.Parse(typeof(Days), day);
                Console.WriteLine("It is " + obj1);
            }
            catch (Exception ex)
            {
                // The conversion failed.
                Console.WriteLine("Please enter an actual day of the week.");
                Console.WriteLine(ex.Message);
           
            }
  
            Console.ReadLine();
        }

        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
