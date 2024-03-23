using System;
using System.Threading;

// Derived class for Breathing Activity
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public override void Start()
    {
        Console.WriteLine($"{name} - {description}");
        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds before starting

        // Breathing loop
        for (int i = duration; i > 0; i--)
        {
            Console.WriteLine(i % 2 == 0 ? "Breathe in..." : "Breathe out...");
            Console.WriteLine($"Time remaining: {i} seconds");
            Thread.Sleep(1000); // Pause for 1 second
            Console.SetCursorPosition(0, Console.CursorTop - 1); // Move cursor up one line
        }

        // Display finishing message
        Console.WriteLine($"Good job! You have completed the {name} for {duration} seconds.");
        Thread.Sleep(3000); // Pause for 3 seconds before exiting
    }
}