using System;

Console.WriteLine("Please type your User Name :)");

string name = Console.ReadLine();
DateTime date = DateTime.Now;

Menu(name, date);

void Menu(string name, DateTime date)
{
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine($"Hello {name.ToUpper()}. It's {date:HH:mm} on {date:dd.MM.yyyy}. This is your math game! Keep improving everyday, never give up :)\n");
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
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Input");
            Environment.Exit(0);
            break;
    }
}

void AdditionGame(string message)
{
    Console.WriteLine(message);
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);
}

void DivisionGame(string message)
{
    Console.WriteLine(message);
}
