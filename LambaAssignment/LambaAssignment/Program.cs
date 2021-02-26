using System;
using System.Collections.Generic;
using System.Linq;

namespace LambaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> firstList = new List<Employee>()
            {
                new Employee { FName = "Bill", LName = "Lucas", Id = 101 },
                new Employee { FName = "Steve", LName = "Lanes", Id = 102 },
                new Employee { FName = "Jeff", LName = "Clark", Id = 103 },
                new Employee { FName = "Joe", LName = "Thomas", Id = 104 },
                new Employee { FName = "Joe", LName = "Wang", Id = 105 },
                new Employee { FName = "Steven", LName = "Holmes", Id = 106 },
                new Employee { FName = "Mark", LName = "Lark", Id = 107 },
                new Employee { FName = "Larry", LName = "Good", Id = 108 },
                new Employee { FName = "Tim", LName = "Whiles", Id = 109 },
                new Employee { FName = "Jerry", LName = "Lee", Id = 110 }
            };


            List<Employee> secondList = new List<Employee>();

            //foreach loop to print all employees with first name of joe
            foreach (Employee employee in firstList)
            {
                if (employee.FName == "Joe")
                {
                    secondList.Add(employee);
                }

            }

            foreach (Employee employee in secondList)
            {
                Console.WriteLine(employee.FName + " " + employee.LName);
            }

            //same logic, but with lambda function
            //List<Employee> secondList = firstList.FindAll(x => (x.FName == "Joe")).ToList();


            List<Employee> thirdList = firstList.Where(x => (x.FName == "Joe")).ToList();

            foreach (Employee employee in thirdList)
            {
               Console.WriteLine(employee.FName + " " + employee.LName);
            }


            //Using a lambda expression, make a list of all employees with an Id number greater than 5.

            List<Employee> fourthList = firstList.Where(x => (x.Id > 5)).ToList();

            foreach (Employee employee in fourthList)
            {
                Console.WriteLine(employee.FName + " " + employee.LName);
            }



            Console.ReadLine();

        }


        }
    }
