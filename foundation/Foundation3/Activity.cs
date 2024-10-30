public abstract class Activity
{
    private string date;
    protected int Duration; // Change to protected

    protected Activity(string date, int duration)
    {
        this.date = date;
        Duration = duration; // Use the protected property
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{date} {GetType().Name} ({Duration} min): " +
               $"Distance: {GetDistance():F2}, Speed: {GetSpeed():F2}, Pace: {GetPace():F2}";
    }
}
