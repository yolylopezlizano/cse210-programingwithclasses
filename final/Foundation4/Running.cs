using System;
using System.Collections.Generic;

// Derived Running class
public class Running : Activity
{
    // Default value for distance in miles
    private const double DefaultDistanceInMiles = 0;

    public double DistanceInMiles { get; set; }

    // Constructor with optional distance
    public Running(DateTime date, double durationInMinutes, double distanceInMiles = DefaultDistanceInMiles)
    {
        Date = date;
        DurationInMinutes = durationInMinutes;
        DistanceInMiles = distanceInMiles;
    }

    public override double GetDistance()
    {
        return DistanceInMiles;
    }

    public override double GetSpeed()
    {
        // If distance is zero or duration is zero, return zero speed
        if (DistanceInMiles == 0 || DurationInMinutes == 0)
        {
            return 0;
        }
        else
        {
            // Calculate speed only if distance and duration are non-zero
            return DistanceInMiles / (DurationInMinutes / 60);
        }
    }

    public override double GetPace()
    {
        // If distance is zero, return a default pace value of 20 (minutes per mile)
        if (DistanceInMiles == 0)
        {
            return 0;
        }
        else
        {
            // Calculate pace only if distance is non-zero
            return DurationInMinutes / DistanceInMiles;
        }
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