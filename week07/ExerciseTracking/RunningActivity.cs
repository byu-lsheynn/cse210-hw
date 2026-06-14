using Microsoft.VisualBasic;

public class RunningActivity : Activity
{
    private double _distanceInKm;

    public RunningActivity(DateTime date, int duration, double distance) : base(date, duration)
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

    public override string GetSummary()
    {
        return $"{_date} Running ({_durationInMin} min)- Distance: {GetDistanceInKm()} km, Speed: {GetSpeedInKph()} kph, Pace: {GetPace()} min per km"; 
    }
}