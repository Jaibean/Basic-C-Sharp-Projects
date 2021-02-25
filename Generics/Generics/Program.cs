using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>
            //{
            //    "List", "of", "things"
            //}();

            employee.Things();


            Employee<int> employee1 = new Employee<int>();


            foreach (string item in Things)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
