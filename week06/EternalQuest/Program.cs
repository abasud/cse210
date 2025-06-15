// I added leveling up to the gamification, acording to some characters of The Book of Mormon.
// The current level of the user is displayed in the player info.
// Every level is defined by certain amount of points, and the difficulty increases.
// I added another option to the initial menu to display the levels, for the user take them into account.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        Console.WriteLine("\nWelcome to the Eternal Quest program!");

        string select = "";

        do
        {
            Console.WriteLine();
            goalManager.DisplayPlayerInfo();
            Console.WriteLine("\nPlease, select one of the following options:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Display levels");
            Console.WriteLine("7. Quit");

            Console.Write("What would you like to do? ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                goalManager.CreateGoal();
            }

            else if (option == "2")
            {
                goalManager.ListGoalDetails();
            }

            else if (option == "3")
            {
                goalManager.SaveGoals();
            }

            else if (option == "4")
            {
                goalManager.LoadGoals();
            }

            else if (option == "5")
            {
                goalManager.RecordEvent();
            }
             else if (option == "6")
            {
                goalManager.DisplayLevels();
            }

            else
            {
                Console.WriteLine("See you soon!");
            }

            select = option;

        } while (select != "7");
    }    
}