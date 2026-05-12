using System;

class Program
{
    static void Main(string[] args)
    {
        int inputNum = 1000;
        string inputStr = "";
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (inputNum != 0)
        {
            Console.Write("Enter number: ");
            inputStr = Console.ReadLine();
            inputNum = int.Parse(inputStr);
            if (inputNum != 0)
            {
                numbers.Add(inputNum);
            }
        }
        int sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
           sum += numbers[i]; 
        }
        Console.WriteLine($"The sum is {sum}.");
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is {average}.");
        int max = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers [i];
            }
        }
        Console.WriteLine($"The largest number is {max}.");
    }
}