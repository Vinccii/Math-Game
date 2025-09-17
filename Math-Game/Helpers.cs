using Math_Game.Models;

namespace Math_Game
{
    internal class Helpers
    {

        internal static List<Game> games = new List<Game>();
        internal static int[] GetDivisionNumbers()
        {
            Random random = new Random();
            int[]? result = new int[2];

            int firstNumber = random.Next(0, 99);
            int secondNumber = random.Next(0, 99);

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            return new int[] { firstNumber, secondNumber };

            Console.WriteLine(result);
            return result;
        }

        internal static void AddToHistory(int gameScore, string gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
        }

        internal static void OldGames()
        {
            Console.Clear();
            Console.WriteLine("History Of Games");
            Console.WriteLine("---------------------------------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} points");
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Press any key to go back to the main menu :)");
            Console.ReadLine();
        }

    }
}
