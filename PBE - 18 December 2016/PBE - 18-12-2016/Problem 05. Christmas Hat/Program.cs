namespace Problem_05.Christmas_Hat
{
    using System;

    public class Program
    {
        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}/|\\{0}", new string('.', n * 2 - 1));
            Console.WriteLine("{0}\\|/{0}", new string('.', n * 2 - 1));

            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', n * 2 - i - 1), new string('-', i));
            }

            Console.WriteLine(new string('*', 4 * n + 1));
            for (int i = 0; i < 4 * n + 1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }

            Console.WriteLine();
            Console.WriteLine(new string('*', 4 * n + 1));
        }
    }
}