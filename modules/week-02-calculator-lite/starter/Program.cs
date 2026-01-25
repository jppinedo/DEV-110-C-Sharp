namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");

        // TODO: Declare variables for storing user input (use descriptive names)
        // Hint: You'll need variables for two numbers, user name, and calculation choice
        string userName;

        // TODO: Ask for user's name (string) and greet them
        // Example: "Enter your name: " then "Hello, [name]!"
        Console.WriteLine("Enter your name: ");
        userName = Console.ReadLine();
        Console.WriteLine($"Hello, {userName}!\nWelcome to Calculator Lite.\n");

        // TODO: Ask if they want to use decimals (bool)
        // Example: "Use decimal precision? (yes/no): "
        // Store as boolean (true for yes, false for no)
        Console.WriteLine("Use decimal precision? (yes/no): ");
        string decimalChoice = Console.ReadLine().ToLower();
        bool useDecimals = decimalChoice == "yes" || decimalChoice == "y";

        // TODO: Prompt user for first number (double or int based on choice)
        // If decimals: use double.Parse()
        // If no decimals: use int.Parse() then cast to double
        Console.WriteLine("Enter the first number: ");
        string firstNumberRaw = Console.ReadLine();
        double firstNumber;
        if (useDecimals)
        {
            firstNumber = double.Parse(firstNumberRaw);
        }
        else
        {
            firstNumber = int.Parse(firstNumberRaw);
        }

        // TODO: Prompt user for second number (same type as first)
        Console.WriteLine("Enter the second number: ");
        string secondNumberRaw = Console.ReadLine();
        double secondNumber;
        if (useDecimals)
        {
            secondNumber = double.Parse(secondNumberRaw);
        }
        else
        {
            secondNumber = int.Parse(secondNumberRaw);
        }

        // TODO: Calculate ALL arithmetic operations:
        // - sum (addition: +)
        // - difference (subtraction: -)
        // - product (multiplication: *)
        // - quotient (division: /)
        // - remainder (modulus: %)
        // - average ((num1 + num2) / 2)
        double sum = firstNumber + secondNumber;
        double difference = firstNumber - secondNumber;
        double product = firstNumber * secondNumber;
        double average = (firstNumber + secondNumber) / 2;

        // TODO: Display results with proper formatting
        // Show 2 decimal places: {value:F2}
        // Include descriptive labels for each operation

        if (useDecimals)
        {
            Console.WriteLine($"\nResults for {userName}:");
            Console.WriteLine($"Sum: {sum:F2}");
            Console.WriteLine($"Difference: {difference:F2}");
            Console.WriteLine($"Product: {product:F2}");
            Console.WriteLine($"Average: {average:F2}");
        }
        else
        {
            Console.WriteLine($"\nResults for {userName}:");
            Console.WriteLine($"Sum: {sum:F0}");
            Console.WriteLine($"Difference: {difference:F0}");
            Console.WriteLine($"Product: {product:F0}");
            Console.WriteLine($"Average: {average:F0}");
        }


        // TODO: Check if second number is zero BEFORE dividing
        // Use if statement: if (num2 == 0) { show error } else { calculate }
        if (secondNumber == 0)
        {
            Console.WriteLine("Cannot perform division or modulus by zero.");
        }
        else
        {
            double quotient = firstNumber / secondNumber;
            double remainder = firstNumber % secondNumber;
            if (useDecimals)
            {
                Console.WriteLine($"Quotient: {quotient:F2}");
                Console.WriteLine($"Remainder: {remainder:F2}");
            }
            else
            {
                Console.WriteLine($"Quotient: {quotient:F0}");
                Console.WriteLine($"Remainder: {remainder:F0}");
            }
        }
        // TODO: Count total calculations performed (int)
        // Display: "Performed [count] calculations for [name]!"
        int calculationCount = 5;
        if (secondNumber != 0)
        {
            calculationCount = 7;
        }
        Console.WriteLine($"\nPerformed {calculationCount} calculations for {userName}!");
        // TODO: Calculate percentage difference
        // Formula: ((num1 - num2) / num1) * 100
        // Display with % symbol
        if (firstNumber != 0)
        {
            double percentageDifference = ((firstNumber - secondNumber) / firstNumber) * 100;
            if (useDecimals)
            {
                Console.WriteLine($"Percentage Difference: {percentageDifference:F2}%");
            }
            else
            {
                Console.WriteLine($"Percentage Difference: {percentageDifference:F0}%");
            }
        }
        else
        {
            Console.WriteLine("Percentage Difference: Undefined (first number is zero).");
        }
        Console.WriteLine("\nThank you for using Calculator Lite!");
    }
}
