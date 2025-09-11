using System;

Console.WriteLine("Please type your User Name :)");

string name = Console.ReadLine();
DateTime date = DateTime.UtcNow;

Console.WriteLine("---------------------------------------------");
Console.WriteLine($"Hello {name.ToUpper()}. It's {date}. This is your math's game. Keep improving everyday, never give up :)\n");
Console.WriteLine(@$"What game would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
Console.WriteLine("---------------------------------------------");

string gameSelected = Console.ReadLine();

if (gameSelected.Trim().ToLower() == "a")
{
    AdditionGame("Addition selected");
}
else if (gameSelected.Trim().ToLower() == "s")
{
    SubtractionGame("Subtraction selected");
}
else if (gameSelected.Trim().ToLower() == "m")
{
    MultiplicationGame("Multiplication selected");
}
else if (gameSelected.Trim().ToLower() == "d")
{
    DivisionGame("Division selected");
}
else if (gameSelected.Trim().ToLower() == "q")
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
}
else
{
    Console.WriteLine("Invalid Input");
    Environment.Exit(1);
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
