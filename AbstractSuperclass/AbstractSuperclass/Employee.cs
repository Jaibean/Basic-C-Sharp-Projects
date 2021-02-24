using System;
namespace AbstractSuperclass
{
   class Employee : Person
    {
       public override void SayName()
        {
            string FullName = "Name: " + FirstName + " " + LastName;
            Console.WriteLine(FullName);
        }
    }
    
}
