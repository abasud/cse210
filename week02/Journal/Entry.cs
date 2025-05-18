public class Entry
{
    public string _date = DateTime.Now.ToShortDateString();
    public string _prompt;
    public string _entry = "";
    public string _imagePath = "";

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
        if (!string.IsNullOrEmpty(_imagePath))
        {
            Console.WriteLine($"Image: {_imagePath}");
        }
        Console.WriteLine();
    }

}