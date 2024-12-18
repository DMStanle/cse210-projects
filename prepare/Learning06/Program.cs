using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> list = new List<Shape>();
        
        Shape square = new Square(4);
        square.SetColor("Red");
        list.Add(square);

        Shape rectangle = new Rectangle(2, 4);
        rectangle.SetColor("Green");
        list.Add(rectangle);

        Shape circle = new Circle(5);
        circle.SetColor("Blue");
        list.Add(circle);

        foreach(Shape shape in list)
        {
            Console.WriteLine($"Area: {shape.GetArea()} Color: {shape.GetColor()}");
        }
    }
}