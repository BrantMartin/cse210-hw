public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    protected Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write($"How long, in seconds, would you like for your session to be? ");
        _duration = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!!\n");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
        ShowLoading(3);
    }

    public void ShowLoading(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Thread.Sleep(500);
            Console.Write(".");
        }
        Thread.Sleep(800);
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = 0; i < (seconds + 1); i++)
        {
            Console.Write("\b \b");
            Console.Write($"{i}");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\n");
    }
}