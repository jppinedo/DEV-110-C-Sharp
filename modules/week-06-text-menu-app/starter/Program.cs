/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
- Assignment: Week 6: Text Menu App
-
- What does this program do?:
- Runs a text-heavy menu app that demonstrates string formatting and output patterns.
- */

namespace TextMenuApp;

public class Program
{
    public static void Main(string[] args)
    {
        // TODO 1: Build a title banner using strings
        // Create variables for:
        // - title: "Text Menu Studio"
        // - subtitle: "Strings + Console Output Patterns"
        // - divider: 48 equals signs (hint: use new string() constructor)
        // Display: divider, title in uppercase, subtitle, divider
        string title = "Text Menu Studio";
        string subtitle = "Strings + Console Output Patterns";
        string divider = new string('=', 48);

        Console.WriteLine(divider);
        Console.WriteLine(title.ToUpper());
        Console.WriteLine(subtitle);
        Console.WriteLine(divider);
        Console.WriteLine();

        int choice = 0;

        // TODO 2: Create a menu loop that repeats until user chooses 6 (Exit)
        // Hint: Use a while loop
        while (choice != 6)
        {
            // TODO 3: Print the menu box
            // Required menu option texts (tests check for these):
            // - 1) Greeting Card
            // - 2) Name Tag Formatter
            // - 3) Phrase Analyzer
            // - 4) Fancy Receipt Line
            // - 5) Menu Banner Builder
            // - 6) Exit
            Console.WriteLine("+------------------------------------------------+");
            Console.WriteLine("| 1) Greeting Card                               |");
            Console.WriteLine("| 2) Name Tag Formatter                          |");
            Console.WriteLine("| 3) Phrase Analyzer                             |");
            Console.WriteLine("| 4) Fancy Receipt Line                          |");
            Console.WriteLine("| 5) Menu Banner Builder                         |");
            Console.WriteLine("| 6) Exit                                        |");
            Console.WriteLine("+------------------------------------------------+");

            // TODO 4: Get menu choice from user
            // Use ReadIntInRange helper with prompt: "Choose an option (1-6): "
            // Range: 1 to 6
            choice = ReadIntInRange("Choose an option (1-6): ", 1, 6);

            // TODO 5: Use a switch statement to handle each menu option
            switch (choice)
            {

            // ===== OPTION 1: Greeting Card =====
            // Prompts: "Enter your name: " and "Enter a short message: "
            // Required string operations:
            // - Use Trim() to clean up the name
            // - Use ToUpper() for an uppercase version
            // - Use concatenation OR interpolation for greeting text
            // - Use string.Format() for at least one output line
            // - Display a boxed card with the name, uppercase name, and message
            // Include the word "Message:" in your output
            case 1:
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.Write("Enter a short message: ");
                string message = Console.ReadLine();

                string trimmedName = name.Trim();
                string upperName = trimmedName.ToUpper();

                string dividerLine = new string('-', 48);
                Console.WriteLine(dividerLine);
                Console.WriteLine("| Hello, " + trimmedName + "!                                   |");
                Console.WriteLine(string.Format("| Nice to meet you, {0}.                        |", upperName));
                Console.WriteLine(string.Format("| Message: {0}                             |", message));
                Console.WriteLine(dividerLine);
                break;

            // ===== OPTION 2: Name Tag Formatter =====
            // Prompts: "Enter first name: " and "Enter last name: "
            // Required string operations:
            // - Use Trim() on both inputs
            // - Use concatenation to build full name
            // - Use string indexing to get first characters for initials
            // - Use ToUpper() for initials
            // - Use ToLower() for lowercase version
            // Display three things:
            // - Name tag with the full name (include a bracket [)
            // - Initials (use word "Initials:" in label)
            // - Lowercase version (use word "Lowercase:" in label)
            case 2:
                Console.Write("Enter first name: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine();

                string trimmedFirst = firstName.Trim();
                string trimmedLast = lastName.Trim();
                string fullName = trimmedFirst + " " + trimmedLast;
                string firstInitial = trimmedFirst[0].ToString().ToUpper();
                string lastInitial = trimmedLast[0].ToString().ToUpper();
                string initials = firstInitial + lastInitial;
                string lowerName = fullName.ToLower();

                Console.WriteLine("[Name Tag: " + fullName + "]");
                Console.WriteLine("Initials: " + initials);
                Console.WriteLine("Lowercase: " + lowerName);
                break;

            // ===== OPTION 3: Phrase Analyzer =====
            // Prompt: "Enter a phrase: "
            // Required string operations:
            // - Use Trim() on input
            // - Use Length property
            // - Use Contains() to check for letter 'a' (convert to lowercase first)
            // - Use Replace() to change spaces to dashes
            // - Use Split() to break into words
            // - Use string.Join() to create comma-separated list
            // Display: length, contains check, dashed version, and words list
            case 3:
                Console.Write("Enter a phrase: ");
                string phrase = Console.ReadLine();

                string trimmedPhrase = phrase.Trim();
                int phraseLength = trimmedPhrase.Length;
                bool containsA = trimmedPhrase.ToLower().Contains("a");
                string dashedPhrase = trimmedPhrase.Replace(" ", "-");
                string[] words = trimmedPhrase.Split(' ');
                string wordsList = string.Join(", ", words);

                Console.WriteLine("Length: " + phraseLength);
                Console.WriteLine("Contains 'a': " + containsA);
                Console.WriteLine("Dashed version: " + dashedPhrase);
                Console.WriteLine("Words: " + wordsList);
                break;

            // ===== OPTION 4: Fancy Receipt Line =====
            // Prompts: "Enter item name: ", "Enter price: ", "Enter quantity (1-9): "
            // Use ReadDouble for price and ReadIntInRange for quantity
            // Required:
            // - Calculate total (price * quantity)
            // - Create a receipt table with header row (ITEM, QTY, TOTAL)
            // - Use string.Format() with composite formatting for the data row
            // - Use alignment specifiers (left/right alignment)
            // - Use currency format specifier (:C2) for the total
            case 4:
                Console.Write("Enter item name: ");
                string itemName = Console.ReadLine();
                double price = ReadDouble("Enter price: ");
                int quantity = ReadIntInRange("Enter quantity (1-9): ", 1, 9);

                double total = price * quantity;

                Console.WriteLine(string.Format("{0,-12} {1,3} {2,10}", "ITEM", "QTY", "TOTAL"));
                Console.WriteLine(string.Format("{0,-12} {1,3} {2,10:C2}", itemName, quantity, total));
                break;

            // ===== OPTION 5: Menu Banner Builder =====
            // Prompts: "Enter a title: ", "Enter a subtitle: ", "Enter width (30-60): "
            // Use ReadIntInRange for width (min=30, max=60)
            // Required string operations:
            // - Create border line with equals signs (use new string constructor)
            // - Use PadLeft() to center text (formula: (width + text.Length) / 2)
            // - Use ToUpper() on title
            // - Display banner with borders and centered text
            // - Show three alignment examples (centered, left, right)
            case 5:
                Console.Write("Enter a title: ");
                string bannerTitle = Console.ReadLine();
                Console.Write("Enter a subtitle: ");
                string bannerSubtitle = Console.ReadLine();
                int width = ReadIntInRange("Enter width (30-60): ", 30, 60);

                string bannerBorder = new string('=', width);
                string upperTitle = bannerTitle.ToUpper();

                int titlePadding = (width + upperTitle.Length) / 2;
                int subtitlePadding = (width + bannerSubtitle.Length) / 2;

                Console.WriteLine(bannerBorder);
                Console.WriteLine(upperTitle.PadLeft(titlePadding));
                Console.WriteLine(bannerSubtitle.PadLeft(subtitlePadding));
                Console.WriteLine(bannerBorder);

                string exampleText = "Example";
                int centeredPadding = (width + exampleText.Length) / 2;
                Console.WriteLine("Centered: " + exampleText.PadLeft(centeredPadding));
                Console.WriteLine("Left: " + exampleText.PadRight(width - 6));
                Console.WriteLine("Right: " + exampleText.PadLeft(width - 7));
                break;

            // ===== OPTION 6: Exit with String Analysis =====
            // Prompt: "Enter a closing word: "
            // Required string operations (demonstrate these 4 methods):
            // - Use Equals() with StringComparison.OrdinalIgnoreCase to compare with "goodbye"
            // - Use Substring() to extract first 3 characters (check length first!)
            // - Use EndsWith() to check if ends with "!"
            // - Use IndexOf() to find position of space character
            // Display the results of all four operations
            // Then print: "Goodbye!"
            case 6:
                Console.Write("Enter a closing word: ");
                string closingWord = Console.ReadLine();

                if (closingWord == null)
                {
                    closingWord = string.Empty;
                }

                bool isGoodbye = closingWord.Equals("goodbye", StringComparison.OrdinalIgnoreCase);
                string firstThree = string.Empty;
                if (closingWord.Length >= 3)
                {
                    firstThree = closingWord.Substring(0, 3);
                }
                bool endsWithExclamation = closingWord.EndsWith("!");
                int spaceIndex = closingWord.IndexOf(' ');

                Console.WriteLine("Is 'goodbye': " + isGoodbye + " | First 3: '" + firstThree + "' | Has !: " + endsWithExclamation + " | Space at: " + spaceIndex);
                Console.WriteLine("Goodbye!");
                break;
            }

            // TODO 6: Add a blank line between menu actions (but not after Exit)
            if (choice != 6)
            {
                Console.WriteLine();
            }
        }
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        // TODO 7: Implement input validation
        // Use a do-while loop with int.TryParse()
        // Keep prompting until input is valid AND within range
        // Return the valid number
        int number;
        bool isValid;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            isValid = int.TryParse(input, out number);

            if (!isValid || number < min || number > max)
            {
                isValid = false;
            }
        } while (!isValid);

        return number;
    }

    private static double ReadDouble(string prompt)
    {
        // TODO 8: Implement input validation
        // Use a do-while loop with double.TryParse()
        // Keep prompting until input is a valid number
        // Return the valid number
        double number;
        bool isValid;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            isValid = double.TryParse(input, out number);
        } while (!isValid);

        return number;
    }
}
