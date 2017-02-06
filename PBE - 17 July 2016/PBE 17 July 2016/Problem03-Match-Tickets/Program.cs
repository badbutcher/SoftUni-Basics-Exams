namespace Problem03_Match_Tickets
{
    using System;

    public class Program
    {
        private static void Main()
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            decimal leftoverMoney = budget;
            decimal moneyToSpare = 0;

            if (people >= 1 && people <= 4)
            {
                leftoverMoney -= (budget * 75) / 100;
            }
            else if (people >= 5 && people <= 9)
            {
                leftoverMoney -= (budget * 60) / 100;
            }
            else if (people >= 10 && people <= 24)
            {
                leftoverMoney -= (budget * 50) / 100;
            }
            else if (people >= 25 && people <= 49)
            {
                leftoverMoney -= (budget * 40) / 100;
            }
            else
            {
                leftoverMoney -= (budget * 25) / 100;
            }

            if (category == "Normal")
            {
                moneyToSpare = leftoverMoney - (people * 249.99m);
            }
            else
            {
                moneyToSpare = leftoverMoney - (people * 499.99m);
            }

            if (moneyToSpare >= 0)
            {
                Console.WriteLine("Yes! You have {0} leva left.", moneyToSpare);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0} leva.", moneyToSpare * -1);
            }
        }
    }
}