using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime dateTime = DateTime.Now;
        string dateText = dateTime.ToShortDateString();
        string prompt = "";
        string entry = "";
        string choiceStr = "";
        int choice = 0;
        PromptGenerator myGenerator = new PromptGenerator();
        Entry myEntry = new Entry();
        Journal myJournal = new Journal();

        myGenerator._prompts.Add("What is your name?");
        myGenerator._prompts.Add("What is your favorite color?");
        myGenerator._prompts.Add("How are you feeling?");
        myGenerator._prompts.Add("Do you like being asked questions?");

        while (choice != 5)
        {
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            choiceStr = Console.ReadLine();
            choice = int.Parse(choiceStr);

            if (choice == 1)
            {
                prompt = myGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                entry = Console.ReadLine();
                myEntry._date = dateText;
                myEntry._promptText = prompt;
                myEntry._entryText = entry;
                myJournal.AddEntry(myEntry);
            }
            else if (choice == 2)
            {
                myJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                myJournal.SaveToFile("journalFile.txt");
            }
            else if (choice == 4)
            {
                myJournal.LoadFromFile("journalFile.txt");
            }
            else if (choice == 5)
            {
                Console.WriteLine("Good-Bye!");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}