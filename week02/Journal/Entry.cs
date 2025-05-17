public class Entry
{
    public string _date = DateTime.Now.ToShortDateString();
    public string _prompt;
    public string _entry = "";

    public Entry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        _prompt = promptGenerator.GetRandomPrompt();
    }

    public void Display()
    {
        Console.Write($"Date: {_date}");
        Console.Write($" - Prompt: {_prompt}");
        Console.WriteLine($"\nEntry: {_entry}");
        Console.WriteLine();
    }

}