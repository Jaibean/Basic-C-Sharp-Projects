using System;

namespace Superclass
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDerived employee = new EmployeeDerived();
            employee.FirstName = "Sample";
            employee.LastName ="Student";
            employee.SayName();

            Console.ReadLine();
        }
    }
}
