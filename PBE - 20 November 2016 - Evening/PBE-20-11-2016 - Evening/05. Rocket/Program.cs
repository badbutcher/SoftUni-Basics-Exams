﻿namespace _05.Rocket
{
    using System;

    public class Program
    {
        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', 2 * n - n / 2 - i - 1), new string(' ', i * 2));
            }

            Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('*', n * 2));

            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', n / 2), new string('\\', n * 2 - 2));
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', n / 2 - i), new string('*', 2 * n - 2 + i * 2));
            }
        }
    }
}