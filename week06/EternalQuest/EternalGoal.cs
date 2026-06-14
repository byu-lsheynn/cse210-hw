public class EternalGoal : Goal
{
    public EternalGoal(string name, string descr, string  points) : base(name, descr, points)
    { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You earned {_points} points!");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal:{_shortName}|{_description}|{_points}";
    }
}