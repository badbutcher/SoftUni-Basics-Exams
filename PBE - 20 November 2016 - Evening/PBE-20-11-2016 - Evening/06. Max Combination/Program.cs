namespace _06.Max_Combination
{
    using System;

    public class Program
    {
        private static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = start; i <= end; i++)
            {
                for (int k = start; k <= end; k++)
                {
                    Console.Write("<{0}-{1}>", i, k);
                    counter++;
                    if (counter == stop)
                    {
                        break;
                    }
                }

                if (counter == stop)
                {
                    break;
                }
            }
        }
    }
}