namespace _03.Vacation
{
    using System;

    public class Program
    {
        private static void Main()
        {
            int oldPeople = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string transportType = Console.ReadLine();

            double hotelPrice = 82.99;
            double trainOld = 24.99;
            double trainStudents = 14.99;
            double busOld = 32.50;
            double busStudents = 28.50;
            double boatOld = 42.99;
            double boatStudents = 39.99;
            double airplaneOld = 70.00;
            double airplaneStudents = 50.00;
            double cost = 0;

            if (transportType == "train")
            {
                if (oldPeople + students >= 50)
                {
                    trainOld -= 24.99 * 0.50;
                    trainStudents -= 14.99 * 0.50;

                    cost = ((((oldPeople * trainOld) + (students * trainStudents)) * 2) + nights * hotelPrice);
                    cost += cost * 0.10;
                }
                else
                {
                    cost = ((((oldPeople * trainOld) + (students * trainStudents)) * 2) + nights * hotelPrice);
                    cost += cost * 0.10;
                }
            }
            else if (transportType == "bus")
            {
                cost = ((((oldPeople * busOld) + (students * busStudents)) * 2) + nights * hotelPrice);
                cost += cost * 0.10;
            }
            else if (transportType == "boat")
            {
                cost = ((((oldPeople * boatOld) + (students * boatStudents)) * 2) + nights * hotelPrice);
                cost += cost * 0.10;
            }
            else if (transportType == "airplane")
            {
                cost = ((((oldPeople * airplaneOld) + (students * airplaneStudents)) * 2) + nights * hotelPrice);
                cost += cost * 0.10;
            }

            Console.WriteLine("{0:F2}", cost);
        }
    }
}