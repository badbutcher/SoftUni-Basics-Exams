namespace _01.House_Price
{
    using System;

    public class Program
    {
        private static void Main()
        {
            double smallesRoom = double.Parse(Console.ReadLine());
            double kitchen = double.Parse(Console.ReadLine());
            double sqrMPrice = double.Parse(Console.ReadLine());

            double roomTwo = smallesRoom + smallesRoom * 0.10;
            double roomThree = roomTwo + roomTwo * 0.10;
            double batchRoom = smallesRoom / 2;
            double totalRoom = smallesRoom + kitchen + roomTwo + roomThree + batchRoom;
            Console.WriteLine("{0:F2}", (totalRoom * 0.05 + totalRoom) * sqrMPrice);
        }
    }
}