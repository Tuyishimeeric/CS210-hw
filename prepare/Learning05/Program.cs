using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Assignment
        Assignment assignment = new Assignment("Alice Smith", "C# Basics");

        // Get the summary and display it
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);

        // Create an instance of MathAssignment
        MathAssignment mathAssignment = new MathAssignment("Bob Johnson", "Algebra", "Chapter 5 Problems 1-10");

        // Test GetSummary and GetHomeworkList methods
        string mathSummary = mathAssignment.GetSummary();
        string homeworkList = mathAssignment.GetHomeworkList();

        Console.WriteLine(mathSummary);
        Console.WriteLine($"Homework: {homeworkList}");

        // Create an instance of WritingAssignment
        WritingAssignment writingAssignment = new WritingAssignment("Charlie Brown", "Creative Writing", "My Summer Vacation");

        // Test GetSummary and GetWritingInformation methods
        string writingSummary = writingAssignment.GetSummary();
        string writingInfo = writingAssignment.GetWritingInformation();

        Console.WriteLine(writingSummary);
        Console.WriteLine(writingInfo);
    }
}
