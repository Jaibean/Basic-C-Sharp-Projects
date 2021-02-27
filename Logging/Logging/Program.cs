using System;
using System.IO;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            //logging
            Console.WriteLine("Pick a number");
            string userInt = Console.ReadLine();
            File.WriteAllText(@"/Users/jaimiebertoli/Documents/GitHub/log.txt", userInt);
            string file = File.ReadAllText(@"/Users/jaimiebertoli/Documents/GitHub/log.txt");
            Console.WriteLine(file);
            Console.ReadLine();
        }
    }
}
