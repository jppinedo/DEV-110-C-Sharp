# Week 3: Personal Profile Card - Study Notes

**Name:** Juan Pablo Pinedo

## Understanding Variables and Data Types

**What are the four main data types you used in this assignment?**
[List string, int, double, and bool - explain what each stores and give examples from your profile card]

Answer:
The four main data types I used were:
1. string - Stores text data. I used this for full name, hometown, etc, since these are all text information.
2. int - Stores whole numbers without decimals. I used this for age, graduation year, and favorite number since these don't need decimal precision.
3. double - Stores numbers with decimal points. I used this for GPA (like 3.85) and height in inches (like 68.5) because these values need precision.
4. bool - Stores true/false values. I used this for isFullTime (whether someone is a full-time student) and isHonorStudent (whether GPA >= 3.5).

**Why did you use `double` for GPA instead of `int`?**
[Explain the difference and why decimal precision matters for GPA]

Answer:
I used double for GPA because GPAs have decimal values like 3.5, 3.85, or 2.75. Using int would only allow whole numbers (0, 1, 2, 3, 4) and would lose all the decimal precision. This matters because there's a big difference between a 3.0 and 3.9 GPA - both would be stored as 3 if we used int, which would be inaccurate and unfair to the student.

**How did you convert the yes/no input into a boolean?**
[Explain the comparison operation you used]

Answer:
I used the comparison operation: `fullTimeAnswer.ToLower() == "yes"`. This converts the user's input to lowercase first (so "Yes", "YES", or "yes" all work), then compares it to "yes". If they match, the boolean becomes true; otherwise it's false. This is a simple way to convert text input into a true/false value.

## Data Modeling Decisions

**How did you organize the information into logical groups?**
[Explain why you grouped certain pieces of information together (personal, academic, etc.)]

Answer:
I organized the information into three main sections: Personal Information (name, hometown, favorite color, dream job, age), Academic Details (major, GPA, graduation year, full-time status), and Calculated Statistics (birth year, years to graduation, height, honor student, age in months, favorite number). This makes sense because personal info is who you are, academic info is about your education, and calculated stats are derived data. It makes the output easier to read and understand.

**Which pieces of information did you calculate rather than ask for?**
[List the derived data: birth year, years to graduation, height conversion, honor status, age in months]

Answer:
I calculated five pieces of information:
1. Birth year (2026 - age)
2. Years to graduation (graduation year - 2026)
3. Height conversion (converting inches to feet and inches)
4. Honor student status (checking if GPA >= 3.5)
5. Age in months (age * 12)

**Why is it better to calculate birth year from age rather than ask for both?**
[Explain data consistency and reducing redundant input]

Answer:
It's better to calculate birth year because asking for both age and birth year creates redundant data that could be inconsistent. If someone accidentally enters the wrong birth year but correct age (or vice versa), the data would conflict. By calculating one from the other, we ensure consistency and reduce user input errors. It also makes the program simpler for the user - fewer questions to answer.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Type conversion, calculations, formatting, choosing data types?]

Answer:
The biggest challenge was understanding the height conversion calculation, specifically using the modulus operator (%) to get the remaining inches after dividing by 12. I had to think through the math carefully to understand how 68 inches becomes 5 feet 8 inches.

**How you solved it:**
[Explain your approach to overcoming the challenge]

Answer:
I worked through a concrete example on paper: 68 inches divided by 12 equals 5 with remainder 8. The integer division (int)(68/12) gives 5 feet, and the modulus 68 % 12 gives 8 remaining inches. Once I saw it with real numbers, it made sense.

**Most confusing concept:**
[What was hardest to understand? Type casting, modulus for height, boolean logic, or formatting?]

Answer:
The most confusing concept was type casting with (int) for the height calculation. I didn't fully understand why I needed to cast the division result to int. I learned that without the cast, the division of doubles returns a double, but feet should be a whole number, so we need to explicitly convert it.

## Type Conversion and Calculations

**How do you convert string input to a number?**
[Explain Parse methods: int.Parse(), double.Parse()]

Answer:
Console.ReadLine() always returns a string, so to convert it to a number, I use Parse methods. For whole numbers, I use int.Parse(Console.ReadLine()), which converts the string "21" into the integer 21. For decimal numbers, I use double.Parse(Console.ReadLine()), which converts "3.85" into the double 3.85. The Parse methods read the string and convert it to the appropriate numeric type.

**What calculation did you use to convert height from inches to feet and inches?**
[Explain: feet = inches / 12, remaining = inches % 12]

Answer:
I used two operations: `int feet = (int)(heightInches / 12)` to get the whole feet, and `double inches = heightInches % 12` to get the remaining inches. For example, 68 inches: 68/12 = 5 feet (integer division), and 68%12 = 8 remaining inches. So 68 inches = 5 feet 8 inches.

**How did you determine if someone is an honor student?**
[Explain the boolean comparison: gpa >= 3.5]

Answer:
I used the boolean comparison `bool isHonorStudent = gpa >= 3.5`. This checks if the GPA is greater than or equal to 3.5. If true, the person is an honor student; if false, they're not. It's a simple threshold check that automatically evaluates to a true/false value.

## Output Formatting

**How did you format the GPA to show exactly 2 decimal places?**
[Explain the :F2 format specifier]

Answer:
I didn't use a special format specifier in my current implementation - I just displayed the GPA as is with `{gpa}`. However, if I wanted to show exactly 2 decimal places, I could use `{gpa:F2}`, where F2 means "fixed-point with 2 decimal places". This would show 3.5 as 3.50 and 3.123 as 3.12.

