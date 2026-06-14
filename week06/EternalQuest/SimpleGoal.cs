public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string descr, string points) : base(name, descr, points)
    {
        _isComplete = false;
    }

    // Loading from a file
    public SimpleGoal(string name, string descr, string points, bool isComplete) : base(name, descr, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You earned {_points} points!");
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal:{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}