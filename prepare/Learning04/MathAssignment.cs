using System;

class MathAssignment : Assignment
{
    // Additional attributes
    private string _section;
    private string _problems;

    // Constructor
    public MathAssignment(string studentName, string topic, string section, string problems)
        : base(studentName, topic)
    {
        _section = section;
        _problems = problems;
    }

    // Method to return the Math homework list
    public string GetHomeworkList()
    {
        return $"Section {_section} Problems {_problems}";
    }
}