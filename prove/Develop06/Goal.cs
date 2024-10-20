// Goal.cs
using System;

public abstract class Goal
{
    protected string _name;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _isComplete = false;
    }

    public abstract void RecordEvent();
    public abstract string GetDetails();
    public abstract int GetPoints();

    public bool IsComplete() => _isComplete;
}
