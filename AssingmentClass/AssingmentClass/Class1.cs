﻿using System;
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
        }

        public string Method2(out string x, out string y)
        {
            string string1 = "Hello";
            string string2 = "Again";
            x = string1;
            y = string2;
        }

        public static void Method3(int x)
        {
            Console.WriteLine(x + 5);
        }
           
    }
}
