using System;

namespace constVar
{
    class Program
    {
        static void Main(string[] args)
        {
           var day = "Sunday";


            const string playerName = "Jaimie";

            Console.WriteLine("Welcome {0}. Today is {1}.", playerName, day);
            Console.ReadLine();

            ConstructMe a = new ConstructMe("Jaimie", "Monday");
            Console.WriteLine($"Welcome {a.name}. Today is {a.day1}");
            Console.ReadKey(); ;


        }
        public class ConstructMe
        {
            public string name;
            public string day1;

            public ConstructMe() : this(" "," ")
            {

            }
            public ConstructMe(string Name, string Day)
            {
                this.name = Name;
                this.day1 = Day;
            }

            public ConstructMe(string name) : this(name, " ")
            {

            }
       
    

        }
       
    }
}
