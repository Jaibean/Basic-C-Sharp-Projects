using System;
using System.Text;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
          
            ////Assignment concatenate three strings and convert to upper case
            //string firstString = "Jaimie went ";
            //string secondString = "to the park ";
            //string thirdString = "after dark.";

            //string concat = firstString + secondString + thirdString;
            //concat = concat.ToUpper();

            //Console.WriteLine(concat);
            //Console.ReadLine();

            //Assignment create a Stringbuilder and build a paragraph of text on sentence at a time. 
            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jaimie. ");
            sb.Append("I am 26 years old. ");
            sb.Append("I like to watch the snow fall.");
            sb.Append("Luckily I do not have to shovel since I am in the city.");


            Console.WriteLine(sb);
            Console.ReadLine();


            // exercises
            //string name = "Jaimie";
            //string quote = "The man said, \"Hello\", Jaimie.\nHello on a new line\tHello on a tab.";
            //string fileName = @"C:\Users\Jaimie";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();

            //string name = "Jaimie";
            //name = "Joe";

            //Console.WriteLine(name);
            //Console.ReadLine();

        }
    }
}
