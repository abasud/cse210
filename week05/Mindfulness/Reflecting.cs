using System.Net;

public class Reflecting : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        // "Think of a time when you helped someone in need.",
        // "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private List<string> _usedPrompts = new List<string>();

    public Reflecting(string activityName, string startingMessage, string endingMessage) : base(activityName, startingMessage, endingMessage)
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
                Console.WriteLine("\nConsider the following prompt:");
                Console.WriteLine();

                _usedPrompts.Add(randomPrompt);
                Console.WriteLine(randomPrompt);
                Console.WriteLine();
                Console.WriteLine("When you have something in mind, press enter to continue.");
                Console.ReadLine();
                Console.WriteLine("Now, ponder on each of the following questions as they related to this experience:");
                Console.Write("\nYou may begin in: ");
                ShowCountDown(5, 1000);
                Console.WriteLine();

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(_duration);

                while (DateTime.Now < endTime)
                {
                    GetRandomQuestion();
                    ShowSpinner(10);
                }
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

    public void GetRandomQuestion()
    {
        Random randomQuestion = new Random();
        int index = randomQuestion.Next(_questions.Count);
        Console.WriteLine(_questions[index]);
    }
}