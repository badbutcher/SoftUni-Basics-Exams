namespace _05.Fox
{
    using System;

    public class Program
    {
        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', i), new string('-', n * 2 + 1 - i * 2));
            }

            for (int i = 0; i < (n / 3); i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', n / 2 + i), new string('*', n - i * 2));
            }

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', i), new string('*', n * 2 + 1 - i * 2));
            }
        }
    }
}