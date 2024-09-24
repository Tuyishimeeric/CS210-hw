using System;

using System.ComponentModel.DataAnnotations;

public class Job
    {
      public string _JobTitle;
      public string _CompanyName;
      public int _StartYear;
      public int _EndYear;
      public void Display()
      {
        Console.WriteLine($"{_JobTitle} {_CompanyName} {_StartYear} {_EndYear}");
      }
    }