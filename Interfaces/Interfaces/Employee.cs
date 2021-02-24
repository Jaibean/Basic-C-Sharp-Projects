using System;
namespace Interfaces
{
    class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            string FullName = "Name: " + FirstName + " " + LastName;
            Console.WriteLine(FullName);
        }

        public void Quit()
        {
            //throw new NotImplementedException();
            Console.WriteLine("You are quitting the program");
        }

        public static bool operator ==(Employee employee, Employee employee2)
        {
            if (employee.Id == employee2.Id)

                return true;
            else
                return false;
        }
        public static bool operator !=(Employee employee, Employee employee2)
        {
            if (employee.Id != employee2.Id)

                return true;
            else
                return false;
        }
    }

}

