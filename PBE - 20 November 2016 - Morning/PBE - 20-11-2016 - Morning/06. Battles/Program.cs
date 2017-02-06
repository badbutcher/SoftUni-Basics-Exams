namespace _06.Battles
{
    using System;

    public class Program
    {
        private static void Main()
        {
            int playerOnePokemons = int.Parse(Console.ReadLine());
            int playerTwoPokemons = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 1; i <= playerOnePokemons; i++)
            {
                for (int k = 1; k <= playerTwoPokemons; k++)
                {
                    Console.Write("({0} <-> {1}) ", i, k);
                    counter++;
                    if (counter == maxBattles)
                    {
                        break;
                    }
                }

                if (counter == maxBattles)
                {
                    break;
                }
            }
        }
    }
}