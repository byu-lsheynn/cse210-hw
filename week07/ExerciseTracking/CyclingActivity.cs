public class CyclingActivity : Activity
{
    private double _speedInKph;

    public CyclingActivity(string date, int duration, double speed) : base(date, duration)
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

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_durationInMin} min)- Distance: {GetDistanceInKm()} km, Speed: {GetSpeedInKph()} kph, Pace: {GetPace()} min per km";
    }
}