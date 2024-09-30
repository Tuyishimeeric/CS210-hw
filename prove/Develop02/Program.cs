using System;

using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            UserInterface ui = new UserInterface(journal);
            ui.ShowMenu();
        }
    }

    public class Journal
    {
        private List<Entry> _entries = new List<Entry>();
        private static readonly string[] _prompts = new string[]
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        public void AddEntry(string response)
        {
            Random rand = new Random();
            string prompt = _prompts[rand.Next(_prompts.Length)];
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            _entries.Add(new Entry(prompt, response, date));
        }

        public List<Entry> GetEntries()
        {
            return _entries;
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine(entry.ToFileFormat());
                }
            }
        }

        public void LoadFromFile(string filename)
        {
            _entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var entry = Entry.FromFileFormat(line);
                    if (entry != null)
                    {
                        _entries.Add(entry);
                    }
                }
            }
        }
    }

    public class Entry
    {
        public string Prompt { get; }
        public string Response { get; }
        public string Date { get; }

        public Entry(string prompt, string response, string date)
        {
            Prompt = prompt;
            Response = response;
            Date = date;
        }

        // Converts entry to a string format for savin
        public string ToFileFormat()
        {
            return $"{Date}~|~{Prompt}~|~{Response}";
        }

        // Creates an entry from a string format
        public static Entry FromFileFormat(string line)
        {
            var parts = line.Split(new string[] { "~|~" }, StringSplitOptions.None);
            if (parts.Length == 3)
            {
                return new Entry(parts[1], parts[2], parts[0]);
            }
            return null;
        }
    }

    public class UserInterface
    {
        private Journal _journal;

        public UserInterface(Journal journal)
        {
            _journal = journal;
        }

        public void ShowMenu()
        {
            int choice;

            do
            {
                Console.Clear();
                Console.WriteLine("Journal Menu:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display journal");
                Console.WriteLine("3. Save journal to file");
                Console.WriteLine("4. Load journal from file");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                choice = int.Parse(Console.ReadLine() ?? "5");

                switch (choice)
                {
                    case 1:
                        WriteNewEntry();
                        break;
                    case 2:
                        DisplayEntries();
                        break;
                    case 3:
                        SaveJournalToFile();
                        break;
                    case 4:
                        LoadJournalFromFile();
                        break;
                }

                if (choice != 5)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

            } while (choice != 5);
        }

        private void WriteNewEntry()
        {
            Console.WriteLine("Enter your response:");
            string response = Console.ReadLine();
            _journal.AddEntry(response);
            Console.WriteLine("Entry added with the date and prompt!");
        }

        private void DisplayEntries()
        {
            var entries = _journal.GetEntries();
            if (entries.Count == 0)
            {
                Console.WriteLine("No entries found.");
                return;
            }

            Console.WriteLine("Journal Entries:");
            foreach (var entry in entries)
            {
                Console.WriteLine($"Date: {entry.Date}");
                Console.WriteLine($"Prompt: {entry.Prompt}");
                Console.WriteLine($"Response: {entry.Response}");
                Console.WriteLine(new string('-', 40));
            }
        }

        private void SaveJournalToFile()
        {
            Console.Write("Enter filename to save journal: ");
            string filename = Console.ReadLine();
            _journal.SaveToFile(filename);
            Console.WriteLine("Journal saved successfully!");
        }

        private void LoadJournalFromFile()
        {
            Console.Write("Enter filename to load journal: ");
            string filename = Console.ReadLine();

            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }

            _journal.LoadFromFile(filename);
            Console.WriteLine("Journal loaded successfully!");
        }
    }
}