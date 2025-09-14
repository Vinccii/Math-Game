using System.Runtime.InteropServices;
using static System.Formats.Asn1.AsnWriter;

DateTime date = DateTime.Now;

string name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Please type your User Name :)");
    string name = Console.ReadLine();
    return name;
}

void Menu(string name)
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
        Q - Quit the program");
        Console.WriteLine("---------------------------------------------");

        string gameSelected = Console.ReadLine();

        switch (gameSelected.Trim().ToLower())
        {
            case "a":
                AdditionGame("Addition selected");
                break;
            case "s":
                SubtractionGame("Subtraction selected");
                break;
            case "m":
                MultiplicationGame("Multiplication selected");
                break;
            case "d":
                DivisionGame("Division selected");
                break;
            case "q":
                Console.WriteLine("Goodbye");
                GameOn = false;
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid Input");
                Environment.Exit(0);
                break;
        }
    } while (GameOn);
    
}

void AdditionGame(string message)
{
    Console.WriteLine(message);

    Random random = new Random();
    int score = 0;
    
    int firstNumber;
    int secondNumber;

    for(int i = 0; i < 4; i++)
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
        if (i == 3) Console.WriteLine($"Game Over 😈. Your final score is {score}");
    }
}

void SubtractionGame(string message)
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
        if (i == 3) Console.WriteLine($"Game Over 😈. Your final score is {score}");
    }
}

void MultiplicationGame(string message)
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
        if (i == 3) Console.WriteLine($"Game Over 😈. Your final score is {score}");
    }
}

void DivisionGame(string message)
{
    int score = 0;

    for (int i =0; i < 4; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        
        int[] divisonNumbers = GetDivisionNumbers();
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
        if (i == 3) Console.WriteLine($"Game Over 😈. Your final score is {score}");
    }
    
}

int[] GetDivisionNumbers()
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


