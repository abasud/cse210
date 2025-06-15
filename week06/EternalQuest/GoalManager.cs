using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        if (_score < 1000 && _score > 0)
        {
            Console.WriteLine("Your level is Laman.");
        }
        else if (_score >= 1000)
        {
            Console.WriteLine("Your level is Alma the younger.");
        }
        else if (_score >= 3000)
        {
            Console.WriteLine("Your level is King Benjamin.");
        }
        else if (_score >= 5000)
        {
            Console.WriteLine("Your level is Captain Moroni.");
        }
        else if (_score >= 7000)
        {
            Console.WriteLine("Your level is Mormon.");
        }
        else if (_score >= 10000)
        {
            Console.WriteLine("Your level is Nephi.");
        }
        else if (_score >= 15000)
        {
            Console.WriteLine("Your level is Moriancumer.");
        }
    }
    public void DisplayLevels()
    {
        Console.WriteLine("\nThe levels are:");
        Console.WriteLine("Laman: less than 1,000 points");
        Console.WriteLine("Alma the younger: 1,000 points");
        Console.WriteLine("King Benjamin: 3,000 points");
        Console.WriteLine("Captain Moroni: 5,000 points");
        Console.WriteLine("Mormon: 7,000 points");
        Console.WriteLine("Nephi: 10,000 points");
        Console.WriteLine("Moriancumer: 15,000 points");
    }
    public void ListGoalNames()
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetName()}");
            index++;
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of Goal would you like to create? ");
        string goalOption = Console.ReadLine();

        if (goalOption == "1")
        {
            Console.Write("What is your goal?: ");
            string name = Console.ReadLine();
            Console.Write("Make a short description of your goal: ");
            string description = Console.ReadLine();
            Console.Write("How many points does this goal have?: ");
            string points = Console.ReadLine();
            _goals.Add(new SimpleGoal(name, description, points, false));
        }
        else if (goalOption == "2")
        {
            Console.Write("What is your goal?: ");
            string name = Console.ReadLine();
            Console.Write("Make a short description of your goal: ");
            string description = Console.ReadLine();
            Console.Write("How many points does this goal have?: ");
            string points = Console.ReadLine();
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalOption == "3")
        {
            Console.Write("What is your goal?: ");
            string name = Console.ReadLine();
            Console.Write("Make a short description of your goal: ");
            string description = Console.ReadLine();
            Console.Write("How many points does this goal have?: ");
            string points = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus?: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing the total number of this goal?: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus, 0));
        }
        else
        {
            Console.WriteLine("The input is not correct.");
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("What goal did you accomplish? ");
        string goalAccomplished = Console.ReadLine();

        int goalIndex = int.Parse(goalAccomplished) - 1;
        Goal goalInList = _goals[goalIndex];

        if (goalInList is SimpleGoal simple)
        {
            goalInList.RecordEvent();
            _score += int.Parse(simple.GetPoints());
        }
        else if (goalInList is EternalGoal eternal)
        {
            goalInList.RecordEvent();
            _score += int.Parse(eternal.GetPoints());
        }
        else if (goalInList is ChecklistGoal checklist)
        {
            goalInList.RecordEvent();
            if (checklist.IsComplete() == true)
            {
                _score += int.Parse(checklist.GetPoints()) + checklist.GetBonus();
            }
            else
            {
                _score += int.Parse(checklist.GetPoints());
            }
        }
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string file = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                if (goal is SimpleGoal simple)
                {
                    outputFile.WriteLine(simple.GetStringRepresentation());
                }
                else if (goal is EternalGoal eternal)
                {
                    outputFile.WriteLine(eternal.GetStringRepresentation());
                }
                else if (goal is ChecklistGoal checklist)
                {
                    outputFile.WriteLine(checklist.GetStringRepresentation());
                }
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename? ");
        string file = Console.ReadLine();

        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);

            _score = int.Parse(lines[0]);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                string type = parts[0];

                switch (type)
                {
                    case "SimpleGoal":
                        _goals.Add(new SimpleGoal(parts[1], parts[2], parts[3], bool.Parse(parts[4])));
                        break;

                    case "EternalGoal":
                        _goals.Add(new EternalGoal(parts[1], parts[2], parts[3]));
                        break;

                    case "ChecklistGoal":
                        _goals.Add(new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                        break;
                }
            }

            Console.WriteLine("Goals loaded successfully!");
        }

        else
        {
            Console.WriteLine("File not found.");
        }
    }
}