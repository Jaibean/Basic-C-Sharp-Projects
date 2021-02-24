using System;
namespace Interfaces
{
    class Employee : Person, IQuittable
    {
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
    }
}
