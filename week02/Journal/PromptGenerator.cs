public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "How did you feel loved by God today?",
        "How did you serve someone today?",
        "What made you better today than yesterday?",
        "What are you grateful for today?",
        "What happened today that you would relate or teach to your grandchilden?"
    };

    public Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];            
    }
}