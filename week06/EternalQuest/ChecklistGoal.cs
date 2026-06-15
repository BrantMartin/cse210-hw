public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted +=1;
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Congratulations you have earned {_points + _bonus} points.");
        }
        else
        {
            Console.WriteLine($"Congratulations you have earned {_points} points.");
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        return _description;
    }

    public override string GetStringRepresentational()
    {
        return $"{_shortName}, {_description}, {_points}, {_amountCompleted}, {_target}, {_bonus}";
    }
}