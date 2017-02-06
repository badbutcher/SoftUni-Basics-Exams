namespace Problem05_Axe
{
    using System;

    public class Program
    {
        private static void Main()
        {
            ////It's ugly

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{2}", new string('-', n * 3), new string('*', 2), new string('-', n * 2 - 2));
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', n * 3), new string('-', i), new string('-', (5 * n) - (3 * n) - i - 2));
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}", new string('*', n * 3), new string('-', n - 1));
            }

            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', n * 3 - i), new string('-', n + i * 2 - 1), new string('-', n - 2 - i + 1));
            }

            Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n - n / 2 + 1), new string('*', n + (n / 2 - 1) * 2 - 1), new string('-', n - 2 - n / 2 + 2));
        }
    }
}