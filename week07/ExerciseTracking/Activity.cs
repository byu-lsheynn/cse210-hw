public abstract class Activity
{
    protected DateTime _date;
    protected int _durationInMin;

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _durationInMin = duration;
    }

    public abstract double GetDistanceInKm();
    public abstract double GetSpeedInKph();
    public abstract double GetPace();
    public abstract string GetSummary();
}