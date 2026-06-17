using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Running runAct = new Running("6/17/2026", 30, 3.0);
        runAct.getSummary();
        Cycling cycAct = new Cycling("6/18/2026", 60, 3.5);
        cycAct.getSummary();
        Swimming swimAct = new Swimming("6/19/2026", 20, 20);
        swimAct.getSummary();
    }
}