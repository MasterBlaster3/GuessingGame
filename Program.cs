// The program should be updated to...

// Use a random number to set the secret number between 1 and 100 instead of a hard-coded number.
// The prompt should display the number of guesses the user has left.


using System;
namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the secret number!");

            Random num = new Random();
            int secretNumber = num.Next(100);
            MultipleChances(4, secretNumber);
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