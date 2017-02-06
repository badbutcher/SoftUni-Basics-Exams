namespace Problem_01.Distance
{
    using System;

    public class Program
    {
        private static void Main()
        {
            double speed = double.Parse(Console.ReadLine());
            double firstTime = double.Parse(Console.ReadLine());
            double secondTime = double.Parse(Console.ReadLine());
            double thirdTime = double.Parse(Console.ReadLine());

            double firstToMin = firstTime / 60;
            double secondToMin = secondTime / 60;
            double thirdToMin = thirdTime / 60;

            double firstSpeed = speed * firstToMin;

            double firstIncrase = speed + (speed * 0.10);
            double secondSpeed = firstIncrase * secondToMin;

            double secondDecrease = firstIncrase - (firstIncrase * 0.05);
            double thirdSpeed = secondDecrease * thirdToMin;

            Console.WriteLine("{0:F2}", firstSpeed + secondSpeed + thirdSpeed);
        }
    }
}