// Activity.cs
using System;

public abstract class MindfulnessActivity
{
    private string _name;
    private string _description;
    protected int _duration;  // Changed to protected

    public MindfulnessActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void Start()
    {
        Utils.DisplayStartMessage(_name, _description, _duration);
        RunActivity();
        Utils.DisplayEndMessage(_name, _duration);
    }

    protected abstract void RunActivity();
}

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void RunActivity()
    {
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.WriteLine("Breathe in...");
            Utils.PauseWithAnimation(4);
            Console.WriteLine("Breathe out...");
            Utils.PauseWithAnimation(4);
        }
    }
}

public class ReflectionActivity : MindfulnessActivity
{
    public ReflectionActivity()
        : base("Reflection Activity", "This activity will help you reflect on a personal success or strength.")
    {
    }

    protected override void RunActivity()
    {
        Console.WriteLine("Think about a time you succeeded. Take your time...");
        Utils.PauseWithAnimation(_duration);
    }
}

public class ListingActivity : MindfulnessActivity
{
    public ListingActivity()
        : base("Listing Activity", "This activity will help you list things that you are grateful for.")
    {
    }

    protected override void RunActivity()
    {
        Console.WriteLine("List as many things as you can that bring you joy or gratitude.");
        Utils.PauseWithAnimation(_duration);
    }
}

