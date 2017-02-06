namespace Problem_06.Letters_Combinations
{
    using System;

    public class Program
    {
        private static void Main()
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char skip = char.Parse(Console.ReadLine());
            int counter = 0;
            Console.WriteLine();
            for (char i = start; i <= end; i++)
            {
                for (char k = start; k <= end; k++)
                {
                    for (char l = start; l <= end; l++)
                    {
                        if (i == skip || k == skip || l == skip)
                        {

                        }
                        else
                        {
                            counter++;
                            Console.Write("{0}{1}{2} ", i, k, l);
                        }
                    }
                }
            }

            Console.Write(counter);
        }
    }
}