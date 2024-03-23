using System;
using System.Threading;

// Base class for activities
public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public abstract void Start();
}
