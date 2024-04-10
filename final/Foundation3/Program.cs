using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Cityville", "State", "USA");
        Address address2 = new Address("456 Elm St", "Townsville", "State", "USA");
        Address address3 = new Address("789 Oak St", "Villageville", "State", "USA");

        Lecture lecture = new Lecture("Intro to Programming", "Learn the basics of programming", DateTime.Now, "10:00 AM", address1, "John Doe", 50);
        Reception reception = new Reception("Company Anniversary Party", "Celebrate our 10th anniversary", DateTime.Now, "7:00 PM", address2, "rsvp@example.com");
        OutdoorGathering gathering = new OutdoorGathering("Summer Picnic", "Enjoy a day outdoors", DateTime.Now, "12:00 PM", address3, "Sunny with a chance of rain");

        Console.WriteLine(lecture.GenerateFullMessage());
        Console.WriteLine();
        Console.WriteLine(reception.GenerateFullMessage());
        Console.WriteLine();
        Console.WriteLine(gathering.GenerateFullMessage());
    }
}
