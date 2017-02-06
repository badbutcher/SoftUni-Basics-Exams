namespace Problem01_Money
{
    using System;

    public class Program
    {
        private static void Main()
        {
            int bitCoins = int.Parse(Console.ReadLine());
            double yens = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double bitCoinToLev = bitCoins * 1168.00d;
            double yenToDolar = yens * 0.15d;
            double dolarToLev = yenToDolar * 1.76d;

            double sum = (bitCoinToLev + dolarToLev) / 1.95d;

            Console.WriteLine(sum -= (sum * commission) / 100);
        }
    }
}