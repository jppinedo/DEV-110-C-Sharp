# Week 9: Score Stats (Methods + LINQ) - Study Notes

**Name:** Juan Pablo Pinedo

## Methods and Decomposition

**Why is it helpful to break a program into small methods?**
[Think about readability, testing, and debugging]

Answer:
Breaking the program into small methods makes each piece easier to read and understand because a method only does one job. It also helps with testing and debugging, since I can focus on a single method like `PrintBasicStats` instead of digging through a huge `Main` method. If the output looks wrong, I know exactly which method to check and fix.

## LINQ (Stats + Method Chaining)

**Which LINQ methods did you use for basic statistics?**
[Examples: Min, Max, Average, Count with predicates]

Answer:
I used `Min`, `Max`, and `Average` on the `_scores` array inside `PrintBasicStats` to calculate the summary stats. I also used `Count` with predicates in `PrintPassingFailingCounts` to figure out how many scores were passing and how many were failing based on the threshold. Those LINQ methods gave me all the numbers I needed without writing manual loops.

**Which LINQ methods did you chain together for reports?**
[Examples: Where + OrderByDescending, OrderByDescending + Take]

Answer:
For the reports I chained several LINQ methods together. In `PrintScoresSorted` I used `OrderBy` and then `string.Join` to print the scores in ascending order. In `PrintTopScores` I chained `OrderByDescending` with `Take` to get the top N scores. For passing and failing lists I used `Where` followed by `OrderByDescending` so I first filtered by the threshold and then sorted from highest to lowest.

**Why is it helpful to put score logic in a class (ScoreReport) instead of keeping everything in Program?**
[Think about organization, reuse, and readability]

Answer:
Putting the score logic in the `ScoreReport` class keeps input/output flow in `Program` and all the analysis in one place. It makes the code more organized and easier to reuse because I could create another `ScoreReport` with different scores without changing `Program`. It also makes the file less overwhelming when I come back later to review the LINQ logic.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. First I learned how to chain LINQ methods like `Where`, `OrderByDescending`, and `Take` to build different reports from the same score list.
2. Second I got more practice splitting a console app into small helper methods instead of putting everything inside `Main`.
3. Third I learned how to format an average to one decimal place using `ToString("0.0", CultureInfo.InvariantCulture)` so the output matches exactly.
4. I saw how using a small class like `ScoreReport` can organize logic better than keeping all the code in one big file.
5. I was reminded to match labels and spacing exactly so automated tests pass without weird off‑by‑one string issues.

**Which concept felt easiest (methods or LINQ) and why?**

Answer:
Methods felt easier than LINQ because they are very similar to functions in JavaScript, which I already use all the time. LINQ was newer, and I had to think more about how each method like `Where` or `OrderBy` transforms the sequence. Once I saw the patterns, the chaining started to feel more natural.

## Time Spent

**Total time:** 2.5 hours

**Breakdown:**

- Understanding the starter code: 0.5 hours
- Implementing the print methods: 1 hours
- LINQ method chaining: 0.5 hours
- Testing and debugging: 0.25 hours
- Writing documentation: 0.25 hours

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:
The most time-consuming part was getting the LINQ expressions and output formatting exactly right so they matched the examples and tests. I had to double-check labels like `Passing (>=threshold)` and make sure sorting order and comma spacing were correct.

## Reflection

**What would you improve next time?**

Answer:
Next time I would sketch out the methods and expected outputs before writing code so I have a clearer plan. I would also run tests more frequently after finishing each method instead of waiting until the end.

**How did methods make this program easier to work on?**

Answer:
Methods made this program easier because each part of the report lived in a separate method with a descriptive name. `PrintReport` gave me a simple, high-level view of the whole workflow, and I could jump into `PrintPassingScores` or `PrintTopScores` without touching the rest of the logic.
