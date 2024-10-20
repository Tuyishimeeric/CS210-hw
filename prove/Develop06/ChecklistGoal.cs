// ChecklistGoal.cs
public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;

    public ChecklistGoal(string name, int points, int targetCount) : base(name, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
    }

    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            _points += 50; // Points for each completion

            if (_currentCount == _targetCount)
            {
                _isComplete = true;
                _points += 500; // Bonus for completing the goal
            }
        }
    }

    public override string GetDetails() => _isComplete ? $"[X] {_name} - Completed {_currentCount}/{_targetCount}" : $"[ ] {_name} - Completed {_currentCount}/{_targetCount}";

    public override int GetPoints() => _isComplete ? _points : 0;
}
