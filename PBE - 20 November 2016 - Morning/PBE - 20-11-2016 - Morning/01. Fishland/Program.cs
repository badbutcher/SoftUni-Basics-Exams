namespace _01.Fishland
{
    using System;

    public class Program
    {
        private static void Main()
        {
            double amackerelKg = double.Parse(Console.ReadLine());
            double spratKg = double.Parse(Console.ReadLine());
            double beltedBonitoKg = double.Parse(Console.ReadLine());
            double scadKg = double.Parse(Console.ReadLine());
            int clamKg = int.Parse(Console.ReadLine());

            double beltedBonitoPrice = (amackerelKg + amackerelKg * 0.60) * beltedBonitoKg;
            double scadPrice = (spratKg + spratKg * 0.80) * scadKg;
            double clamPrice = clamKg * 7.50;

            Console.WriteLine("{0:F2}", beltedBonitoPrice + scadPrice + clamPrice);
        }
    }
}