using System;

// Base Event class
public class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public string Time { get; set; }
    public Address Address { get; set; }

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public virtual string GenerateStandardMessage()
    {
        return $"Event: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {Address}";
    }

    public virtual string GenerateFullMessage()
    {
        return GenerateStandardMessage();
    }

    public virtual string GenerateShortDescription()
    {
        return $"Event Type: {GetType().Name}\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
    }
}