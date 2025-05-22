using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is the top number of the fraction?");
        int top = int.Parse(Console.ReadLine());

        Console.WriteLine("what is the bottom number of the fraction?");
        int bottom = int.Parse(Console.ReadLine());

        Fraction fraction = new Fraction();
        fraction.SetTop(top);
        fraction.SetBottom(bottom);
        Console.WriteLine($"fraction: {fraction.GetFractionString()}");
        Console.WriteLine($"decimal: {fraction.GetDecimalValue()}");
    }
}