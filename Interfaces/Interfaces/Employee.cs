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

        public override bool Equals(Object obj)
        {
            Employee employee = obj as Employee;

            if (employee == null)
                return false;

            return this.Id.Equals(employee.Id);
        }

    }
}
