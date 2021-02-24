using System;
namespace Superclass
{
    public class Person
    {

        public void SayName()
        {
            string FullName = "Name: " + FirstName + " " + LastName;
            Console.WriteLine(FullName);


        }



        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
