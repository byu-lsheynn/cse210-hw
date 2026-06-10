using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Blue", 4);
        Rectangle rectangle = new Rectangle("Red", 3, 2);
        Circle circle = new Circle("Yellow", 2.5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea():F2} inches.\n");
        }
    }
}