using System;
using System.Collections.Generic;
using System.IO;

class SpiritualGoal : Goal
{
    public SpiritualGoal(string name, string description, int pointsPerCompletion, int completionBonus, int completionTarget)
        : base(name, description, pointsPerCompletion, completionBonus, completionTarget)
    {
    }
}