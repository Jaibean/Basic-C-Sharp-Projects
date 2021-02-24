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
            emp.Id = 0001;


            Employee emp2 = new Employee();
            emp2.FirstName = "Sample2";
            emp2.LastName = "Student2";
            emp2.Id = 0002;


            Console.WriteLine("Are the employees equal?");
            Console.WriteLine(emp == emp2);

            emp.SayName();
            emp.Quit();
            
            Console.ReadLine();

        }
    }
}
