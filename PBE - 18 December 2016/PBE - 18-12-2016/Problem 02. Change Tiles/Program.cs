namespace Problem_02.Change_Tiles
{
    using System;

    public class Program
    {
        private static void Main()
        {
            double money = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorLength = double.Parse(Console.ReadLine());
            double triangleSide = double.Parse(Console.ReadLine());
            double triangleHight = double.Parse(Console.ReadLine());
            double costForOneTile = double.Parse(Console.ReadLine());
            double workerPrice = double.Parse(Console.ReadLine());

            double floorArea = floorLength * floorWidth;
            double tileArea = (triangleHight * triangleSide) / 2;
            double neededArea = Math.Ceiling(floorArea / tileArea) + 5;
            double cost = neededArea * costForOneTile + workerPrice;

            if (cost <= money)
            {
                Console.WriteLine("{0:F2} lv left.", money - cost);
            }
            else
            {
                Console.WriteLine("You'll need {0:F2} lv more.", cost - money);
            }
        }
    }
}