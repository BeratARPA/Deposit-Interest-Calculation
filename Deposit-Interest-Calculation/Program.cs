using System;

namespace Deposit_Interest_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anapara: ");
            double principalAmount = Convert.ToDouble(Console.ReadLine()); // Initial principal amount

            Console.Write("Faiz Oranı: ");
            double interestRate = Convert.ToDouble(Console.ReadLine()); ; // Annual interest rate

            Console.Write("Stopaj Oranı: ");
            double withholdingTaxRate = Convert.ToDouble(Console.ReadLine()); // Withholding tax rate

            Console.Write("Eklenecek Miktar: ");
            double additionalAmount = Convert.ToDouble(Console.ReadLine()); // Amount to be added to the principal every month

            Console.Write("Vade (AY): ");
            int numberOfMonths = Convert.ToInt32(Console.ReadLine()); // Number of months

            Console.WriteLine("");

            double totalInterest = 0;
            for (int month = 1; month <= numberOfMonths; month++)
            {
                double interest = (principalAmount * (interestRate / 100) * 1) / 12;
                double withholdingTax = interest * (withholdingTaxRate / 100);
                double netInterest = interest - withholdingTax;

                principalAmount += netInterest;

                Console.WriteLine("Net Para: {0} {1}.Ay Faiz: {2} Brüt Faiz: {3} Stopaj: {4}", principalAmount.ToString("N").PadRight(15), month, netInterest.ToString("N").PadRight(15), interest.ToString("N").PadRight(15), withholdingTax.ToString("N"));
                principalAmount += additionalAmount;
            }

            principalAmount -= additionalAmount;

            Console.WriteLine("\nToplam: {0}", (principalAmount + totalInterest).ToString("N"));

            Console.ReadLine();
        }
    }
}
