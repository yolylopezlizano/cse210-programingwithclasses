using System;

// Derived Lecture class
public class Lecture : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GenerateFullMessage()
    {
        return base.GenerateStandardMessage() + $"\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}