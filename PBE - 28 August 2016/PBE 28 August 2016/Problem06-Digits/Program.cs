namespace Problem06_Digits
{
    using System;

    public class Program
    {
        private static void Main()
        {
            string n = Console.ReadLine();
            int firstDigit = int.Parse(n.Substring(0, 1));
            int secondDigit = int.Parse(n.Substring(1, 1));
            int thirdDigit = int.Parse(n.Substring(2, 1));
            int rows = firstDigit + secondDigit;
            int cols = firstDigit + thirdDigit;
            int currentNum = int.Parse(n);

            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < cols; k++)
                {
                    if (currentNum % 5 == 0)
                    {
                        currentNum -= firstDigit;
                        Console.Write(currentNum + " ");
                    }
                    else if (currentNum % 3 == 0)
                    {
                        currentNum -= secondDigit;
                        Console.Write(currentNum + " ");
                    }
                    else
                    {
                        currentNum += thirdDigit;
                        Console.Write(currentNum + " ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}