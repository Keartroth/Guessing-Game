using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomInteger = new Random();

            int secretNumber = randomInteger.Next(1, 101);
            int usersGuesses = 0;
            int totalGuesses = 0;
            bool cheater = false;

            Console.WriteLine("Please choose difficulty level: 'Easy', 'Medium', 'Hard', or 'Cheater'.");
            string difficultyLevel = Console.ReadLine();

            if (difficultyLevel == "Easy")
            {
                totalGuesses = 8;
            }
            if (difficultyLevel == "Medium")
            {
                totalGuesses = 6;

            }
            if (difficultyLevel == "Hard")
            {
                totalGuesses = 4;
            }
            if (difficultyLevel == "Cheater")
            {
                cheater = true;
            }

            if (cheater)
            {
                while (cheater)
                {
                    Console.WriteLine($"Guess the secret number. This is guess number {usersGuesses + 1}. You have no guess limit.");

                    string userGuess = Console.ReadLine();
                    int parsedGuess = Int32.Parse(userGuess);

                    if (parsedGuess == secretNumber)
                    {
                        Console.WriteLine("Yup! You guessed it!");
                        break;
                    }
                    else
                    {
                        if (parsedGuess < secretNumber)
                        {
                            Console.WriteLine("Nope, that wasn't it. You guessed too low.");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Nope, that wasn't it. You guessed too high.");
                            Console.WriteLine();
                        }
                    }

                    usersGuesses++;
                }
            }
            else
            {
                while (usersGuesses < totalGuesses)
                {
                    Console.WriteLine($"Guess the secret number. This is guess number {usersGuesses + 1}. You have {totalGuesses - usersGuesses} guess left.");

                    string userGuess = Console.ReadLine();
                    int parsedGuess = Int32.Parse(userGuess);

                    if (parsedGuess == secretNumber)
                    {
                        Console.WriteLine("Yup! You guessed it!");
                        break;
                    }
                    else
                    {
                        if (parsedGuess < secretNumber)
                        {
                            Console.WriteLine("Nope, that wasn't it. You guessed too low.");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Nope, that wasn't it. You guessed too high.");
                            Console.WriteLine();
                        }
                    }

                    usersGuesses++;
                }
            }
        }
    }
}