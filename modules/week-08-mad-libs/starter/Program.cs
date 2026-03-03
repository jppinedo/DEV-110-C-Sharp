/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?:
- Runs a two-template Mad Libs app that practices structure and debugging.
- */

namespace MadLibs;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Mad Libs: Structure + Debugging ===");
        Console.WriteLine();

        // TODO 1: Implement the main game loop
        // The loop should:
        // - Let player choose a template
        // - Collect words for the template
        // - Generate and display the story using template.GenerateStory()
        // - Ask if the player wants to play again
        // - Repeat if they answer 'y'
        bool playAgain;
        do
        {
            StoryTemplate template = ChooseTemplate();
            Console.WriteLine();

            string[] words = CollectWords(template);

            string story = template.GenerateStory(words);
            Console.WriteLine(story);
            Console.WriteLine();

            playAgain = ReadYesNo("Play again? (y/n): ");
            Console.WriteLine();
        }
        while (playAgain);
    }

    // TODO 2: Implement ChooseTemplate
    // This method should:
    // - Print the two template options:
    //   1) Debugging at the Zoo
    //   2) The Standup Meeting
    // - Use ReadIntInRange to get user's choice (1-2)
    // - Return the appropriate StoryTemplate (see template details in README)
    private static StoryTemplate ChooseTemplate()
    {
        Console.WriteLine("1) Debugging at the Zoo");
        Console.WriteLine("2) The Standup Meeting");

        int choice = ReadIntInRange("Choose a template (1-2): ", 1, 2);

        if (choice == 1)
        {
            string title = "Debugging at the Zoo";

            string[] prompts = new string[]
            {
                "Enter an adjective: ",
                "Enter an animal (plural): ",
                "Enter a verb ending in -ing: ",
                "Enter a programming language: ",
                "Enter a debugging tool (example: breakpoint): ",
                "Enter a number: ",
                "Enter an emotion: ",
                "Enter an exclamation: "
            };

            string templateText =
                "Today I visited the {0} zoo. I saw {1} {2} while writing {3}. " +
                "I used a {4} {5} times until the bug disappeared. " +
                "I felt {6} and yelled, \"{7}!\"";

            StoryTemplate template = new StoryTemplate(title, prompts, templateText);
            return template;
        }
        else
        {
            string title = "The Standup Meeting";

            string[] prompts = new string[]
            {
                "Enter a name: ",
                "Enter an adjective: ",
                "Enter a noun: ",
                "Enter a verb (past tense): ",
                "Enter a number: ",
                "Enter a plural noun: ",
                "Enter a type of bug (example: null reference): ",
                "Enter a snack: "
            };

            string templateText =
                "{0} walked into the {1} standup with a {2}. " +
                "They {3} through {4} {5} while fixing a {6}. " +
                "Everyone celebrated with {7}.";

            StoryTemplate template = new StoryTemplate(title, prompts, templateText);
            return template;
        }
    }

    // TODO 3: Implement CollectWords
    // This method should:
    // - Use Logger.Info to log that word collection is starting
    // - Create a string array the same length as template.Prompts
    // - Loop through each prompt and use ReadNonEmptyString
    // - Print a blank line after collection
    // - Return the array of collected words
    private static string[] CollectWords(StoryTemplate template)
    {
        Logger.Info($"Collecting {template.Prompts.Length} words for: {template.Title}");

        string[] words = new string[template.Prompts.Length];

        for (int i = 0; i < template.Prompts.Length; i++)
        {
            string prompt = template.Prompts[i];
            string word = ReadNonEmptyString(prompt);
            words[i] = word;
        }

        Console.WriteLine();

        return words;
    }

    // TODO 4: Implement ReadYesNo
    // This method should:
    // - Show the prompt
    // - Read input (handle null with ?? string.Empty)
    // - Trim the input
    // - Accept "y" or "n" (case-insensitive)
    // - Keep asking until valid input is provided
    // - Return true for "y", false for "n"
    private static bool ReadYesNo(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);

            string input = Console.ReadLine() ?? string.Empty;
            string trimmed = input.Trim().ToLower();

            if (trimmed == "y")
            {
                return true;
            }

            if (trimmed == "n")
            {
                return false;
            }
        }
    }

    // TODO 5: Implement ReadIntInRange
    // This method should:
    // - Use a do-while loop
    // - Show the prompt
    // - Read input and use int.TryParse
    // - Validate the number is between min and max (inclusive)
    // - Keep asking until valid
    // - Return the valid integer
    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool valid;

        do
        {
            Console.Write(prompt);

            string input = Console.ReadLine() ?? string.Empty;
            string trimmed = input.Trim();

            bool parsed = int.TryParse(trimmed, out value);

            if (parsed && value >= min && value <= max)
            {
                valid = true;
            }
            else
            {
                valid = false;
            }
        }
        while (!valid);

        return value;
    }

    // TODO 6: Implement ReadNonEmptyString
    // This method should:
    // - Show the prompt
    // - Read input (handle null with ?? string.Empty)
    // - Trim the input
    // - Keep asking if input is empty or whitespace
    // - Return the valid non-empty string
    private static string ReadNonEmptyString(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);

            string input = Console.ReadLine() ?? string.Empty;
            string trimmed = input.Trim();

            if (!string.IsNullOrWhiteSpace(trimmed))
            {
                return trimmed;
            }
        }
    }
}
