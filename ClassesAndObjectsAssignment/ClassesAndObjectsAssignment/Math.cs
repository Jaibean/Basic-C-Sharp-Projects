using System;
namespace ClassesAndObjectsAssignment
{
    public class Math
    {
        public int Method1(int x)

        {
            int result = x + 5;
            return result;
        }
        public decimal Method2(decimal x)
       
        {
            decimal result = x * 5;
            result = Convert.ToInt32(Console.ReadLine());
            return result;
                ;
            
        }

        public static string Method3(string x)
        {
          
            int number;

            bool isParsable = Int32.TryParse(x, out number);
            if (isParsable)
                Console.WriteLine(number);
            else
                Console.WriteLine("Could not be parsed.");
        }

        public int randomInt { get; set; }
        public decimal randomDec { get; set; }
        public string randomString { get; set; }



    }
}
