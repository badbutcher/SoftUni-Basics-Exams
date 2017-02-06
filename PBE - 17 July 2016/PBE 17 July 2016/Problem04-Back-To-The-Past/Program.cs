namespace Problem04_Back_To_The_Past
{
    using System;

    public class Program
    {
        private static void Main()
        {
            double money = double.Parse(Console.ReadLine());
            int yearToLiveTo = int.Parse(Console.ReadLine());
            int ageOfIvan = 18;

            for (int i = 1800; i <= yearToLiveTo; i++)
            {
                if (i % 2 == 0)
                {
                    money -= 12000;
                }
                else
                {
                    money -= 12000 + (ageOfIvan * 50);
                }

                ageOfIvan++;
            }

            if (money >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", money);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(money));
            }
        }
    }
}