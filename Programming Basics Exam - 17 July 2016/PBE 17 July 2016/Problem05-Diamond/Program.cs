namespace Problem05_Diamond
{
    using System;

    public class Program
    {
        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', 3 * n));

            for (int i = n - 1; i > 0; i--)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', 5 * n - 2 - 2 * i));
            }

            Console.WriteLine(new string('*', n * 5));

            for (int i = 1; i <= 2 * n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', 5 * n - 2 - 2 * i));
            }

            Console.WriteLine("{0}{1}{0}", new string('.', n * 2 + 1), new string('*', n - 2));
        }
    }
}