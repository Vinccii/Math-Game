namespace Math_Game
{
    internal class GameEngine
    {
         internal static void AdditionGame(string message)
        {
            Console.WriteLine(message);

            Random random = new Random();
            int score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 4; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.Clear();
                Console.WriteLine(message);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                string result = Console.ReadLine();

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("correct!!");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("incorrect :(");
                    Console.ReadLine();
                }
                if (i == 3)
                {
                    Console.WriteLine($"Game Over 😈. Your final score is {score}. \nPress any key to go back to the main menu :)");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, "Addition");
        }

        internal static void SubtractionGame(string message)
        {
            Console.WriteLine(message);

            Random random = new Random();
            int score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 4; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.Clear();
                Console.WriteLine(message);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                string result = Console.ReadLine();

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("correct!!");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("incorrect :(");
                    Console.ReadLine();
                }
                if (i == 3)
                {
                    Console.WriteLine($"Game Over 😈. Your final score is {score}. \nPress any key to go back to the main menu :)");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, "Substraction");
        }

        internal static void MultiplicationGame(string message)
        {
            Console.WriteLine(message);
            Random random = new Random();
            int score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 4; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.Clear();
                Console.WriteLine(message);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                string result = Console.ReadLine();

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("correct!!");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("incorrect :(");
                    Console.ReadLine();
                }
                if (i == 3)
                {
                    Console.WriteLine($"Game Over 😈. Your final score is {score}. \nPress any key to go back to the main menu :)");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, "Multiplication");
        }

        internal static void DivisionGame(string message)
        {
            int score = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                int[] divisonNumbers = Helpers.GetDivisionNumbers();
                int firstNumber = divisonNumbers[0];
                int secondNumber = divisonNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                string result = Console.ReadLine();

                if (int.TryParse(result, out int answer))
                {
                    if (answer == firstNumber / secondNumber)

                    {
                        Console.WriteLine("correct!!. Press any Key to continue");
                        score++;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("incorrect :(. Press any Key to continue");
                        Console.ReadLine();
                    }
                }
                if (i == 3)
                {
                    Console.WriteLine($"Game Over 😈. Your final score is {score}. \nPress any key to go back to the main menu :)");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, "Division");
        }
    }
}
