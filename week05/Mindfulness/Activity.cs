public class Activity
{
    protected string _activityName;
    protected string _startingMessage;
    protected int _duration;
    private string _endingMessage;

    public Activity(string activityName, string startingMessage, string endingMessage)
    {
        _activityName = activityName;
        _startingMessage = startingMessage;
        _endingMessage = endingMessage;
    }

    public string DisplayStartingMessage()
    {
        return _startingMessage;
    }

    public void ShowSpinner(int timeExtension)
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timeExtension);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string character = animationString[i];
            Console.Write(character);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int timeExtension, int timeStep)
    {
        for (int i = timeExtension; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(timeStep);
            Console.Write("\b \b");
        }
    }

    public string DisplayEndingMessage()
    {
        return _endingMessage;
    }
}