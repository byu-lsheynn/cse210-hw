public class Running : Activity
{
    private double _distanceInKm;

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _distanceInKm = distance;
    }

    public override double GetDistanceInKm()
    {
        return _distanceInKm;
    }

    public override double GetSpeedInKph()
    {
        return Math.Round(_distanceInKm / _durationInMin * 60, 1);
    }

    public override double GetPace()
    {
        return Math.Round(_durationInMin / _distanceInKm);
    }
}