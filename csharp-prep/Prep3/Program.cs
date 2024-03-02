using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome Guess My Number game!");

        Random random = new Random();
            bool playAgain = true;

            while (playAgain)
            {
                int magicNumber = random.Next(1, 101); 
                int guessCount = 0;

                while (true)
                {
                    Console.WriteLine("What is your guess?");
                    int guess = int.Parse(Console.ReadLine());
                    guessCount++;

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

                Console.WriteLine("Do you want to play again? (yes/no)");
                string response = Console.ReadLine();

                if (response.ToLower() != "yes")
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing Guess My Number!");
        }
    }
