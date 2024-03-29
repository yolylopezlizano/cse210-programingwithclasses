using System;
using System.Collections.Generic;
using System.IO;

class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int pointsPerCompletion, int completionBonus, int completionTarget)
        : base(name, description, pointsPerCompletion, completionBonus, completionTarget)
    {
    }
}
