// Prompt the user for a difficulty level before they are prompted to guess the number.
// The difficulty level should determine how many guesses the user gets. The difficulty levels should be:
// Easy - this gives the user eight guesses.
// Medium - this gives the user six guesses.
// Hard - this gives the user four guesses.

using System;
namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfChances = GetNumberOfChances();
            Console.WriteLine("Guess the secret number!");

            Random num = new Random();
            int secretNumber = num.Next(100);
            MultipleChances(numberOfChances, secretNumber);
        }
        static int GetUserGuess()
        {
            Console.Write("Enter a number (1-100): ");
            int userGuess = int.Parse(Console.ReadLine());
            return userGuess;
        }
        static void DisplayUserGuess(int userGuess)
        {
            Console.WriteLine($"You guessed {userGuess}");
        }

        static void MultipleChances(int numberOfChances, int SecretNumber)
        {
            for (int i = 0; i < numberOfChances; i++)
            {
                Console.WriteLine($"Guesses remaining: {numberOfChances - i}");

                int userGuess = GetUserGuess();
                isSecretNumber(userGuess, SecretNumber);

                if (SecretNumber < userGuess)
                {
                    Console.WriteLine("You're a little high there bud.");
                    Console.WriteLine($"{SecretNumber}");
                }
                else if (SecretNumber > userGuess)
                {
                    Console.WriteLine("You're a little low there bud.");
                    Console.WriteLine($"{SecretNumber}");
                }

                if (SecretNumber == userGuess)
                {
                    break;
                }
                if (i == numberOfChances - 1)
                {
                    Console.WriteLine($"Sorry! You FAILED! The correct answer was {SecretNumber}");
                }
            }
        }

        static int GetNumberOfChances()
        {
            Console.WriteLine("Choose your difficulty level(Easy-1, Medium-2, Hard-3): ");
            int difficulty = int.Parse(Console.ReadLine());

            if (difficulty == 1)
            {
                return 8;
            }
            else if (difficulty == 2)
            {
                return 6;
            }
            else if (difficulty == 3)
            {
                return 4;
            }
            else
            {
                Console.WriteLine("Not a valid input you fool!");
                return 0;
            }
        }


        static void isSecretNumber(int userGuess, int secretNumber)
        {
            if (userGuess == secretNumber)
            {
                Console.WriteLine("You guessed the secret number!");
            }
            else
            {
                Console.WriteLine("You guessed incorrectly");
            }
        }


    }
}