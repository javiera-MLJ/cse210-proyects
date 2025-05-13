using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {


        Random randomGenerator = new Random();
        int mNumber = randomGenerator.Next(1, 1000);
    
        int guess = -1;
        int attempts = 0;

        while (guess != mNumber)
        {
            Console.Write("what is your guess? (between 1 and 999): ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            attempts++;

            if (guess > mNumber)
            {
                Console.WriteLine("Lower");
            }
    
            else if (guess < mNumber)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
    
        }
            Console.WriteLine();
            Console.WriteLine($"You have made {attempts} attempts");
    }
}