namespace _04.SoftUni_Camp
{
    using System;

    public class Program
    {
        private static void Main()
        {
            int students = int.Parse(Console.ReadLine());

            int totalPeople = 0;
            int car = 0;
            int microbus = 0;
            int bus = 0;
            int bigbus = 0;
            int train = 0;

            for (int i = 0; i < students; i++)
            {
                int group = int.Parse(Console.ReadLine());
                totalPeople += group;
                if (group <= 5)
                {
                    car += group;
                }
                else if (group >= 6 && group <= 12)
                {
                    microbus += group;
                }
                else if (group >= 13 && group <= 25)
                {
                    bus += group;
                }
                else if (group >= 26 && group <= 40)
                {
                    bigbus += group;
                }
                else if (group >= 41)
                {
                    train += group;
                }
            }

            Console.WriteLine("{0:F2}%", (double)car / totalPeople * 100);
            Console.WriteLine("{0:F2}%", (double)microbus / totalPeople * 100);
            Console.WriteLine("{0:F2}%", (double)bus / totalPeople * 100);
            Console.WriteLine("{0:F2}%", (double)bigbus / totalPeople * 100);
            Console.WriteLine("{0:F2}%", (double)train / totalPeople * 100);
        }
    }
}