public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string descr, int points) : base(name, descr, points)
    { }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}