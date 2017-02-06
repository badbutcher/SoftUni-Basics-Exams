namespace _03.Bike_Race
{
    using System;

    public class Program
    {
        private static void Main()
        {
            int youngRiders = int.Parse(Console.ReadLine());
            int oldRiders = int.Parse(Console.ReadLine());
            string trackType = Console.ReadLine();

            double youngTrail = 5.50;
            double oldTrail = 7;
            double youngCrossCountry = 8;
            double oldCrossCountry = 9.50;
            double youngDownhill = 12.25;
            double oldDownhill = 13.75;
            double youngRoad = 20;
            double oldRoad = 21.50;

            double sum = 0;
            double cost = 0;

            if (trackType == "trail")
            {
                sum = youngTrail * youngRiders + oldTrail * oldRiders;
                cost = sum - sum * 0.05;
            }
            else if (trackType == "cross-country")
            {
                if (youngRiders + oldRiders >= 50)
                {
                    youngCrossCountry -= youngCrossCountry * 0.25;
                    oldCrossCountry -= oldCrossCountry * 0.25;

                    sum = youngCrossCountry * youngRiders + oldCrossCountry * oldRiders;
                    cost = sum - sum * 0.05;
                }
                else
                {
                    sum = youngCrossCountry * youngRiders + oldCrossCountry * oldRiders;
                    cost = sum - sum * 0.05;
                }
            }
            else if (trackType == "downhill")
            {
                sum = youngDownhill * youngRiders + oldDownhill * oldRiders;
                cost = sum - sum * 0.05;
            }
            else if (trackType == "road")
            {
                sum = youngRoad * youngRiders + oldRoad * oldRiders;
                cost = sum - sum * 0.05;
            }

            Console.WriteLine("{0:F2}", cost);
        }
    }
}