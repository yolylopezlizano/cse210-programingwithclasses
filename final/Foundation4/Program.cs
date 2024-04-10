using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Add some activities
        activities.Add(new Running(DateTime.Now, 30, 6));
        activities.Add(new Cycling(DateTime.Now, 45, 20.0));
        activities.Add(new Swimming(DateTime.Now, 120, 100));

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
