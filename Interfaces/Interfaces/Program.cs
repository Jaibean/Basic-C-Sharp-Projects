using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.FirstName = "Sample";
            emp.LastName = "Student";
            emp.SayName();
            emp.Quit();
            
            Console.ReadLine();

        }
    }
}
