public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string descr, string points)
    {
        _shortName = name;
        _description = descr;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public int GetPoints()
    {
        return int.Parse(_points);
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    
    public virtual string GetDetailsString()
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

        return $"{statusCheck} {_shortName} ({_description})";
    }
}