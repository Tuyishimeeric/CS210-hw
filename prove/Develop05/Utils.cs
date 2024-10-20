// Utils.cs
using System;
using System.Threading;

public static class Utils
{
    public static void PauseWithAnimation(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write($"\r{new string('.', i % 4)}");
            Thread.Sleep(1000);
        }
        Console.Write("\r    ");  // Clear the animation
    }

    public static void DisplayStartMessage(string activityName, string description, int duration)
    {
        Console.WriteLine($"\nStarting {activityName}");
        Console.WriteLine(description);
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Prepare to begin...");
        PauseWithAnimation(3);
    }

    public static void DisplayEndMessage(string activityName, int duration)
    {
        Console.WriteLine("\nGood job!");
        PauseWithAnimation(2);
        Console.WriteLine($"You completed the {activityName} for {duration} seconds.");
        PauseWithAnimation(2);
    }
}

