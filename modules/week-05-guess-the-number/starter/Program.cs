namespace GuessTheNumber;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Guess the Number: Loop Trio ===\n");

        // TODO 1: Complete the helper method named ReadIntInRange
        // Why: It avoids repeating the same input-validation code for max value and rounds.

        // TODO 2: Get a valid max value (10-100) using ReadIntInRange
        // Prompt: "Enter a max value (10-100): "
        // Hint: int.TryParse() and range check (value >= 10 && value <= 100)
        // Store result in an int named maxValue
        int maxValue = ReadIntInRange("Enter a max value (10-100): ", 10, 100);

        // TODO 3: Get a valid number of rounds (1-3) using ReadIntInRange
        // Prompt: "How many rounds? (1-3): "
        // Hint: int.TryParse() and range check (value >= 1 && value <= 3)
        // Store result in an int named rounds
        int rounds = ReadIntInRange("How many rounds? (1-3): ", 1, 3);

        // TODO 4: Use a for loop to repeat the game for each round
        // Example: for (int round = 1; round <= rounds; round++)
        // NOTE: The round header, secret number, and guessing loop are inside this for loop.
        for (int round = 1; round <= rounds; round++)
        {
            // TODO 5: Display the round header (inside the for loop)
            // Example: Console.WriteLine($"\nRound {round} of {rounds}");
            Console.WriteLine($"\nRound {round} of {rounds}");

            // TODO 6: Generate a secret number in the range 1..max (inclusive)
            // Hint: Random random = new Random(maxValue + round);
            // Hint: int secret = random.Next(1, maxValue + 1);
            // NOTE: This should be inside the for loop so each round has a new secret.
            Random random = new Random(maxValue + round);
            int secret = random.Next(1, maxValue + 1);

            // TODO 7: Initialize guess tracking variables (inside the for loop)
            // Hint: int guess = 0; int guessCount = 0;
            int guess = 0;
            int guessCount = 0;

            // TODO 8: Use a while loop to keep asking until the guess is correct
            // Hint: while (guess != secret) { ... }
            // NOTE: Everything related to a single guess goes inside this while loop.
            while (guess != secret)
            {
                // TODO 9: Read a guess and validate that it is a number (inside the while loop)
                // Prompt: $"Guess a number (1-{maxValue}): "
                // Hint: int.TryParse() and continue the loop if invalid
                // Hint: if parsing fails, skip feedback and ask again
                Console.Write($"Guess a number (1-{maxValue}): ");
                string input = Console.ReadLine();
                bool isValid = int.TryParse(input, out guess);

                if (!isValid)
                {
                    continue;
                }

                // TODO 10: Update guessCount and provide feedback (inside the while loop)
                // Track guessCount and print: "Too low.", "Too high.", or
                // "Correct! You got it in X guesses."
                guessCount++;

                if (guess < secret)
                {
                    Console.WriteLine("Too low.");
                }
                else if (guess > secret)
                {
                    Console.WriteLine("Too high.");
                }
                else
                {
                    Console.WriteLine($"Correct! You got it in {guessCount} guesses.");
                }
            }
        }

        // TODO 11: Print a closing message after all rounds finish
        // Example: "Thanks for playing!"
        Console.WriteLine("\nThanks for playing!");
    }

    // private static int ReadIntInRange(string prompt, int min, int max)
    // {
    // Requirements:
    // - Use a do-while loop
    // - Use int.TryParse() for input
    // - Repeat until the value is in range
    // -- Hint: !isValid || value < min || value > max
    // }
    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid;

        do
        {
            Console.Write(prompt);
            isValid = int.TryParse(Console.ReadLine(), out value);
        } while (!isValid || value < min || value > max);

        return value;
    }
}
