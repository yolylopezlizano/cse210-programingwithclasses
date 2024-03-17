using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    private static List<Scripture> Scriptures { get; set; }

    static Program()
    {
        Scriptures = new List<Scripture>
        {
            new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture("Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine cown dunderstanding. In all thy ways acknowledge him, and he shall direct thy paths. "),
            new Scripture("1 Nephi 3:7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth  no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
            // Add more scriptures as needed
        };
    }

    public static void Main(string[] args)
    {
        ChooseScripture();
    }

    private static void ChooseScripture()
    {
        Console.WriteLine("Choose a scripture to memorize:");

        for (int i = 0; i < Scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Scriptures[i].Reference}");
        }

        int chosenIndex;
        do
        {
            Console.Write("Enter the number of the scripture you want to memorize: ");
        } while (!int.TryParse(Console.ReadLine(), out chosenIndex) || chosenIndex < 1 || chosenIndex > Scriptures.Count);

        MemorizeScripture(Scriptures[chosenIndex - 1]);
    }

    private static void MemorizeScripture(Scripture scripture)
    {
        while (true)
        {
            scripture.Display();
            Console.WriteLine("Press 'q' to quit, 'n' for the next scripture, or any other key to continue memorizing.");
            var input = Console.ReadLine().ToLower();
            if (input == "q")
                return;
            if (input == "n")
                break;
            if (!scripture.HideRandomWord())
            {
                Console.WriteLine("All words are hidden. Exiting...");
                return;
            }
            Console.Clear();
        }

        Console.WriteLine("Would you like to memorize the next scripture? (yes/no)");
        var response = Console.ReadLine().ToLower();
        if (response == "yes" || response == "y")
        {
            var nextIndex = (Scriptures.IndexOf(scripture) + 1) % Scriptures.Count;
            MemorizeScripture(Scriptures[nextIndex]);
        }
        else if (response == "no" || response == "n")
        {
            Console.WriteLine("Exiting...");
            return;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
        }
    }
}