namespace Problem02_Firm
{
    using System;

    public class Program
    {
        private static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workersInOvertime = int.Parse(Console.ReadLine());

            double totalWorkTime = (days - (10 * days) / 100.00d) * 8;
            double overTimeWork = workersInOvertime * (2 * days);
            double timeNeeded = Math.Floor(totalWorkTime + overTimeWork);

            if (timeNeeded >= hours)
            {
                Console.WriteLine("Yes!{0} hours left.", timeNeeded - hours);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", hours - timeNeeded);
            }
        }
    }
}