public class Listing : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        // "Who are people that you have helped this week?",
        // "When have you felt the Holy Ghost this month?",
        // "Who are some of your personal heroes?"
    };

    private List<string> _usedPrompts = new List<string>();

    public Listing(string activityName, string startingMessage, string endingMessage) : base(activityName, startingMessage, endingMessage)
    {

    }

    public void Run()
    {
        string randomPrompt;

        while (true)
        {
            randomPrompt = GetRandomPrompt();

            if (!_usedPrompts.Contains(randomPrompt))
            {
                Console.WriteLine($"\nWelcome to the {_activityName}");
                Console.WriteLine();
                Console.WriteLine(DisplayStartingMessage());
                Console.WriteLine();
                Console.Write("How many seconds would you like for this activity?: ");
                _duration = int.Parse(Console.ReadLine());
                Console.WriteLine("\nGet ready...");
                ShowSpinner(5);
                Console.WriteLine("\nList as many responses as you can to the following prompt:");

                _usedPrompts.Add(randomPrompt);
                Console.WriteLine(randomPrompt);

                Console.Write("\nYou may begin in: ");
                ShowCountDown(5, 1000);
                Console.WriteLine();

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(_duration);

                while (DateTime.Now < endTime)
                {
                    GetListFromUser();
                }
                Console.WriteLine($"\nYou listed {_count} items!");
                Console.WriteLine();
                Console.WriteLine("Well done!");
                ShowSpinner(5);
                Console.WriteLine();
                Console.WriteLine(DisplayEndingMessage());
                ShowSpinner(5);
                break;
            }
            else
            {
                if (_usedPrompts.Count < _prompts.Count)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("\nYou have completed all the prompts for this activity in this session.");
                    break;
                }
            }
        }
    }

    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        return _prompts[index];
    }

    public void GetListFromUser()
    {
        List<string> listFromUser = new List<string>();

        Console.Write("> ");
        string userInput = Console.ReadLine();
        listFromUser.Add(userInput);
        _count += 1;
        
    }
}