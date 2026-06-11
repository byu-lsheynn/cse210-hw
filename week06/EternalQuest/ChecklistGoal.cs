public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string descr, int points, int target, int bonus) : base(name, descr, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetDetailsString()
    {
        return "details";
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}