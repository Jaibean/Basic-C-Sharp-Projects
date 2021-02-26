using System;
using System.Collections.Generic;

namespace LambaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1;
            emp1.FirstName = "Jaimie";
            emp1.LastName = "Bertoli";
            emp1.ID = 0001;

            Employee emp2;
            emp1.FirstName = "Name1";
            emp1.LastName = "LName1";
            emp1.ID = 0002;

            Employee emp3;
            emp1.FirstName = "Joe";
            emp1.LastName = "Lo";
            emp1.ID = 0003;

            Employee emp4;
            emp1.FirstName = "Joe";
            emp1.LastName = "Mo";
            emp1.ID = 0004;

            Employee emp5;
            emp1.FirstName = "Mark";
            emp1.LastName = "Tide";
            emp1.ID = 0005;

            Employee emp6;
            emp1.FirstName = "Leon";
            emp1.LastName = "Moon";
            emp1.ID = 0006;

            Employee emp7;
            emp1.FirstName = "Tyson";
            emp1.LastName = "Shin";
            emp1.ID = 0007;

            Employee emp8;
            emp1.FirstName = "elliot";
            emp1.LastName = "stan";
            emp1.ID = 0008;

            Employee emp9;
            emp1.FirstName = "Jackie";
            emp1.LastName = "Linden";
            emp1.ID = 0009;

            Employee emp10;
            emp1.FirstName = "Mike";
            emp1.LastName = "Lars";
            emp1.ID = 0010;



            List<Employee> firstList = new List<Employee>();
            List<Employee> secondList = new List<Employee>();

            //foreach loop to print all employees with first name of joe

            
            foreach (Employee name in firstList)
            {
                if (firstList.FirstName == "Joe")
                {
                    secondList.Add(name)

                }
            }


    }

        struct Employee
        {
            public string FirstName;
            public string LastName;
            public int ID;
        }

        }
    }
