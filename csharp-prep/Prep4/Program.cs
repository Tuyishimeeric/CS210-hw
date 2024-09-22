using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main()
    {
        List<int> numbers = new List<int>();
        int usernum;
        Console.WriteLine("enter a list of numbers, type 0 when finished");
        do
        {
            usernum = int.Parse(Console.ReadLine());
            if (usernum != 0)
            {
                numbers.Add(usernum);
            }
        }
        while (usernum != 0);
        if (numbers.Count > 0)
        {
            int sum = 0;
            int largest = numbers[0];

            foreach (int number in numbers)
            {
                sum += number;
                if (number > largest)
                {
                    largest = number;
                }
            }
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"sum of the numbers : {sum}");

            Console.WriteLine($"average of the numbers: {average}");

            Console.WriteLine($"the largest number in the list is: {largest}");
        }
        else
        {
            Console.WriteLine("No numbers were entered");
        }
    }
}