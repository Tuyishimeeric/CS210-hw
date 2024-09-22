using System;
using System.Data;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your course score: ");
        int score = int.Parse(Console.ReadLine());
        string grade;
        if (score >=90);
        {
            grade = "A";
        }
        else if(score >= 80);
        {
            grade = "B";
        }
        else if(grade>=70);
        {
            grade = "C";
        }
        else if(score >=60);
        {
            grade = "D";
        
        }
        else
        {
        grade = "F";
        }
        Console.WriteLine($"your grade is: (grade)")
    }

}