// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        MainMenu();
    }

    static void MainMenu()
    {
        while (true)
        {
            Console.WriteLine("\nMindfulness Activities Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            MindfulnessActivity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the mindfulness app. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please select again.");
                    continue;
            }

            Console.Write($"Enter duration for the {activity.GetType().Name} in seconds: ");
            if (int.TryParse(Console.ReadLine(), out int duration))
            {
                activity.SetDuration(duration);
                activity.Start();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}
