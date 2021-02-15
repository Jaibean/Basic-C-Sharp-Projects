using System;

namespace MathandComparisonOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();


            // Person 1
            Console.WriteLine("Person 1:");
            Console.ReadLine();
            // find and print following details
            Console.WriteLine("What is your hourly rate?");
            int personOneHourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How may hours do you work a week?");
            int personOneWeeklyHours = Convert.ToInt32(Console.ReadLine());
            int weeklyRateP1 = personOneHourlyRate * personOneWeeklyHours;


            // Person 2
            Console.WriteLine("Person 2:");
            Console.ReadLine();
            // find and print following details
            Console.WriteLine("What is your hourly rate?");
            int personTwoHourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How may hours do you work a week?");
            int personTwoWeeklyHours = Convert.ToInt32(Console.ReadLine());
            int weeklyRateP2 = personTwoHourlyRate * personTwoWeeklyHours;


            // Annual Salary of Person 1
            Console.WriteLine("Annual salary of Person 1:");
            Console.ReadLine();
            int yearlyRateP1 = weeklyRateP1 * 52;
            Console.WriteLine(yearlyRateP1);
            Console.ReadLine();


            // Annual Salary of Person 2
            Console.WriteLine("Annual salary of Person 2:");
            Console.ReadLine();
            int yearlyRateP2 = weeklyRateP2 * 52;
            Console.WriteLine(yearlyRateP2);
            Console.ReadLine();

            // Comparing Salaries
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.ReadLine();
            bool isSalaryMore = yearlyRateP1 > yearlyRateP2;
            Console.WriteLine(isSalaryMore);
            Console.ReadLine();
        

        }
    }
}
