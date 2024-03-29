using System;
using System.Collections.Generic;
using System.IO;


class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int PointsPerCompletion { get; set; }
    public int CompletionBonus { get; set; }
    public int CompletionTarget { get; set; }
    public int Completions { get; set; }

    public Goal(string name, string description, int pointsPerCompletion, int completionBonus, int completionTarget)
    {
        Name = name;
        Description = description;
        PointsPerCompletion = pointsPerCompletion;
        CompletionBonus = completionBonus;
        CompletionTarget = completionTarget;
    }

    public virtual int CalculatePointsEarned()
    {
        return Completions * PointsPerCompletion + (Completions / CompletionTarget) * CompletionBonus;
    }
}
