using System;

static void Main()
{
    bool playAgain;
    do
    {
        playAgain = false;
        int lowerBound = 1, upperBound = 100, maxAttempts = 10;
        Random random = new Random();
        int numberToGuess = random.Next(lowerBound, upperBound + 1); // Generate a random number within the specified range
        int userInput = 0;
        int attemptCounter = 0;

        Console.Clear();
        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("Instructions:");
        Console.WriteLine("1. Guess the number between 1 and 100.");
        Console.WriteLine("2. You will receive feedback if your guess is too high or too low.");
        Console.WriteLine("3. You have a limited number of attempts to guess the correct number.");
        Console.WriteLine("4. You can exit the game at any time by entering a non-numeric value.");
        Console.WriteLine();

        while (userInput != numberToGuess && attemptCounter < maxAttempts)
        {
            Console.Write($"Enter your guess (Attempt {attemptCounter + 1}/{maxAttempts}): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out userInput) || userInput < lowerBound || userInput > upperBound)
            {
                Console.WriteLine($"Invalid input. Please enter a number between {lowerBound} and {upperBound}.");
                continue;
            }

            attemptCounter++;

            if (userInput < numberToGuess)
            {
                Console.WriteLine("Your number is too low.");
            }
            else if (userInput > numberToGuess)
            {
                Console.WriteLine("Your number is too high.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You guessed the correct number in {attemptCounter} attempts.");
                break;
            }

            if (attemptCounter >= maxAttempts)
            {
                Console.WriteLine($"Sorry, you've used all your attempts. The correct number was {numberToGuess}.");
            }
        }

        Console.WriteLine();
        Console.Write("Would you like to play again? (y/n): ");
        string response = Console.ReadLine().ToLower();
        if (response == "y")
        {
            playAgain = true;
        }
        else if (response == "n")
        {
            Console.WriteLine("Thank you for playing!");
        }
        else
        {
            Console.WriteLine("Invalid response. Exiting the game.");
        }

    } while (playAgain);
}
