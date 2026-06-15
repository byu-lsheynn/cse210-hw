public class SwimmingActivity : Activity
{
    private int _lapCount;

    public SwimmingActivity(string date, int duration, int laps) : base(date, duration)
    {
        _lapCount = laps;
    }

    public override double GetDistanceInKm()
    {
        return _lapCount * 50.0 / 1000.0;
    }

    public override double GetSpeedInKph()
    {
        return Math.Round(GetDistanceInKm() / _durationInMin * 60, 1);
    }

    public override double GetPace()
    {
        return Math.Round(_durationInMin / GetDistanceInKm(), 1);
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_durationInMin} min)- Distance: {GetDistanceInKm():F1} km, Speed: {GetSpeedInKph()} kph, Pace: {GetPace()} min per km";
    }
}