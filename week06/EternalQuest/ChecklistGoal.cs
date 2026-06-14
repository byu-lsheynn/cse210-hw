public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string descr, string points, int target, int bonus) : base(name, descr, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Loading from file
    public ChecklistGoal(string name, string descr, string points, int amountCompleted, int target, int bonus) : base(name, descr, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            Console.WriteLine($"Congratulations! You earned {_points} points!");
            _amountCompleted += 1;
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
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
        string statusCheck;

        if (IsComplete())
        {
            statusCheck = "[x]";
        }
        else
        {
            statusCheck = "[ ]";
        }

        return $"{statusCheck} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal:{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }

    public int GetBonus()
    {
        return _bonus;
    }
}