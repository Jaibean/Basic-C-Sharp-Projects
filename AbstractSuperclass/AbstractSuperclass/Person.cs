using System;
namespace AbstractSuperclass
{
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string SayName()
        {
            string FullName = "Name: " + FirstName + " " + LastName;
            return FullName;

        }

    }
}
