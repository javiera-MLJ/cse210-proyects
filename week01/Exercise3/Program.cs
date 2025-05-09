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
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            for (int i = 0; i < 1; i++)
            {
                attempts++;
            }

            if (guess > mNumber)
            {
                Console.WriteLine("Higher");
            }
    
            else if (guess < mNumber)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
    
        }

            Console.WriteLine($"you have made {attempts} attempts");
    }
}