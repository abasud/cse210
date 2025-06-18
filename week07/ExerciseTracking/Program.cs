using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("16 Jun 2025", 93, 5.8f);
        activities.Add(running);

        Cycling cycling = new Cycling("17 Jun 2025", 68, 8.2f);
        activities.Add(cycling);

        Swimming swimming = new Swimming("18 Jun 2025", 47, 25);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}