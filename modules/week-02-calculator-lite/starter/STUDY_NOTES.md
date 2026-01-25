# Week 2: Calculator Lite - Study Notes

**Name:** Juan Pablo Pinedo

## Understanding Data Types

**What are the four data types you used in this assignment?**
[List each data type (string, bool, int, double) and explain what kind of data each one stores]

Answer: I used string to store the user's name and their input choices. I used bool to store whether the user wants decimals or not, true for yes and false for no. I used double to store the numbers because it can hold decimal values. I also used int when parsing numbers without decimals before converting them to double.

**Why did we use `double` instead of `int` for the calculations?**
[Explain the difference between int and double, and why double is better for this calculator]

Answer: Double is better because it can store decimal numbers like 3.14, while int can only store whole numbers. Since the user can choose to use decimal precision, I needed double to store their numbers correctly. When they don't want decimals, I still use double because int automatically converts to double without losing the whole number.

**How do you convert a string to a boolean?**
[Explain how you converted the user's "yes/no" input into a true/false value]

Answer: I used the comparison operator == to check if the string equals "yes" or "y". If it does, the expression is true, otherwise it's false.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Understanding data types, getting user input, performing calculations, formatting output, or handling division by zero?]

Answer: Understanding when to use double versus int was confusing at first. I wasn't sure why we needed to convert strings to numbers and then possibly to different types based on the user's choice.

**How you solved it:**
[Explain what you did to overcome the challenge - reviewed documentation, asked for help, tested different approaches, etc.]

Answer: I tested the program multiple times with different inputs to see what happened. I also looked at the comments in the code that explained when to use double.Parse() versus int.Parse(). Eventually I realized that double can always work for both decimals and whole numbers, so I just use it for everything.

**Most confusing concept:**
[What was hardest to understand? Parsing input, modulus operator, percentage formula, conditional formatting, or something else?]

Answer: The part where I needed to do all the operations on the numbers I was confused on how to show some results and
test the second number for 0 in the middle of the caculations.

## Understanding Arithmetic Operations

**What is the difference between the modulus operator (%) and division (/)?**
[Explain what each operator does and give an example]

Answer: Division (/) gives you the result of dividing one number by another. For example, 10 / 3 equals 3.33. The modulus operator (%) gives you the remainder after division. So 10 % 3 equals 1 because 3 goes into 10 three times with 1 left over.

**How do you calculate the average of two numbers?**
[Write the formula in your own words]

Answer: You add the two numbers together and then divide by 2. So if you have 10 and 20, you add them to get 30, then divide by 2 to get 15.

**What is the formula for percentage difference?**
[Explain the formula you used: ((num1 - num2) / num1) * 100]

Answer: You subtract the second number from the first number, then divide by the first number, then multiply by 100. This shows how much different the second number is compared to the first number as a percentage.

## Input and Output

**How do you read user input in C#?**
[Explain what Console.ReadLine() does and what type of data it returns]

Answer: Console.ReadLine() pauses the program and waits for the user to type something and press Enter. It always returns the input as a string, even if the user types numbers.

**How do you convert string input to a number?**
[Explain the Parse methods you used, like double.Parse()]

Answer: I use double.Parse() or int.Parse() to convert a string into a number. Double.Parse() converts to a decimal number and int.Parse() converts to a whole number. You call it like `double.Parse(stringVariable)` and it returns the number.

**What is string interpolation and how did you use it?**
[Explain the $ symbol and curly braces {} in Console.WriteLine()]

Answer: String interpolation lets you put variables inside a string. You put a $ before the quote and then put variable names inside curly braces {}. For example, `Console.WriteLine($"Hello, {userName}!")` prints the user's name right in the message.

## Conditional Logic

**How do you format numbers with 2 decimal places vs whole numbers?**
[Explain the :F2 and :F0 format specifiers]

Answer: Inside the curly braces, you add a colon and then F2 or F0. The F2 shows 2 decimal places, so 5.1 becomes 5.10. The F0 shows no decimal places, so 5.7 becomes 6.

**Why is it important to check for division by zero?**
[Explain what happens if you try to divide by zero and how you handled it]

Answer: If you divide by zero, the program crashes with an error. So I used an if statement to check if the second number is zero before trying to divide or use modulus.

**How did you use the boolean variable to control formatting?**
[Explain how you used if/else to format output differently based on user preference]

Answer: I used the useDecimals boolean in if statements to decide which Parse method to use. If useDecimals is true, I call double.Parse() to keep the decimals. If it's false, I call int.Parse() to get whole numbers. This way the program uses the user's choice to format the input correctly.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned?]

1. Data types matter because they determine what kind of data you can store and how you can use them.
2. Always convert user input from strings to the type you need before doing math with it.
3. Check for zero before dividing to prevent crashes.
4. Boolean values let you make decisions in your code based on yes/no questions.
5. Having pseudo code as comments helps to easily structure the development and have a clear idea on what to do.

**Which data type concept was most useful?**
[Explain which data type (string, bool, int, or double) you found most interesting and why]

Answer: The most insteresting one for me is the `char` data type. I've never seen a data type that consist of only 1 character. It seems that C# goes very far to optimize the memory usage with all this data types.

**How does conditional formatting improve user experience?**
[Why is it helpful to let users choose decimal precision?]

Answer: In the case of this assignment I don't find the option to have decimal or not very useful. Having said that, having the ability to make decisions in the code makes programs more robuts and more usable.

## Testing and Debugging

**What test cases did you use to verify your program works?**
[List the different inputs you tested - positive numbers, negative numbers, decimals, zero, etc.]

Answer: I tested with positive numbers, negative numbers, decimal numbers, and zero to make sure division by zero showed an error. I also tested with both yes and no for decimal precision to make sure both paths worked.

**What bugs or errors did you encounter and fix?**
[Describe any errors you got and how you fixed them]

Answer: I initially forgot to check if the second number was zero before dividing, which would have crashed the program.

## Time Spent

**Total time:** 3.2 hours

**Breakdown:**

- Understanding data types: 0.5 hours
- Reading and parsing user input: 0.5 hours
- Implementing arithmetic operations: 0.1 hours
- Adding conditional formatting: 0.5 hours
- Handling division by zero: 0.3 hours
- Testing and debugging: 0.3 hours
- Writing documentation: 0.7 hours

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Understanding data types took the most time because I had to think about when to use double versus int and how they affect the calculations.

## Reflection

**What would you do differently next time?**
[What would you change in your approach or code?]

Answer: Initially I didn't follow exactly the comments and led to the program to have issues. Then, instead to work through the issues I decided to follow the comments and it went better. Next time I won't code this assignemnts as if I was writing javascript.

**How does this assignment prepare you for more complex programs?**
[Why are these skills important for future programming tasks?]

Answer: This assignment teaches me how to handle user input and use propper data types. Understanding data types, conversion, and error handling will help me write more reliable code and have a good foundation for making more complex programs.
