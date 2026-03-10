# Week 8: Mad Libs (Structure + Debugging) - Study Notes

**Name:** Juan Pablo Pinedo

## Program Structure

**What helper methods did you create (and what does each one do)?**
[List your methods and briefly describe each]

Answer:
I created `ChooseTemplate` to show the two options and return the right `StoryTemplate`. `CollectWords` loops through each prompt and fills the `words` array. `ReadYesNo` validates y/n answers, `ReadIntInRange` validates the 1–2 template choice, and `ReadNonEmptyString` keeps asking until the user types a non-empty word.

**Why is it helpful to move code out of `Main` and into helper methods?**
[Explain how this improves readability and reduces bugs]

Answer:
Moving logic out of `Main` into helpers makes each piece of the program easier to understand and test. It reduces bugs because I can focus on one small method at a time instead of digging through a long `Main` method.

## Data Modeling

**What is the purpose of the `StoryTemplate` class in this assignment?**
[Explain what data it stores and why]

Answer:
The `StoryTemplate` class holds the story title, the list of prompts, and the template text with `{0}`, `{1}`, etc. placeholders. It gives a simple model for a story so the rest of the program can just call `GenerateStory` without worrying about how the text is stored.

**How did using a template make it easier to support two different stories?**
[Explain how the same logic can work with different prompts/text]

Answer:
Using a template meant I could reuse the same input and output logic for both stories. I just returned a different `StoryTemplate` with different prompts and template text, and the rest of the code still worked the same way.

## Testing and Debugging

**Where did you set a breakpoint while debugging this program (what line or method)?**
[Be specific - example: inside GenerateStory, at the beginning of CollectWords, etc.]

Answer:
I set breakpoints at the start of `CollectWords` and inside `StoryTemplate.GenerateStory`. That let me watch each prompt, see how the `words` array was filled, and confirm which values were being passed into `string.Format`.

**What did you learn from stepping through your code line by line?**
[Describe how watching execution helped you understand flow or find bugs]

Answer:
Stepping through line by line helped me see the exact order that methods were called from `Main` down into the helpers. Watching variables like `choice`, `words[i]`, and `template.Title` change made it easier to confirm that the loops and validation logic were working correctly.

**What bug or logic mistake did you encounter (and how did you fix it)?**
[Describe a real issue you ran into and how breakpoints/stepping helped]

Answer:
At first I forgot to trim the input in `ReadNonEmptyString`, so a user could just type spaces and it counted as valid. When I stepped through with a breakpoint, I saw the raw value was just whitespace, so I fixed it by calling `Trim()` and only accepting the string when the trimmed value was not empty.

## What I Learned

**Key takeaways from this week:**
[3 main things you learned]

1. Breaking `Main` into small helper methods for input and template selection.
2. Using the `StoryTemplate` class to reuse the same logic for different stories.
3. Practicing debugging with breakpoints and stepping through loops and conditionals.

**What part of this assignment helped you understand program structure the most?**
[Breaking into methods, using public/private methods, separating concerns, etc.]

Answer:
The part that helped the most was writing and using the helper methods like `ChooseTemplate`, `CollectWords`, and `ReadYesNo`. Seeing how `GenerateStory` called a private `FormatStory` method made public vs private methods and separation of concerns feel more real.

## Time Spent

**Total time:** 3 hours

**Breakdown:**

- Planning structure (methods/classes): 0.5 hours
- Input validation: 0.5 hours
- Story templates + formatting: 1 hour
- Testing and debugging: 0.5 hours
- Writing documentation: 0.5 hours

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:
The story templates and formatting took the longest because I had to match each prompt with the correct `{0}`, `{1}`, etc. placeholder. I also spent extra time tweaking the sentences so the final stories read naturally with whatever words the user entered.

## Reflection

**What would you improve if you had more time?**
[Ideas: more templates, better formatting, more validation, etc.]

Answer:
If I had more time, I would add more templates with different themes and improve the formatting of the output. I would also add clearer error messages when the user types invalid input so they know what went wrong.

**How did breaking your program into smaller parts help you debug?**
[Explain the connection between structure and debugging]

Answer:
Breaking the program into smaller methods made it much easier to debug because I could focus on one function at a time. When something looked off, I set a breakpoint in that specific helper and stepped through it, instead of scrolling through one big `Main` method.
