# Week 5: Guess the Number - Study Notes

**Name:** Juan Pablo Pinedo

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer:
A `do-while` loop always runs at least once before checking the condition, while a `while` loop checks the condition first. The `do-while` is perfect for situations where you need to ask the user for input at least once, like prompting for a number. The `while` loop is better when you might not need to run the code at all if the condition is already false.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe the input validation use]

Answer:
I used a `do-while` loop in the `ReadIntInRange` helper method to validate user input. This was perfect because I need to ask the user for input at least once, then keep asking until they provide a valid number within the specified range. The loop continues while the input is invalid or out of range.

**Where did you use a `while` loop and why?**
[Describe the guessing loop]

Answer:
I used a `while` loop for the guessing game logic. The loop runs while the user's guess doesn't match the secret number. This makes sense because I don't know how many guesses it will take, and I want to keep looping until they get it right.

**Where did you use a `for` loop and why?**
[Describe the rounds loop]

Answer:
I used a `for` loop to repeat the game for multiple rounds. Since I know exactly how many rounds the user wants to play (they chose between 1-3), a `for` loop is the best choice. It automatically counts from 1 to the number of rounds, making it easy to track which round we're on.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for max value and rounds]

Answer:
I needed to validate two different inputs (the max value and the number of rounds), and both required the same logic: prompt the user, check if it's a valid number, and check if it's in range. Instead of writing the same validation code twice, I created a reusable method that accepts the prompt and range as parameters.

**How did you make sure the max value was between 10 and 100?**
[Explain your range check logic]

Answer:
I called `ReadIntInRange` with a minimum of 10 and a maximum of 100. Inside that method, the `do-while` loop continues if the value is less than 10 or greater than 100, forcing the user to re-enter until they provide a valid number.

**How did you make sure the number of rounds was between 1 and 3?**
[Explain your range check logic]

Answer:
I used the same `ReadIntInRange` method but passed 1 as the minimum and 3 as the maximum. The method handles all the validation automatically, checking that the input is a valid number and within the 1-3 range.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse works]

Answer:
I used `int.TryParse()` which tries to convert the user's input string to an integer. It returns `true` if successful and stores the number in the `out` parameter, or returns `false` if the input isn't a valid number. The `do-while` loop continues if `TryParse` returns false, asking the user to try again.

## Guessing Logic

**How did you compare the guess to the secret number?**
[Explain the if/else logic for too low, too high, and correct]

Answer:
I used an if-else chain to compare the guess to the secret number. If the guess is less than the secret, I print "Too low." If the guess is greater than the secret, I print "Too high." Otherwise (when they're equal), I print the success message with the guess count.

**How did you count the number of guesses?**
[Explain where you incremented the counter]

Answer:
I initialized `guessCount` to 0 at the start of each round, then incremented it by 1 (`guessCount++`) inside the while loop after the user enters a valid guess. This way, every valid guess increases the counter, and I can display the total at the end.

## Random Numbers

**How did you generate the secret number?**
[Explain Random and Next(min, max)]

Answer:
I created a `Random` object and used its `Next()` method with two parameters: the minimum value (1) and the maximum value plus 1 (`maxValue + 1`). This generates a random integer in the specified range.

**Why does `Random.Next(1, max + 1)` include the max value?**
[Explain why +1 is needed]

Answer:
The `Next()` method's upper bound is exclusive, meaning it won't include that number. So if I want the secret to possibly be equal to `maxValue`, I need to pass `maxValue + 1`. For example, `Next(1, 26)` generates numbers from 1 to 25, not 1 to 26.

## Testing and Debugging

**What inputs did you test to confirm your loops worked correctly?**
[List several test cases]

Answer:
- Invalid max values: 5, 150, "abc" (to test validation)
- Valid max value: 25
- Invalid rounds: 0, 5, "test" (to test validation)
- Valid rounds: 2
- Different guesses to test "Too low", "Too high", and correct feedback
- Edge cases like guessing the number on the first try

**What bugs or errors did you encounter and fix?**
[Describe any logic or loop errors]

Answer:
I initially forgot that `Random.Next()` needs the upper bound to be exclusive, so I had to add +1 to include the max value. I also had to make sure to increment the guess count only after validating the input was a number, not before.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. Each loop type has a specific purpose: `do-while` for at-least-once scenarios, `while` for unknown iterations, and `for` for known iterations.
2. Helper methods reduce code duplication and make the program easier to maintain.
3. `int.TryParse()` is safer than `int.Parse()` because it handles invalid input gracefully without crashing.
4. The `Random.Next()` upper bound is exclusive, so I need to add 1 to include the maximum value.
5. Breaking down a complex problem into smaller pieces (validation, game rounds, guessing loop) makes it much easier to solve.

**Which loop felt most natural to use and why?**

Answer:
The `for` loop felt most natural because it's similar to how I'd iterate in JavaScript. The `do-while` was a bit unusual at first since I don't use it much in JavaScript, but it makes perfect sense for input validation where you need to ask at least once.

## Time Spent

**Total time:** 3 hours

**Breakdown:**

- Planning the loops: 1 hours
- Input validation: 0.5 hours
- Guessing logic: 0.5 hours
- Testing and debugging: 0.5 hours
- Writing documentation: 0.5 hours

**Most time-consuming part:** Understanding when to use each loop type and making sure the validation logic worked correctly.

Answer:
The input validation took the most time because I needed to understand how `int.TryParse()` works and how to structure the condition in the `do-while` loop properly.

## Reflection

**What would you do differently next time?**

Answer:
I would sketch out the loop structure before coding to visualize which loop goes inside which. This would help me plan better and avoid confusion about variable scope and initialization.

**How did using three different loop types improve your understanding of repetition?**

Answer:
Using all three types in one program helped me see their strengths and differences clearly. Before this, I mostly just used `for` loops for everything. Now I understand that choosing the right loop makes the code more readable and shows the intent more clearly.
