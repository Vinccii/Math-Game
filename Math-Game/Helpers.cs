using Math_Game.Models;

namespace Math_Game
{
    internal class Helpers
    {

        internal static List<Game> games = new List<Game>
        {
        /* can enter random dates/scores here to test linq qurey*/
        };
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

        internal static void AddToHistory(int gameScore, GameType gameType)
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
            var gamesToView = games.Where(x => x.Type == GameType.Division && x.Score > 3);

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

        internal static string? ResultValidation(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Error. Please write a number, not text :)");
                result = Console.ReadLine();
            }
            return result;
        }
        internal static string GetName()
        {
            Console.WriteLine("Please type your User Name :)");
            string name = Console.ReadLine();
            
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Entering a Name is nessisary to continue :/");
                name = Console.ReadLine();
            }
            return name;
        }
    }
}
