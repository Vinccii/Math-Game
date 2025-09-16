using Math_Game;

Menu menu = new Menu();

DateTime date = DateTime.Now;

string name = GetName();

menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Please type your User Name :)");
    string name = Console.ReadLine();
    return name;
}


