using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;


class Journal
{
    private List<Entry> entries = new List<Entry>()
    {

    };
    private List<string> prompts = new List<string>() {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void WriteNewEntry()
    {
        // Select a random prompt
        Random rnd = new Random();
        int promptIndex = rnd.Next(prompts.Count);
        string selectedPrompt = prompts[promptIndex];

        // Get the user's response
        Console.WriteLine("New entry prompt: " + selectedPrompt);
        string response = Console.ReadLine();

        // Create a new entry and add it to the list
        Entry newEntry = new Entry(selectedPrompt, response, DateTime.Now.ToString());
        entries.Add(newEntry);
    }

    public void DisplayJournal()
    {
        Console.WriteLine("Journal Entries:");
        foreach (Entry entry in entries)
        {
            Console.WriteLine("Prompt: " + entry.Prompt);
            Console.WriteLine("Response: " + entry.Response);
            Console.WriteLine("Date: " + entry.Date);
            Console.WriteLine();
        }
    }

    public void SaveJournalToFile()
    {
        Console.WriteLine("Enter a filename to save the journal to:");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))

            foreach (Entry entry in entries)
            {
                outputFile.WriteLine("Prompt: " + entry.Prompt);
                outputFile.WriteLine("Response: " + entry.Response);
                outputFile.WriteLine("Date: " + entry.Date);
                outputFile.WriteLine();
            }
    }

    public void LoadJournalFromFile()
    {
        Console.WriteLine("Enter a filename to load the journal from:");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        entries.Clear();

        int currentCount = 0;
        while ( currentCount < lines.Length )
        {

            Entry newEntry = new Entry(lines[currentCount], lines[currentCount + 1], lines[currentCount + 2]);
            entries.Add(newEntry);
            currentCount = currentCount + 4;
        }
    }

    public void ShowMenu()
    {
        string input = "";
        while (input != "5")
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.WriteLine();

            Console.WriteLine("Please select an option:");
            input = Console.ReadLine();

            if (input == "1")
            {
                WriteNewEntry();
            }
            else if (input == "2")
            {
                DisplayJournal();
            }
            else if (input == "3")
            {
                SaveJournalToFile();
            }
            else if (input == "4")
            {
                LoadJournalFromFile();
            }
            else if (input == "5")
            {
                Console.WriteLine("Goodbye.");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}

class Entry
{
    public Entry(string prompt, string response, string date)
    {
        this.Prompt = prompt;
        this.Response = response;
        this.Date = date;
    }
    public string Prompt;
    public string Response;
    public string Date;

}

class Program
{
    public static void Main()
    {
        Journal journal = new Journal();
        journal.ShowMenu();
    }
}