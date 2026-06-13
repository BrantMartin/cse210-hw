public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on you breathing.";
        _duration = 0;
    }


    public void Run()
    {
        ShowLoading(3);
        DisplayStartingMessage();
        ShowLoading(3);
        Console.WriteLine("Go!\n");
        Thread.Sleep(800);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...0");
            ShowCountDown(3);
            Console.Write("\nBreathe out...0");
            ShowCountDown(3);
        }
        DisplayEndingMessage();
    }
}