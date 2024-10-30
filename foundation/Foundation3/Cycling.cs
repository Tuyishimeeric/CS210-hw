public class Cycling : Activity
{
    private double speed; // in mph

    public Cycling(string date, int duration, double speed)
        : base(date, duration)
    {
        this.speed = speed;
    }

    public override double GetDistance() => (speed * Duration) / 60; // miles

    public override double GetSpeed() => speed; // mph

    public override double GetPace() => 60 / speed; // min per mile
}
