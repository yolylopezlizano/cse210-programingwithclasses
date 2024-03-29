using System;
using System.Collections.Generic;
using System.IO;

class ChecklistGoal : Goal
{
    public ChecklistGoal(string name, string description, int pointsPerCompletion, int completionBonus, int completionTarget)
        : base(name, description, pointsPerCompletion, completionBonus, completionTarget)
    {
    }
}