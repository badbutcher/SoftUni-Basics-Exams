namespace _02.Flower_Shop
{
    using System;

    public class Program
    {
        private static void Main()
        {
            int magnolias = int.Parse(Console.ReadLine());
            int hyacinths = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double cost = magnolias * 3.25 + hyacinths * 4 + roses * 3.5 + cactuses * 8;
            double tax = cost * 0.05;
            double finalPrice = Math.Abs(cost - tax);
            if (finalPrice < price)
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(price - finalPrice));
            }
            else
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(finalPrice - price));
            }
        }
    }
}