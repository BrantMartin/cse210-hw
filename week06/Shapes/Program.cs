using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square(3.0));
        shapes[0].SetColor("Red");
        shapes.Add(new Rectangle(3.0, 4.0));
        shapes[1].SetColor("Blue");
        shapes.Add(new Circle(3.0));
        shapes[2].SetColor("Yellow");

        for (int i = 0; i < shapes.Count(); i++)
        {
            Console.WriteLine(shapes[i].GetColor());
            Console.WriteLine(shapes[i].GetArea());
        }
    }
}