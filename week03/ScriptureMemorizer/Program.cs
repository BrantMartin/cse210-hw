using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference myRef = new Reference("Mosiah", 4, 27);
        bool hidden = false;
        string choice = "";

        Scripture myScrip = new Scripture(myRef, "And see that all these things are done in wisdom and order; for it is not requisite that a man should run faster than he has strength. And again, it is expedient that he should be diligent, that thereby he might win the prize; therefore, all things must be done in order.");
        while (hidden != true && choice != "quit")
        {
            hidden = myScrip.IsCompletelyHidden();
            Console.WriteLine(myScrip.IsCompletelyHidden());
            Console.WriteLine(hidden);
            Console.WriteLine(myScrip.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            choice = Console.ReadLine();
            myScrip.HideRandomWords(5);
        }
    }
}