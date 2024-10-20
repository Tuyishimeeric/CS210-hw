// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        int userScore = 0;
        Goal[] goals = new Goal[0];

        // Load existing goals
        (goals, userScore) = SaveLoad.LoadGoals();

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Your Score: {userScore}");
            Utils.DisplayGoals(goals);

            Console.WriteLine("\n1. Add Simple Goal");
            Console.WriteLine("2. Add Eternal Goal");
            Console.WriteLine("3. Add Checklist Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Exit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter goal name: ");
                    string simpleName = Console.ReadLine();
                    goals = AddGoal(goals, new SimpleGoal(simpleName, 1000));
                    break;

                case "2":
                    Console.Write("Enter goal name: ");
                    string eternalName = Console.ReadLine();
                    goals = AddGoal(goals, new EternalGoal(eternalName, 0));
                    break;

                case "3":
                    Console.Write("Enter goal name: ");
                    string checklistName = Console.ReadLine();
                    Console.Write("Enter target count: ");
                    int targetCount = int.Parse(Console.ReadLine());
                    goals = AddGoal(goals, new ChecklistGoal(checklistName, 0, targetCount));
                    break;

                case "4":
                    Console.Write("Enter goal index to record (0-based): ");
                    int index = int.Parse(Console.ReadLine());
                    if (index >= 0 && index < goals.Length)
                    {
                        goals[index].RecordEvent();
                        userScore += goals[index].GetPoints();
                    }
                    break;

                case "5":
                    SaveLoad.SaveGoals(goals, userScore);
                    Console.WriteLine("Goals saved.");
                    Utils.Pause();
                    break;

                case "6":
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static Goal[] AddGoal(Goal[] goals, Goal newGoal)
    {
        Array.Resize(ref goals, goals.Length + 1);
        goals[goals.Length - 1] = newGoal;
        return goals;
    }
}