**How did you display different text based on whether someone is full-time or part-time?**
[Explain the conditional/ternary operator you used]

Answer:
I displayed the boolean value directly with `{isFullTime}`, which shows "True" or "False". If I wanted to show more user-friendly text like "Full-Time" or "Part-Time", I could use a ternary operator: `{(isFullTime ? "Full-Time" : "Part-Time")}`. This checks the condition and picks the appropriate text.

**What techniques did you use to make the output look organized?**
[Discuss alignment, spacing, section headers, borders]

Answer:
I used several techniques: decorative borders with box-drawing characters (╔═╗ ║ ╚═╝) for the header, section headers with clear labels (--- PERSONAL INFORMATION ---), blank lines (\n) to separate sections, and consistent left-alignment with labels followed by values. This creates a clean, readable layout that's easy to scan.

## Real-World Data Modeling

**What other calculated fields could you add to a profile?**
[Think of other derived data: BMI from height/weight, time to birthday, etc.]

Answer:
Some other calculated fields could include: BMI (from height and weight), days until birthday (from birth date), semesters remaining (from credits earned and needed), estimated graduation semester, age in days or weeks, percentage of degree completed, or even fun facts like "born on a [day of week]".

**Why is choosing the right data type important in real applications?**
[Explain memory, precision, and type safety]

Answer:
Choosing the right data type is important for several reasons: it ensures precision (using double for money prevents rounding errors), saves memory (int uses less space than double), prevents errors (you can't accidentally multiply a string by a number), and makes the code more maintainable (other programmers understand what kind of data to expect).

**How does this profile card relate to real-world applications?**
[Think about social media profiles, job applications, student records systems]

Answer:
This profile card is similar to many real-world systems: student information systems store academic data, social media profiles collect personal information, job applications calculate years of experience, and health apps calculate BMI and other metrics. The principles of collecting input, storing it in appropriate data types, and calculating derived values are fundamental to almost all applications.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned about variables and data modeling?]

1. Different data types serve different purposes - strings for text, int for whole numbers, double for decimals, bool for true/false.
2. All console input is a string and must be converted using Parse methods to work with numbers mathematically.
3. Calculating derived data is better than asking for redundant information - it prevents inconsistencies.
4. The modulus operator (%) is useful for finding remainders, like in height conversion.
5. Choosing appropriate data types makes programs more accurate, efficient, and easier to understand.

**Which data type was most challenging to work with and why?**
[Reflect on your experience with string, int, double, or bool]

Answer:
Double was the most challenging because I had to think about when to use it versus int, and understand type casting when converting double to int (like for the feet calculation). I also had to be careful with the modulus operator on doubles, which was different from using it with ints.

**How does understanding data types help you write better programs?**
[Explain the benefits of type safety and appropriate data representation]

Answer:
Understanding data types helps me write better programs because it prevents errors, makes code more efficient, helps with accurate calculations, and makes code clearer to read.

## Testing and Debugging

**What test cases did you use to verify your calculations?**
[List different inputs you tested - edge cases, typical values, etc.]

Answer:
I tested with typical values, edge cases, and various ages to verify birth year calculation. I also tested with decimal heights like 67.5 inches to ensure the modulus worked correctly with doubles.

**What bugs or errors did you encounter and fix?**
[Describe any type conversion errors, calculation mistakes, or formatting issues]

Answer:
Initially, I forgot to cast the height division to int, so feet was showing as a double with decimals. I also had to remember to use ToLower() for the yes/no comparison so that "Yes", "YES", and "yes" would all work. I also initially forgot to display the age in the output, which the tests caught.

**How did you validate that your data types were correct?**
[Explain how you checked that GPA, heights, ages worked correctly]

Answer:
I validated by running the program and checking that: GPAs showed decimal points (3.85 not 3), ages were whole numbers, calculations worked correctly (68 inches became 5 feet 8 inches), and the honor student check correctly identified GPAs >= 3.5. I also ran the automated tests to verify everything was working as expected.

## Time Spent

**Total time:** 3 hours

**Breakdown:**

-   Understanding data types and planning variables: 0.5 hours
-   Collecting user input with correct types: 0.5 hours
-   Implementing calculations: 0.75 hours
-   Formatting output: 0.5 hours
-   Testing and debugging: 0.25 hours
-   Writing documentation: 0.5 hours

**Most time-consuming part:** Implementing calculations took the longest because I had to figure out the height conversion logic and understand how the modulus operator works with doubles. I spent time testing different values to make sure the math was correct.

## Reflection

**What would you do differently if you started over?**
[Consider variable names, calculation order, organization, etc.]

Answer:
If I started over, I would plan out all the variable names first to keep them consistent, and maybe use more descriptive names like 'currentGPA' instead of just 'gpa'.

**How does proper data modeling make programs easier to maintain?**
[Think about readability, consistency, and reducing errors]

Answer:
Proper data modeling makes programs easier to maintain because using the right types prevents bugs, descriptive variable names make code self-documenting, calculated values stay consistent automatically, and other programmers can quickly understand what data the program works with. If I need to change something later, clear data types make it obvious what's safe to modify.

**What real-world system would you like to model next?**
[Shopping cart, game character, recipe calculator, etc.]

Answer:
I'd like to model a fitness tracker that calculates BMI, calories burned, target heart rate zones, and tracks workout progress. It would use similar concepts - collecting input (height, weight, age), calculating derived data (BMI, calorie needs), and displaying formatted results. It would be practical and help me understand more complex calculations.