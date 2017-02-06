namespace Problem03_Hotel_Room
{
    using System;

    public class Program
    {
        private static void Main()
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartmentPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                apartmentPrice = 65;

                if (nights > 14)
                {
                    studioPrice -= (studioPrice * 30) / 100;
                }
                else if (nights > 7)
                {
                    studioPrice -= (studioPrice * 5) / 100;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;

                if (nights > 14)
                {
                    studioPrice -= (studioPrice * 20) / 100;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76;
                apartmentPrice = 77;
            }

            if (nights > 14)
            {
                apartmentPrice -= (apartmentPrice * 10) / 100;
            }

            Console.WriteLine("Apartment: {0:F2} lv.", apartmentPrice * nights);
            Console.WriteLine("Studio: {0:F2} lv.", studioPrice * nights);
        }
    }
}