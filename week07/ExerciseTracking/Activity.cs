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
    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_durationInMin} min)- Distance: {GetDistanceInKm()} km, Speed: {GetSpeedInKph()} kph, Pace: {GetPace()} min per km";
    }
}