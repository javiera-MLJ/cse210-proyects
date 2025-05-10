using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        int sum = 0;
        int average = 0;

        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        if (numbers.Count > 0)
        {
            foreach (int num in numbers)
            {
                sum += num;
            }
            average = sum / numbers.Count;
            int max = numbers.Max();
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
        }
    }
}