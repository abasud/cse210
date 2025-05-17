using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");

        string select = "";

        do
        {
            Console.WriteLine("Please, select one of the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                journal.AddEntry();
            }

            else if (option == "2")
            {
                journal.DisplayAll();
            }

            else if (option == "3")
            {
                journal.SavetoFile();
            }

            else if (option == "4")
            {
                journal.LoadFromFile();
            }

            else
            {
                Console.WriteLine("See you soon!");
            }

            select = option;

        } while (select != "5");
    }
}