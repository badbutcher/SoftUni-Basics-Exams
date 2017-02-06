namespace _02.Pets
{
    using System;

    public class Program
    {
        private static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int leftoverFood = int.Parse(Console.ReadLine());
            double foodPerDayForDogsInKg = double.Parse(Console.ReadLine());
            double foodPerDayForCatsInKg = double.Parse(Console.ReadLine());
            double foodPerDayForTurtlesInGrams = double.Parse(Console.ReadLine());

            double foodForDogs = days * foodPerDayForDogsInKg;
            double foodForCats = days * foodPerDayForCatsInKg;
            double foodForTurtles = (days * foodPerDayForTurtlesInGrams) / 1000;
            double totalFood = Math.Ceiling(foodForDogs + foodForCats + foodForTurtles);

            if (totalFood > leftoverFood)
            {
                Console.WriteLine("{0} more kilos of food are needed.", totalFood - leftoverFood);           
            }
            else
            {
                Console.WriteLine("{0} kilos of food left.", leftoverFood - totalFood);
            }
        }
    }
}