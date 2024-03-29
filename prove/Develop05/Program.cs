using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();

    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateNewGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 6);
    }

    static void CreateNewGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Spiritual Goal");
        Console.WriteLine("3. Checklist Goal");
        int typeChoice = int.Parse(Console.ReadLine());

        Goal goal;
        switch (typeChoice)
        {
            case 1:
                goal = CreateSimpleGoal();
                break;
            case 2:
                goal = CreateSpiritualGoal();
                break;
            case 3:
                goal = CreateChecklistGoal();
                break;
            default:
                Console.WriteLine("Invalid choice. Creating Simple Goal by default.");
                goal = CreateSimpleGoal();
                break;
        }

        goals.Add(goal);
        Console.WriteLine("Goal created successfully!");
    }

    static Goal CreateSimpleGoal()
    {
        Console.WriteLine("Enter simple goal details:");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Points per completion: ");
        int pointsPerCompletion = int.Parse(Console.ReadLine());
        Console.Write("Completion target: ");
        int completionTarget = int.Parse(Console.ReadLine());
        Console.Write("Completion bonus: ");
        int completionBonus = int.Parse(Console.ReadLine());

        return new SimpleGoal(name, description, pointsPerCompletion, completionBonus, completionTarget);
    }

    static Goal CreateSpiritualGoal()
    {
        Console.WriteLine("Enter spiritual goal details:");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Points per completion: ");
        int pointsPerCompletion = int.Parse(Console.ReadLine());
        Console.Write("Completion target: ");
        int completionTarget = int.Parse(Console.ReadLine());
        Console.Write("Completion bonus: ");
        int completionBonus = int.Parse(Console.ReadLine());

        return new SpiritualGoal(name, description, pointsPerCompletion, completionBonus, completionTarget);
    }

    static Goal CreateChecklistGoal()
    {
        Console.WriteLine("Enter checklist goal details:");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Points per completion: ");
        int pointsPerCompletion = int.Parse(Console.ReadLine());
        Console.Write("Completion target: ");
        int completionTarget = int.Parse(Console.ReadLine());
        Console.Write("Completion bonus: ");
        int completionBonus = int.Parse(Console.ReadLine());

        return new ChecklistGoal(name, description, pointsPerCompletion, completionBonus, completionTarget);
    }

    static void ListGoals()
    {
        Console.WriteLine("List of Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            string completionStatus = goals[i].Completions == goals[i].CompletionTarget ? "x" : "";
            int remainingTimes = goals[i].CompletionTarget - goals[i].Completions % goals[i].CompletionTarget;
            Console.WriteLine($"{completionStatus} {i + 1}. {goals[i].Name} - Completions: {goals[i].Completions} / Remaining: {remainingTimes}");
        }

        int totalPoints = 0;
        foreach (var goal in goals)
        {
            totalPoints += goal.CalculatePointsEarned();
        }
        Console.WriteLine($"Total points earned: {totalPoints}");
    }

    static void SaveGoals()
    {
        Console.Write("Enter filename to save goals: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine($"{goal.Name},{goal.Description},{goal.PointsPerCompletion},{goal.CompletionBonus},{goal.CompletionTarget},{goal.Completions}");
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    static void LoadGoals()
    {
        Console.Write("Enter filename to load goals: ");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            goals.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string name = parts[0];
                    string description = parts[1];
                    int pointsPerCompletion = int.Parse(parts[2]);
                    int completionBonus = int.Parse(parts[3]);
                    int completionTarget = int.Parse(parts[4]);
                    int completions = int.Parse(parts[5]);
                    Goal goal = new SimpleGoal(name, description, pointsPerCompletion, completionBonus, completionTarget);
                    goal.Completions = completions;
                    goals.Add(goal);
                }
            }
            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }

    static void RecordEvent()
    {
        Console.WriteLine("Select goal to mark as completed:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }
        int choice = int.Parse(Console.ReadLine()) - 1;

        Goal selectedGoal = goals[choice];
        selectedGoal.Completions++;

        int pointsPerCompletion = selectedGoal.PointsPerCompletion;
        int pointsEarned = pointsPerCompletion * selectedGoal.Completions;
        int bonusPointsEarned = (selectedGoal.Completions / selectedGoal.CompletionTarget) * selectedGoal.CompletionBonus;

        Console.WriteLine($"You earned {pointsPerCompletion} points for completing the task.");

        if (selectedGoal.Completions % selectedGoal.CompletionTarget == 0)
        {
            Console.WriteLine("Congratulations! You have completed your goal and earned a bonus!");
            pointsEarned += bonusPointsEarned;
            Console.WriteLine($"Bonus earned: {bonusPointsEarned}");
        }

        Console.WriteLine($"Total points earned with this task: {pointsEarned}");

        ListGoals();
    }
}
