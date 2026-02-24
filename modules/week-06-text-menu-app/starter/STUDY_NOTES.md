# Week 6: Text Menu App - Study Notes

**Name:** Juan Pablo Pinedo

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer:
A `do-while` loop always runs the code inside at least once, then checks the condition. A `while` loop checks the condition first, so it might not run at all. I use `do-while` when I need to ask the user for input at least once before checking if it's valid. A `while` loop is better when I want to check the condition first, like when I want the menu to keep showing until the user picks option 6.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe how you validated the menu choice and numeric inputs]

Answer:
I used `do-while` loops in my helper methods `ReadIntInRange` and `ReadDouble`. These methods need to ask the user for input at least once, then keep asking if the input is invalid. For example, in `ReadIntInRange`, I prompt the user, try to parse their input, and if it's not a valid number or not in the right range, I loop back and ask again. This way the user always gets at least one chance to enter something.

**Where did you use a `while` loop and why?**
[Describe the menu loop and why it repeats]

Answer:
I used a `while` loop for the main menu that keeps showing until the user chooses option 6 (Exit). The condition is `while (choice != 6)`, which means the loop continues as long as the user hasn't picked Exit. This makes sense because I want to check if they want to exit before showing the menu again. If they pick 6, the loop stops and the program ends.

**Where did you use a `for` loop and why?**
[If you didn't use a for loop, explain why it wasn't needed]

Answer:
I didn't use a `for` loop in this assignment. I didn't need to iterate through a specific number of items or a collection. The `while` loop worked better for the menu because I didn't know how many times the user would use it. And the `do-while` was perfect for input validation because I just needed to keep asking until I got valid input, not a specific number of times.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for multiple prompts]

Answer:
I created `ReadIntInRange` and `ReadDouble` helper methods because I needed to validate user input in multiple places - for the menu choice, quantity, price, and width. Instead of writing the same validation code (with `do-while` and `TryParse`) over and over, I wrote it once in a helper method and called it whenever I needed validated input. This is similar to creating a reusable function in JavaScript - it saves time and makes the code cleaner and easier to maintain.

**How did you validate the menu choice (1–6)?**
[Explain your range check logic and do-while loop]

Answer:
I used the `ReadIntInRange` method with a range of 1 to 6. Inside that method, I use a `do-while` loop that keeps asking until the input is valid. First, I use `int.TryParse` to check if the input is a number. If it is a number, I then check if it's between 1 and 6 using `number < min || number > max`. If either check fails, I set `isValid` to false and the loop continues, prompting the user again.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse and double.TryParse work]

Answer:
`int.TryParse` and `double.TryParse` are really useful methods. They try to convert a string to a number, but instead of throwing an error if it fails (like `Parse` would), they return `true` if successful and `false` if not. They also use an `out` parameter to give you the converted number if it worked. So I can check if the parse was successful, and if not, I just ask the user again. This is much better than crashing the program when someone types "abc" instead of a number!

## String Operations

**Which string methods did you use across the different menu options?**
[List key methods like Trim, ToUpper, ToLower, Replace, Split, Join, Contains, PadLeft, PadRight, and formatting techniques]

Answer:
I used a lot of string methods! In Option 1, I used `Trim()` to remove extra spaces, `ToUpper()` to make names uppercase, and `string.Format()` to format the greeting card. In Option 2, I used `Trim()`, concatenation with `+`, string indexing to get first letters, `ToUpper()` for initials, and `ToLower()` for lowercase names. In Option 3, I used `Trim()`, `Length`, `Contains()`, `Replace()` to change spaces to dashes, `Split()` to break into words, and `string.Join()` to make a comma-separated list. In Option 4, I used `string.Format()` with alignment and currency formatting (`:C2`). In Option 5, I used `new string()` constructor to make border lines, `PadLeft()` to center text, and `ToUpper()` for the title. In Option 6, I used `Equals()` with `StringComparison`, `Substring()`, `EndsWith()`, and `IndexOf()`.

