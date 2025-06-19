using System;

class Program
{
    static void Main(string[] args)
    {
        Cycling cycling1 = new Cycling(new DateTime(2022, 11, 3), 60, 3.8);
        Console.WriteLine(cycling1.GetSummary());
        Running running1 = new Running(new DateTime(2023, 04, 25), 180, 5.2);
        Console.WriteLine(running1.GetSummary());
        Swimming swimming1 = new Swimming(new DateTime(2025, 08, 15), 30, 10);
        Console.WriteLine(swimming1.GetSummary());
    }            
}