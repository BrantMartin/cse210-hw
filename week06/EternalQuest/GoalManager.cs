using System.Drawing;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
    }

    public void Start()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score is {_score}.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.WriteLine($"{_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Choose which goal to make: ");
        ListGoalNames();
        Console.Write("Input number option: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a description: ");
        string description = Console.ReadLine();
        Console.Write("Input points: ");
        string points = Console.ReadLine();
        if (choice == 1)
        {
            _goals.Add(new SimpleGoal("Simple Goal", description, points));
        }
        else if (choice == 2)
        {
            _goals.Add(new EternalGoal("Eternal Goal", description, points));
        }
        else if (choice == 3)
        {
            Console.Write("Input target number: ");
            int target = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input bonus reward: ");
            int bonus = Convert.ToInt32(Console.ReadLine());
            _goals.Add(new ChecklistGoal("Checklist Goal", description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }
}