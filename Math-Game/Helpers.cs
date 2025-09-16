namespace Math_Game
{
    internal class Helpers
    {

        internal static List<string> games = new List<string>();
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
            games.Add($"{DateTime.Now} - {gameType}: {gameScore} points.");
        }

        internal static void OldGames()
        {
            Console.Clear();
            Console.WriteLine("History Of Games");
            Console.WriteLine("---------------------------------------------");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Press any key to go back to the main menu :)");
            Console.ReadLine();
        }

    }
}
