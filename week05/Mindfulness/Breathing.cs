public class Breathing : Activity

{
    public Breathing(string activityName, string startingMessage, string endingMessage) : base(activityName, startingMessage, endingMessage)
    {

    }

    public void Run()
    {
        Console.WriteLine($"\nWelcome to the {_activityName}");
        Console.WriteLine();
        Console.WriteLine(DisplayStartingMessage());
        Console.WriteLine();
        Console.Write("How many breathing cycles would you like for this activity?: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGet ready...");
        ShowSpinner(5);
        for (int i = 0; i < _duration; i++)
        {
            Console.WriteLine("\nBreath in...");
            ShowCountDown(4, 1000);
            Console.WriteLine("Hold...");
            ShowCountDown(7, 1000);
            Console.WriteLine("Breath out...");
            ShowCountDown(8, 1000);
        }
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine(DisplayEndingMessage());
        ShowSpinner(5);
    }
}