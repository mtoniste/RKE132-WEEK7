using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Convert Celsius to Fahrenheit");
        Console.WriteLine("2. Convert Fahrenheit to Celsius");

        int choice = Int32.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("Enter the temperature in Celsius:");
            double celsius = Double.Parse(Console.ReadLine());
            ConvertToFahrenheit(celsius);
        }
        else if (choice == 2)
        {
            Console.WriteLine("Enter the temperature in Fahrenheit:");
            double fahrenheit = Double.Parse(Console.ReadLine());
            ConvertToCelsius(fahrenheit);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    static void ConvertToFahrenheit(double celsius)
    {
        double fahrenheit = (celsius * 9) / 5 + 32;
        Console.WriteLine($"{celsius} degrees Celsius is equal to {fahrenheit} degrees Fahrenheit.");
    }

    static void ConvertToCelsius(double fahrenheit)
    {
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is equal to {celsius} degrees Celsius.");
    }
}

//Console.WriteLine("Enter your comment:");
//string userInput = Console.ReadLine();

//CountSpaces(userInput);

//static void CountSpaces(string someString)
//{
//    someString = someString.Trim();
//    int wordCounter = 1;

//    foreach (char symbol in someString)
//    {
//        if (char.IsWhiteSpace(symbol))
//        {
//            wordCounter++;
//        }
//    }

//    string word = "word";
//    if (wordCounter > 1)
//    {
//        word = "words";
//    }

//    Console.WriteLine($"Your comment contains {wordCounter} {word}.");
//}