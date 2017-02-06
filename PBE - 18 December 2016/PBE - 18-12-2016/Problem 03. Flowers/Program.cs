namespace Problem_03.Flowers
{
    using System;

    public class Program
    {
        private static void Main()
        {
            int хризантеми = int.Parse(Console.ReadLine());
            int рози = int.Parse(Console.ReadLine());
            int лалета = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());

            double хризантемиPrice = 0;
            double розиPrice = 0;
            double лалетаPrice = 0;

            double cost = 0;

            if (season == "Spring" || season == "Summer")
            {
                хризантемиPrice = 2.00;
                розиPrice = 4.10;
                лалетаPrice = 2.50;
            }
            else
            {
                хризантемиPrice = 3.75;
                розиPrice = 4.50;
                лалетаPrice = 4.15;
            }

            cost = хризантеми * хризантемиPrice + рози * розиPrice + лалета * лалетаPrice;

            if (holiday == 'Y')
            {
                cost += cost * 0.15;
            }

            if (лалета >= 7 && season == "Spring")
            {
                cost -= cost * 0.05;
            }

            if (рози >= 10 && season == "Winter")
            {
                cost -= cost * 0.10;
            }

            if (хризантеми + рози + лалета >= 20)
            {
                cost -= cost * 0.20;
            }

            Console.WriteLine("{0:F2}", cost+2);
        }
    }
}