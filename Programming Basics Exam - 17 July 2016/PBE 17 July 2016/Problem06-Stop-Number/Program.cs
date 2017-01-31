namespace Problem06_Stop_Number
{
    using System;

    public class Program
    {
        private static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int breaker = int.Parse(Console.ReadLine());

            for (int i = end; i >= start; i--)
            {
                {
                    if (i % 2 == 0 && i % 3 == 0)
                    {
                        if (i == breaker)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write(i + " ");
                        }
                    }
                }
            }
        }
    }
}