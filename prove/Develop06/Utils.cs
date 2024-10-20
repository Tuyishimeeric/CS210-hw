// Utils.cs
using System;

public static class Utils
{
    public static void Pause()
    {
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    public static void DisplayGoals(Goal[] goals)
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetDetails());
        }
    }
}
