using System;
namespace AssingmentClass
{
    public class Class1
    {
        public void Method1(int x)
        {
            Console.WriteLine(x / 2);

        }

        public int Method2(out int x, out int y)
        {
            int number2 = 10;
            int number = 5;
            x = number;
            y = number2;
            return number2;

        }

        public string Method2(out string z, out string c)
        {
            string string1 = "Hello";
            string string2 = "Again";
            z = string1;
            c = string2;
            return string1;
        }

        public static void Method3(int x)
        {
            Console.WriteLine(x + 5);
        }
           
    }
}
