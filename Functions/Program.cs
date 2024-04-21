Console.WriteLine("Are you coming or leaving? (in/out)");
string userChoice = Console.ReadLine();

if (userChoice == "in" )
{
    PrintHello();
}
else if (userChoice == "out" )
{
    PrintGoodBye();
}
else
{
    Console.WriteLine("Invalid input");
}

static void PrintHello()
{
    Console.WriteLine("Hello world!");
}

static void PrintGoodBye()
{
    Console.WriteLine("Good bye cruel world!");
}