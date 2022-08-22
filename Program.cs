// The program should be updated to...

// Display the number of the user's current guess in the prompt. For example, if the user has already guessed one time, the prommpt should say something like Your guess (2)>.
// End the loop early if the user guesses the correct number.

using System;
namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the secret number!");

            int secretNumber = 42;

            MultipleChances(4, secretNumber);
        }
        static int GetUserGuess()
        {
            Console.Write("Enter a number: ");
            int userGuess = int.Parse(Console.ReadLine());
            return userGuess;
        }
        static void DisplayUserGuess(int userGuess)
        {
            Console.WriteLine($"You guessed {userGuess}");
        }

        static void MultipleChances(int numberOfChances, int secretNumber)
        {
            for (int i = 0; i < numberOfChances; i++)
            {
                int userGuess = GetUserGuess();
                isSecretNumber(userGuess, secretNumber);

                if (secretNumber == userGuess)
                {
                    break;
                }
            }
            Console.WriteLine("Sorry! You FAILED!");
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