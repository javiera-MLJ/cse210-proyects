using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Pink", 4);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("black", 6, 8);
        shapes.Add(rectangle);

        Circle circle = new Circle("Purple", 2.5);
        shapes.Add(circle);
        
        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}