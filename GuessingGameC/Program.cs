Random random = new Random();
int numberToGuess = random.Next(1, 101); // Generate a random number between 1 and 100
int UserInput = 0;
int attemptCounter = 0;

Console.WriteLine("Guess my number between 1 and 100");

while (UserInput != numberToGuess)
{
    UserInput = Convert.ToInt32(Console.ReadLine()); // Read user input inside the loop
    attemptCounter++;

    if (UserInput < numberToGuess)
    {
        Console.WriteLine($"Your number is too low attempt:{attemptCounter}");
    }
    else if (UserInput > numberToGuess)
    {
        Console.WriteLine($"Your number is too high attempt:{attemptCounter}");
    }
    else
    {
        Console.WriteLine($"Congratulations! You guessed the correct number in {attemptCounter} attempts.");
    }
}

