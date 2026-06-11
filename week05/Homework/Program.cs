using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assig = new Assignment("Samuel Bennett", "Multiplication");
        MathAssignment mathAssig = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        WritingAssignment writAssig = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");


        Console.WriteLine($"{assig.GetSummary()}\n");
        Console.WriteLine($"{mathAssig.GetSummary()}");
        Console.WriteLine($"{mathAssig.GetHomeWorkList()}\n");
        Console.WriteLine($"{writAssig.GetSummary()}");
        Console.WriteLine($"{writAssig.GetWritingInformation()}");
    }
}