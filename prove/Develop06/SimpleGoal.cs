// SimpleGoal.cs
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override string GetDetails() => _isComplete ? $"[X] {_name} - {_points} points" : $"[ ] {_name} - {_points} points";
    
    public override int GetPoints() => _isComplete ? _points : 0;
}
