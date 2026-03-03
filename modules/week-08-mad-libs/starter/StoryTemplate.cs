/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?:
- Represents a Mad Libs story template with prompts and story text.
- */

namespace MadLibs;

public class StoryTemplate
{
    public StoryTemplate(string title, string[] prompts, string templateText)
    {
        Title = title;
        Prompts = prompts;
        TemplateText = templateText;
    }

    public string Title { get; }

    public string[] Prompts { get; }

    public string TemplateText { get; }

    // TODO 1: Implement GenerateStory method
    // This method should:
    // - Validate that words.Length equals Prompts.Length
    // - Call FormatStory to build the final story string
    // - Return the formatted story
    public string GenerateStory(string[] words)
    {
        if (words == null)
        {
            throw new ArgumentNullException(nameof(words));
        }

        if (words.Length != Prompts.Length)
        {
            throw new ArgumentException("Number of words must match the number of prompts.");
        }

        string story = FormatStory(words);
        return story;
    }

    // TODO 2: Implement FormatStory method (private helper)
    // This method should:
    // - Convert string[] words to object[] (required for string.Format)
    // - Call string.Format with TemplateText and the object array
    // - Return the formatted story
    private string FormatStory(string[] words)
    {
        object[] wordObjects = new object[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            wordObjects[i] = words[i];
        }

        string story = string.Format(TemplateText, wordObjects);
        return story;
    }
}
