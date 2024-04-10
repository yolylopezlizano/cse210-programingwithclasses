using System;
using System.Collections.Generic;

// Derived Cycling class
public class Cycling : Activity
{
    public double SpeedInMph { get; set; }

    public Cycling(DateTime date, double durationInMinutes, double speedInMph)
    {
        Date = date;
        DurationInMinutes = durationInMinutes;
        SpeedInMph = speedInMph;
    }

    public override double GetDistance()
    {
        // Speed * Time = Distance
        return (SpeedInMph * DurationInMinutes) / 60;
    }

    public override double GetSpeed()
    {
        return SpeedInMph;
    }

    public override double GetPace()
    {
        // 60 / Speed = Pace
        return 60 / SpeedInMph;
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