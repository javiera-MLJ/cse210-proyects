using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string uName = PromptUserName();
        int fNumber = PromptUserNumber();
        int sNumber = SquareNumber(fNumber);

        DisplayResult(uName, sNumber);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("what is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("what is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
    
}