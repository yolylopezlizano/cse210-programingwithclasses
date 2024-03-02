using System;

class Program
{
    static void Main(string[] args)
    {
            // Ask the user for the grade porcentage
            Console.WriteLine("Enter your grade percentage: ");
            int gradePercentage = int.Parse(Console.ReadLine());

            // Determine the letter grade
            string letter = ""; 

            if (gradePercentage >= 90)
            {
                letter = "A";
            }
            else if (gradePercentage >= 80)
            {
                letter = "B";
            }
            else if (gradePercentage >= 70)
            {
                letter = "C";
            }
            else if (gradePercentage >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            Console.WriteLine($"Your grade is: {letter}");

            // Check if the student passed and display a message
            if (gradePercentage >= 70)
            {
                Console.WriteLine($"Congratulations! You passed!.");
            }
            else
            {
                Console.WriteLine($"Encouragement: You did not pass, but keep working hard for next time!");
            }
        }
    }
