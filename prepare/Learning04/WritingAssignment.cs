using System;

// Derived class for Writing assignments
class WritingAssignment : Assignment
{
    // Additional attributes
    private string _title;

    // Constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Method to return writing information
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}
