// SaveLoad.cs
using System;
using System.IO;

public static class SaveLoad
{
    public static void SaveGoals(Goal[] goals, int score)
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(score);
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetDetails());
            }
        }
    }

    public static (Goal[] goals, int score) LoadGoals()
    {
        if (!File.Exists("goals.txt")) return (new Goal[0], 0);

        var lines = File.ReadAllLines("goals.txt");
        int score = int.Parse(lines[0]);
        Goal[] goals = new Goal[lines.Length - 1];

        for (int i = 1; i < lines.Length; i++)
        {
            // Parse goals (this is a simplified example)
            // You would need to implement proper parsing based on goal types
        }

        return (goals, score);
    }
}
