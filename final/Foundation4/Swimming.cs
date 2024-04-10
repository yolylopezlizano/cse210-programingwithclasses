using System;
using System.Collections.Generic;

// Derived Swimming class
public class Swimming : Activity
{
    public int Laps { get; set; }

    public Swimming(DateTime date, double durationInMinutes, int laps)
    {
        Date = date;
        DurationInMinutes = durationInMinutes;
        Laps = laps;
    }

    public override double GetDistance()
    {
        // Convert laps to miles
        return Laps * 50 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        // Speed = Distance / Time
        return (Laps * 50 / 1000.0 * 0.62) / (DurationInMinutes / 60);
    }

    public override double GetPace()
    {
        // Pace = Time / Distance
        return DurationInMinutes / (Laps * 50 / 1000.0 * 0.62);
    }

    protected override string GetDistanceUnit()
    {
        return "miles";
    }

    protected override string GetSpeedUnit()
    {
        return "miles per hour";
    }

    protected override string GetPaceUnit()
    {
        return "minutes per mile";
    }
}