**Which four string methods did you demonstrate in Option 6 (String Analysis)?**
[Explain Equals with StringComparison, Substring, EndsWith, and IndexOf]

Answer:
The four methods I used in Option 6 were:
1. `Equals()` with `StringComparison.OrdinalIgnoreCase` - This compares two strings but ignores whether letters are uppercase or lowercase. I used it to check if the closing word equals "goodbye" regardless of case.
2. `Substring(0, 3)` - This extracts the first 3 characters from a string. I had to check the length first to make sure the string was long enough, otherwise it would crash.
3. `EndsWith("!")` - This checks if a string ends with a specific character or substring. I used it to see if the closing word ended with an exclamation mark.
4. `IndexOf(' ')` - This finds the position of the first space character in a string. If there's no space, it returns -1. I used it to find where spaces are in the closing word.

**What's the difference between string concatenation and interpolation?**
[Explain when you used each approach and which you prefer]

Answer:
String concatenation uses the `+` operator to join strings together, like `"Hello, " + name + "!"`. String interpolation uses `$` before the string and `{}` to insert variables, like `$"Hello, {name}!"`. I used concatenation in several places, like building the full name in Option 2 and creating the output messages. I also used `string.Format()` which is similar to interpolation but uses placeholders like `{0}` and `{1}`. I think I prefer concatenation for simple cases because it's straightforward, but `string.Format()` is really useful when I need to align text or format numbers (like currency). In JavaScript, I'm used to template literals with backticks, which is similar to C# interpolation.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. I learned the difference between `while` and `do-while` loops and when to use each one. The `do-while` is perfect for input validation because you always need to ask at least once.

2. I got comfortable with `TryParse` methods for safe input validation. They're much better than `Parse` because they don't crash the program if the input is invalid.

3. I discovered how powerful C# string methods are - `Trim()`, `ToUpper()`, `Replace()`, `Split()`, `Join()`, and many others make it easy to manipulate text.

4. I learned about `string.Format()` and composite formatting with alignment specifiers and format specifiers like `:C2` for currency. This is really useful for creating nice-looking output.

5. I understood how to use a `switch` statement to handle multiple menu options cleanly, which is much better than a long chain of `if-else` statements.

**Which loop felt most natural to use and why?**

Answer:
The `while` loop felt most natural because it's similar to what I'm used to in JavaScript. The logic of "keep doing this while a condition is true" is straightforward. The `do-while` took a bit more thinking because I had to remember it always runs once first, but once I understood it was perfect for input validation, it made sense.

## Time Spent

**Total time:** 4 hours

**Breakdown:**

- Planning the loops: 0.5 hours
- Input validation: 1 hour
- String formatting: 1.5 hours
- Testing and debugging: 0.5 hours
- Writing documentation: 0.5 hours

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:
String formatting took the longest because there were so many different string methods to use and I had to figure out the right combination for each menu option. Option 5 (Menu Banner Builder) was especially tricky because I had to figure out how to center text using `PadLeft()` with the right calculation. Also, getting the formatting right for the receipt table in Option 4 took some trial and error to make the columns align properly.

## Reflection

**What would you do differently next time?**

Answer:
I think I would plan out the string formatting more carefully before coding. Some of the output formatting took multiple tries to get right, especially the alignment and padding. I also would test each menu option as I finished it instead of coding everything and then testing, because it was harder to debug when I had a lot of code written. Also, I should have looked up the exact syntax for `string.Format()` alignment specifiers earlier - I spent time guessing when I could have just checked the documentation.

**How did using three different loop types improve your understanding of repetition?**

Answer:
Using `while`, `do-while`, and understanding when `for` wasn't needed really helped me see that each loop type has its purpose. The `while` loop for the menu made sense because I wanted to check the condition first. The `do-while` for validation was perfect because I always needed to ask at least once. And not using `for` helped me realize that loops aren't just about counting - they're about repeating code until a condition is met, and the condition doesn't always have to be a counter. This is similar to JavaScript where I use `while` and `for` loops, but C# has this extra `do-while` option that's really useful for input validation.
