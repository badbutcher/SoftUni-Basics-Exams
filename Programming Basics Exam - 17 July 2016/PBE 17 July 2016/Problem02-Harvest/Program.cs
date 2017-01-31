namespace Problem02_Harvest
{
    using System;

    public class Program
    {
        private static void Main()
        {
            int sqrKm = int.Parse(Console.ReadLine());
            double grapes = double.Parse(Console.ReadLine());
            int neededWine = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double totalGrapes = sqrKm * grapes;
            double totalWine = ((40 * totalGrapes) / 100) / 2.5;

            if (totalWine >= neededWine)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(totalWine));
                double wineLeft = totalWine - neededWine;
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wineLeft), Math.Ceiling(wineLeft / workers));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(neededWine - totalWine));
            }
        }
    }
}