using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numToHide = 3)
    {
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        var wordsToHide = visibleWords.OrderBy(x => Guid.NewGuid()).Take(Math.Min(numToHide, visibleWords.Count));

        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    public string Display()
    {
        return $"{_reference}\n{string.Join(" ", _words)}";
    }
}

public class Program
{
    public static void ClearConsole()
    {
        Console.Clear();
    }

    public static void Main(string[] args)
    {
        var reference = new Reference("Proverbs", 3, 5, 6);
        var scripture = new Scripture(reference, 
            "Trust in the Lord with all thine heart and lean not unto thine own understanding");

        while (!scripture.AllWordsHidden())
        {
            ClearConsole();
            Console.WriteLine(scripture.Display());
            Console.Write("\nPress Enter to hide words or type 'quit' to exit: ");
            var userInput = Console.ReadLine();

            if (userInput?.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }

        Console.WriteLine("All words have been hidden. Thank you for practicing!");
    }
}
