using System;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask the user what number they want to do the math operations on
            Console.WriteLine("Enter the price of an item");
            double ItemPrice = Convert.ToDouble(Console.ReadLine());
            // asking for tax rate in percentage form
            Console.Write("Enter tax rate (in decimal): ");
            double TaxRate = Convert.ToDouble(Console.ReadLine());

            TaxCalc myTaxCalculator = new TaxCalc(TaxRate);
            myTaxCalculator.CalculateTotalPrice(ItemPrice, TaxRate);
            myTaxCalculator.GetTotalMsg();
            Console.ReadLine();
        }
    }
}
