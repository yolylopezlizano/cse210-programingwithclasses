using System;

// Derived Reception class
public class Reception : Event
{
    public string RSVPemail { get; set; }

    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        RSVPemail = rsvpEmail;
    }

    public override string GenerateFullMessage()
    {
        return base.GenerateStandardMessage() + $"\nType: Reception\nRSVP Email: {RSVPemail}";
    }
}