public class SwimmingActivity : Activity
{
    private int _lapCount;

    public SwimmingActivity(DateTime date, int duration, int laps) : base(date, duration)
    {
        _lapCount = laps;
    }

    public override double GetDistanceInKm()
    {
        return _lapCount * 50 / 1000;
    }

    public override double GetSpeedInKph()
    {
        return Math.Round(GetDistanceInKm() / _durationInMin * 60);
    }

    public override double GetPace()
    {
        return Math.Round(_durationInMin / GetDistanceInKm());
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_durationInMin} min)- Distance: {GetDistanceInKm()} km, Speed: {GetSpeedInKph()} kph, Pace: {GetPace()} min per km";
    }
}