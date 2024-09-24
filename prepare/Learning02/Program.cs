using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello world");

    
    Job Job1 = new Job();
        Job1._JobTitle =" Software Engineer";
        Job1._CompanyName = "Microsoft ";
        Job1._StartYear = 2019;
        Job1._EndYear = 2022;

    Job Job2 = new Job();
        Job2._JobTitle = "Manager";
        Job2._CompanyName = "Apple";
        Job2._StartYear = 2022;
        Job2._EndYear = 2023;

        Job1. Display();
        Job2. Display();
        Resume myResume = new Resume();
        myResume._Name = "TUYISHIME Eric";

        myResume._jobs.Add(Job1);
        myResume._jobs.Add(Job2);

        myResume.Display();
    }
}