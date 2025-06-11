using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square(8, "Blue");
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle(5, 4, "Yellow");
        shapes.Add(shape2);

        Circle shape3 = new Circle(7, "Green");
        shapes.Add(shape3);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area:F2}.");
        }
    }
}