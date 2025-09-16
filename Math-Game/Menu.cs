namespace Math_Game
{
    internal class Menu
    {
        GameEngine engine = new();
        
        internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date:HH:mm} on {date:dd.MM.yyyy}. This is your math game! Keep improving everyday, never give up :)\n");
            Console.WriteLine("\n");

            bool GameOn = true;

            do
            {
                Console.WriteLine(@$"What game would you like to play today? Choose from the options below:
        
        A - Addition
        S - Subtraction
        M - Multiplication
        D - Division
        V - Game History
        Q - Quit the program");
                Console.WriteLine("---------------------------------------------");

                string gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "a":
                        GameEngine.AdditionGame("Addition selected");
                        break;
                    case "s":
                        GameEngine.SubtractionGame("Subtraction selected");
                        break;
                    case "m":
                        GameEngine.MultiplicationGame("Multiplication selected");
                        break;
                    case "d":
                        GameEngine.DivisionGame("Division selected");
                        break;
                    case "v":
                        Helpers.OldGames();
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        GameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Environment.Exit(0);
                        break;
                }
            } while (GameOn);

        }
    }
}
