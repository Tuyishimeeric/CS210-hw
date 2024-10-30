public class Swimming : Activity
{
    private int laps; // number of laps

    public Swimming(string date, int duration, int laps)
        : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance() => (laps * 50 / 1000) * 0.62; // converting to miles

    public override double GetSpeed()
    {
        double distance = GetDistance();
        return (distance / Duration) * 60; // mph
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return Duration / distance; // min per mile
    }
}
