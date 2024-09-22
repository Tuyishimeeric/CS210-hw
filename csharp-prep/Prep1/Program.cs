using System;

class Program
{
    static void Main(string[] args)
    
    {
        Console.WriteLine("what is your first name?");
        string firstname =Console.ReadLine();

        Console.Write("what is your second name?");
        string secondname =Console.ReadLine();


        Console.WriteLine($"your name is {firstname} {secondname}");
    }

    
}