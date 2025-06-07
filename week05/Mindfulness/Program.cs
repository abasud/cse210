using System;

class Program
{
    static void Main(string[] args)
    {
        Breathing breathing = new Breathing("Breathing Activity", "This program guides you through the 4-7-8 breathing technique — inhale for 4 seconds, hold your breath for 7 seconds, and exhale for 8 seconds. Take a moment to relax. Clear your mind, let go of distractions, and focus fully on your breath.", "You've completed the breathing exercise. Now, take a moment to notice how you feel — more relaxed, centered, and calm. Carry this sense of peace with you as you return to your dayly activities.");

        Reflecting reflecting = new Reflecting("Reflecting Activity", "This activity guides you to reflect on meaningful moments when you showed strength and resilience, helping you recognize your inner power and how it can guide your future actions.", "You've taken time to reflect and grow. Carry the strength you've recognized into everything you do next.");

        Listing listing = new Listing("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "You've taken time to reflect on what truly matters. Keep those thoughts with you throughout your day.");

        Console.WriteLine("\nWelcome to the Mindfulness Program!");

        string select = "";

        do
        {
            Console.WriteLine("\nPlease, select one of the following activities:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflecting");
            Console.WriteLine("3. Listing");
            Console.WriteLine("5. Quit");

            Console.Write("\nWhat would you like to do? ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                breathing.Run();;
            }

            else if (option == "2")
            {
                reflecting.Run();
            }

            else if (option == "3")
            {
                listing.Run();
            }

            else
            {
                Console.WriteLine("\nSee you later!");
            }

            select = option;

        } while (select != "4");
    }
}
