public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, string points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        if (_isComplete == false)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }
        else
        {
            Console.WriteLine("You already completed this goal.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentational()
    {
        return $"{_shortName}, {_description}, {_points}, {_isComplete}";
    }
}