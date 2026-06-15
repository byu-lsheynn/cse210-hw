public abstract class Activity
{
    protected string _date;
    protected int _durationInMin;

    public Activity(string date, int duration)
    {
        _date = date;
        _durationInMin = duration;
    }

    public abstract double GetDistanceInKm();
    public abstract double GetSpeedInKph();
    public abstract double GetPace();
    public abstract string GetSummary();
}