using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            while (true)
            {
                Console.Write("Enter number: ");
                int number = int.Parse(Console.ReadLine());

                if (number == 0)
                    break;

                numbers.Add(number);
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("No numbers entered.");
                return;
            }

            //Compute the sum of the numbers
            int sum = numbers.Sum();

            // Compute the average of the numbers
            double average = numbers.Average();

            //Find the maximum number
            int maxNumber = numbers.Max();

            //Display requirements
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {maxNumber}");
            
            }
        }