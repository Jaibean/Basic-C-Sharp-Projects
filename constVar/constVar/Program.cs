using System;

namespace constVar
{
    class Program
    {
        static void Main(string[] args)
        {
           var day = new string("Sunday");


            const string playerName = "Jaimie";

            Console.WriteLine("Welcome {0}. Today is {1}.", playerName, day);
            Console.ReadLine();

            ConstructMe a = new ConstructMe("Jaimie", "Monday");
            Console.WriteLine($"Welcom {a.name}. Today is {a.day1}");
            Console.ReadKey(); ;


        }
        public class ConstructMe
        {
            public string name;
            public string day1;
            public ConstructMe(string Name, string Day1)
            {
                this.name = Name;
                this.day1 = Day1;
            }

        }
       
    }
}
