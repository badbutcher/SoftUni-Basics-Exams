namespace Problem_04.Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static void Main()
        {
            int studentsCount = int.Parse(Console.ReadLine());

            double fiveOrMore = 0;
            double betweenFiveAndFour = 0;
            double betweenFourAndThree = 0;
            double lessThanThree = 0;
            List<double> avr = new List<double>();
            for (int i = 0; i < studentsCount; i++)
            {
                double student = double.Parse(Console.ReadLine());
                avr.Add(student);
                if (student >= 5)
                {
                    fiveOrMore++;
                }
                else if (student <= 4.99 && student >= 4)
                {
                    betweenFiveAndFour++;
                }
                else if (student <= 3.99 && student >= 3)
                {
                    betweenFourAndThree++;
                }
                else if (student <= 3)
                {
                    lessThanThree++;
                }
            }

            Console.WriteLine("Top students: {0:F2}%", fiveOrMore / studentsCount * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:F2}%", betweenFiveAndFour / studentsCount * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:F2}%", betweenFourAndThree / studentsCount * 100);
            Console.WriteLine("Fail: {0:F2}%", lessThanThree / studentsCount * 100);
            Console.WriteLine("Average: {0:F2}", avr.Average());

        }
    }
}