public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, string points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congrats you earned {_points} points.");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return _description;
    }

    public override string GetStringRepresentational()
    {
        return $"{_shortName}: {_description} is worth {_points}.";
    }
}