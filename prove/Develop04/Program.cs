using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        string choice;
        
        // Loop to keep the program running until "4.quit" is entered
        while (true)
        {
            // Main menu
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("What you want to do today?: ");
            choice = Console.ReadLine();

            // Check if the user wants to quit
            if (choice.ToLower() == "4")
                break;

            Activity activity;

            // Instantiate the selected activity
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity("Breathing Activity", "Helps you relax by guiding deep breathing.");
                    break;
                case "2":
                    activity = new ReflectionActivity("Reflection Activity", "Helps you reflect on past experiences.");
                    break;
                case "3":
                    activity = new ListingActivity("Listing Activity", "Helps you list positive aspects of your life.");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    continue;
            }

            // Start the selected activity
            activity.Start();
        }
    }
}
