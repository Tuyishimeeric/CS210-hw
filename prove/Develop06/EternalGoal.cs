// EternalGoal.cs
public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        _points += 100; // Increment points every time it's recorded
    }

    public override string GetDetails() => $"{_name} (Eternal) - Total Points: {_points}";

    public override int GetPoints() => _points;
}
