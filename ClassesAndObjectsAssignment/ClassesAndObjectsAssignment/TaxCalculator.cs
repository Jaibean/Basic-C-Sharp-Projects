using System;
namespace ClassesAndObjectsAssignment
{
    public class TaxCalculator
    {
        public TaxCalculator(double TaxRate)

        {
            PercentTaxRate = TaxRate / 100;
        }
        public void CalculateTotalPrice(double ItemPrice, double PercentTaxRate)
       
        {
            //calculating total price
            TotalPrice = ItemPrice + (ItemPrice * PercentTaxRate);
        }

        public void GetTotalMsg()
        {
            Console.WriteLine("The total price is {0:C}", TotalPrice);
        }

        public double ItemPrice { get; set; }
        public double PercentTaxRate { get; set; }
        public double TotalPrice { get; set; }

    }
}
