using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome Guess My Number game!");

        Random random = new Random(); // Random generator
        bool playAgain = true;  // Variable if the user wants to play again or no

        while (playAgain)
            {
                int magicNumber = random.Next(1, 101); // Generate a random number

                while (true)
                {
                    Console.WriteLine("What is your guess?");
                    int guess = int.Parse(Console.ReadLine());

                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                        break; 
                    }
                }

                // Ask to the user if want to play again or not
                Console.WriteLine("Do you want to play again? (yes/no)"); 
                string response = Console.ReadLine();

                // Check the answer to play again or exit the loop
                if (response.ToLower() != "yes") 
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing Guess My Number!");
        }
    }
   