using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        int lastNumber = grade % 10;

        if (letter != "A" && letter != "F")
        {
            if (lastNumber >= 7)
            {
                sign = "+";
            }
    
            else if (lastNumber < 3)
            {
                sign = "-";
            }
        }

        else if (letter == "A" && lastNumber < 3)
        {
            sign = "-";
        }

        Console.WriteLine($"You got an {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("congrats, you approved the course");
        }

        else
        {
            Console.WriteLine("You didn't pass, good luck next time.");
        }

    }
}