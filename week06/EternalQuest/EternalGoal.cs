public class EternalGoal : Goal
{
    private int _streakCount = 0;
    private DateTime? _lastRecorded;

    public EternalGoal(string name, string descr, string points) : base(name, descr, points)
    {
        _streakCount = 0;
        _lastRecorded = null;
    }

    // loading from file
    public EternalGoal(string name, string descr, string points, int streakCount, DateTime? lastRecorded) : base(name, descr, points)
    {
        _streakCount = streakCount;
        _lastRecorded = lastRecorded;
    }

    public override void RecordEvent()
    {
        DateTime today = DateTime.Today;

        if (_lastRecorded == null)
        {
            _streakCount = 1;
        }
        else
        {
            int daysPassed = (today - _lastRecorded.Value.Date).Days;

            if (daysPassed == 1)
            {
                _streakCount++;
            }
            else if (daysPassed > 1)
            {
                _streakCount = 1;
            }
        }

        _lastRecorded = today;
        
        Console.WriteLine($"\nCongratulations! You earned {_points} points!");
        Console.WriteLine($"Current Streak: {_streakCount} day(s).");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string dateString = _lastRecorded.HasValue ? _lastRecorded.Value.ToString("yyyy-MM-dd") : "None";
        return $"Eternal Goal:{_shortName}|{_description}|{_points}|{_streakCount}|{dateString}";
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description}) -- Streak: {_streakCount}";
    }
}