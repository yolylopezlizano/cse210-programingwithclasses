using System;

// Derived OutdoorGathering class
public class OutdoorGathering : Event
{
    public string WeatherForecast { get; set; }

    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        WeatherForecast = weatherForecast;
    }

    public override string GenerateFullMessage()
    {
        return base.GenerateStandardMessage() + $"\nType: Outdoor Gathering\nWeather Forecast: {WeatherForecast}";
    }
}