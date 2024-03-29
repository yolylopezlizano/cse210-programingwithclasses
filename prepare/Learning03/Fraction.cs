using System;
public class Fraction
{
    // Private attributes for numerator and denominator
    private int numerator;
    private int denominator;

    // Constructors
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    public Fraction(int top)
    {
        numerator = top;
        denominator = 1;
    }

    public Fraction(int top, int bottom)
    {
        numerator = top;
        denominator = bottom;
    }

    // Getters and setters
    public int GetNumerator()
    {
        return numerator;
    }

    public void SetNumerator(int top)
    {
        numerator = top;
    }

    public int GetDenominator()
    {
        return denominator;
    }

    public void SetDenominator(int bottom)
    {
        // Avoid division by zero
        if (bottom != 0)
            denominator = bottom;
        else
            Console.WriteLine("Denominator cannot be zero.");
    }

    // Method to return fraction string representation
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    // Method to return decimal value of the fraction
    public double GetDecimalValue()
    {
        // Avoid division by zero
        if (denominator != 0)
            return (double)numerator / denominator;
        else
        {
            Console.WriteLine("Cannot divide by zero.");
            return double.NaN;
        }
    }
}
