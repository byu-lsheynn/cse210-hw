public class Cycling : Activity
{
    private double _speedInKph;

    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _speedInKph = speed;
    }

    public override double GetDistanceInKm()
    {
        return Math.Round(_speedInKph * (_durationInMin / 60), 1);
    }

    public override double GetSpeedInKph()
    {
        return _speedInKph;
    }

    public override double GetPace()
    {
        return Math.Round(60 / _speedInKph, 1);
    }
}