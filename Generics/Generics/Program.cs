using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Employee<string> obj1 = new Employee<string>();
            obj1.Prop1.Add("List");
            obj1.Prop1.Add("of");
            obj1.Prop1.Add("Things");

            Employee<int> obj2 = new Employee<int>();
            obj2.Prop1.Add(1);
            obj2.Prop1.Add(2);
            obj2.Prop1.Add(3);


            foreach (string item in obj1.Prop1)
            {
                Console.WriteLine(item);
            }


            foreach (int item in obj2.Prop1)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
