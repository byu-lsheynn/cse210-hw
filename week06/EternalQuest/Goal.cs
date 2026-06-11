public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string descr, int points)
    {
        _shortName = name;
        _description = descr;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return "details";
    }

    public abstract string GetStringRepresentation();
    

}