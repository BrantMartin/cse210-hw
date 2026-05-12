using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int magicNum = rand.Next(1, 100);
        int guessInt = 1;
        while (magicNum != guessInt)
        {
            Console.Write("What is your guess? ");
            string guessStr = Console.ReadLine();
            guessInt = int.Parse(guessStr);
            if (guessInt > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if (guessInt < magicNum)
            {
                Console.WriteLine("Higher");
            }
        }
        Console.WriteLine("You guessed it!");
    }
}