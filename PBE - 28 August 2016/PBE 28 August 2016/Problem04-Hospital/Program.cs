namespace Problem04_Hospital
{
    using System;

    public class Program
    {
        private static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;

            for (int i = 1; i <= days; i++)
            {
                int patients = int.Parse(Console.ReadLine());

                if ((untreatedPatients > treatedPatients) && (i % 3 == 0))
                {
                    doctors++;
                }

                if (patients <= doctors)
                {
                    treatedPatients += patients;
                }
                else
                {
                    untreatedPatients += patients - doctors;
                    treatedPatients += doctors;
                }
            }

            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
        }
    }
}