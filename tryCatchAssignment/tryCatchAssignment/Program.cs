using System;
using System.Collections.Generic;

namespace tryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of integers
            List<int> temps = new List<int> { 76, 32, 54, 94, 23, 88 };

            //put the loop in a try/catch block.

            try
            {
                //Ask the user for a #, store input as int
                Console.WriteLine("Pick a number between 1-10");
                int userInput = Convert.ToInt32(Console.ReadLine());

                //loop through the list 
                foreach (int i in temps)
                {
                    //Divide each numbmer in the list by the user input #
                    int quotient = i / userInput;
                    //Display results to console
                    Console.WriteLine(quotient);
                    Console.ReadLine();
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
               
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.\nChoose a new number.");

            }

        }
    }
}
