# Week 7: Class Roster Builder (Arrays) - Study Notes

**Name:** Juan Pablo Pinedo

## Arrays and `count`

**What are “parallel arrays” and how did you use them in this assignment?**
[Explain how rosterNames and rosterCredits stay lined up by index]

Answer:
Parallel arrays are two arrays that match by index. I used `rosterNames[i]` with `rosterCredits[i]` so the name and credits stay together.

**What is the purpose of the `count` variable?**
[Explain how it tracks how many roster slots are “in use”]

Answer:
`count` tracks how many students are actually in the roster. It starts at 0 and goes up when I add students, so I don’t treat empty slots like real data.

**Where did you use `count` in loops and why?**
[Explain why you loop 0..count-1 instead of using the full array length]

Answer:
I looped from `0` to `count - 1` so I only print/sort the students that were added. Using the full array length would include empty spots.

## Printing and Sorting

**How did you print the class roster using a `foreach` loop?**
[Describe building an array of roster lines and then printing each line]

Answer:
I built a `string[]` of lines with `BuildRosterLines(...)`, then used `foreach` to print each line.

**How did you sort the roster while keeping names and credits aligned?**
[Describe copying the used roster into new arrays and using Array.Sort on parallel arrays]

Answer:
I copied the used roster into new arrays, then used `Array.Sort` on parallel arrays so the other array stays aligned. Name sort uses `Array.Sort(names, credits, ...)` and credit sort uses `Array.Sort(credits, names)`.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. Count is super important with fixed-size arrays so you know how many elements are “real”.
2. Parallel arrays work if you keep the same index for related info.
3. For loops are good when you need indexes.
4. Foreach is easy for printing.
5. Array.Sort can sort two arrays together.

**Which loop felt most natural to use and why?**

Answer:
`for` felt most natural because I needed indexes to add/copy data. `foreach` was best for printing.

## Time Spent

**Total time:** 3 hours

**Breakdown:**

- Planning the arrays/menu: 0.5 hours
- Input validation: 0.25 hours
- Add + print roster features: 1 hours
- Sorting feature: 0.75 hours
- Testing and debugging: 0.25 hours
- Writing documentation: 0.25 hours

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:
Adding students took the longest because I had to keep the arrays aligned and update `count` correctly.

## Reflection

**What would you do differently next time?**

Answer:
Next time I’ll plan the arrays and `count` first and run the tests earlier.

**How did using `for` and `foreach` improve your understanding of arrays?**

Answer:
It helped me understand when I need indexes (`for`) vs when I just want to print items (`foreach`).
