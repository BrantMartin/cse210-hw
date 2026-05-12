using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade percentage did you get in the class? ");
        string gradeStr = Console.ReadLine();
        string letterGrade = "";
        int gradeInt = int.Parse(gradeStr);
        if (gradeInt >= 90)
        {
            letterGrade = "A";
        }
        else if (gradeInt >= 80)
        {
            letterGrade = "B";
        }
        else if (gradeInt >= 70)
        {
            letterGrade = "C";
        }
        else if (gradeInt >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        Console.Write($"Your letter grade is {letterGrade}.");

        if (gradeInt >= 70)
        {
            Console.WriteLine("You passed the class.");
        }
        else
        {
            Console.WriteLine("You did not pass the class.");
        }
    }
}