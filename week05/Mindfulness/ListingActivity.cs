public class ListingActivity : Activity
{
    private int count;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in you life by having you list as many things as you can in a certain area.";
        _duration = 0;
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        ShowLoading(3);
        DisplayStartingMessage();
        GetRandomPrompt();
        GetListFromUser();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();

        Console.WriteLine(_prompts[rand.Next(5)]);
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        string inputStr = "";
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine("You may begin after go: ");
        ShowLoading(3);
        Console.WriteLine("Go!\n");
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            inputStr = Console.ReadLine();
            userList.Add(inputStr);
        }
        Console.WriteLine($"You have listed {userList.Count}!");
        return userList;
    }
}