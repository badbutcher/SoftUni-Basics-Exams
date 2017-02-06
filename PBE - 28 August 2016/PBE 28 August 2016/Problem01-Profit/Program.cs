namespace Problem01_Profit
{
    using System;

    public class Program
    {
        private static void Main()
        {
            int workDays = int.Parse(Console.ReadLine());
            double moneyMadeForTheDay = double.Parse(Console.ReadLine());
            double dollarToLev = double.Parse(Console.ReadLine());

            double moneyForOneMonth = workDays * moneyMadeForTheDay;
            double annualIncome = moneyForOneMonth * 12 + moneyForOneMonth * 2.5;
            double tax = annualIncome - (annualIncome * 25) / 100;
            double currencyConverter = tax * dollarToLev;
            double avrageWins = currencyConverter / 365;
            Console.WriteLine("{0:F2}", avrageWins);
        }
    }
}