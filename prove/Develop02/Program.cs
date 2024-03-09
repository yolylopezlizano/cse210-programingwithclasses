using System;
using System.Collections.Generic;
using System.IO;

// Entry class to represent a journal entry
class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }
}

// Journal class to manage entries and perform operations
class Journal
{
    private List<Entry> entries;
    private string[] prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void WriteNewEntry()
    {
        // Prompt the user to choose a prompt
        Console.WriteLine("Select a prompt:");
        for (int i = 0; i < prompts.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {prompts[i]}");
        }

        Console.Write("Enter the prompt number: ");
        int promptIndex;
        if (!int.TryParse(Console.ReadLine(), out promptIndex) || promptIndex < 1 || promptIndex > prompts.Length)
        {
            Console.WriteLine("Invalid prompt number.\n");
            return;
        }

        string selectedPrompt = prompts[promptIndex - 1];

        Console.WriteLine($"Prompt: {selectedPrompt}");

        // Get user response
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        // Create a new entry
        Entry newEntry = new Entry
        {
            Prompt = selectedPrompt,
            Response = response,
            Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        };

        // Add entry to the journal
        entries.Add(newEntry);

        Console.WriteLine("Entry added successfully!\n");
    }

    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal.\n");
            return;
        }

        Console.WriteLine("Journal Entries:\n");
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}\n");
        }
    }

    public void SaveJournalToFile()
    {
        Console.Write("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    // Save entry details to the file
                    writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
                }
            }

            Console.WriteLine("Journal saved successfully!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}\n");
        }
    }

    public void LoadJournalFromFile()
    {
        Console.Write("Enter the filename to load the journal: ");
        string filename = Console.ReadLine();

        try
        {
            // Clear existing entries
            entries.Clear();

            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    // Read each line from the file
                    string line = reader.ReadLine();
                    string[] parts = line.Split(',');

                    // Create an entry from the file data
                    Entry loadedEntry = new Entry
                    {
                        Date = parts[0],
                        Prompt = parts[1],
                        Response = parts[2]
                    };

                    // Add entry to the journal
                    entries.Add(loadedEntry);
                }
            }

            Console.WriteLine("Journal loaded successfully!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}\n");
        }
    }
}

// Program class to run the application
class Program
{
    static void Main()
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Journal Program Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.WriteNewEntry();
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    journal.SaveJournalToFile();
                    break;
                case "4":
                    journal.LoadJournalFromFile();
                    break;
                case "5":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.\n");
                    break;
            }
        }
    }
}
