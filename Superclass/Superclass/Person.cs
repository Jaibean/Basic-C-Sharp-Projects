using System;
namespace Superclass
{
    public class Person
    {

        public string SayName()
        {
            string FullName = "Name: " + FirstName + " " + LastName;
            return FullName;
            
        }



        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
