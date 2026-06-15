public abstract class Goal
{
    public string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }


    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        return _description;
    }

    public virtual string GetStringRepresentational()
    {
        return $"{_shortName}, {_description}, {_points}";
    }
}