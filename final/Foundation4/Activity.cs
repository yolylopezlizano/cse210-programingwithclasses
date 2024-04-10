using System;
using System.Collections.Generic;

// Base Activity class
public abstract class Activity
{
    public DateTime Date { get; set; }
    public double DurationInMinutes { get; set; }

    // Abstract methods to be overridden by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Method to generate activity summary
    public virtual string GetSummary()
    {
        string distanceUnit = GetDistanceUnit();
        string speedUnit = GetSpeedUnit();
        string paceUnit = GetPaceUnit();

        return $"{Date.ToShortDateString()} {GetType().Name} ({DurationInMinutes} min) - Distance: {GetDistance():F1} {distanceUnit}, Speed: {GetSpeed():F2} {speedUnit}, Pace: {GetPace():F1} {paceUnit}";
    }

    // Method to get the unit of measurement for distance
    protected abstract string GetDistanceUnit();

    // Method to get the unit of measurement for speed
    protected abstract string GetSpeedUnit();

    // Method to get the unit of measurement for pace
    protected abstract string GetPaceUnit();
}
