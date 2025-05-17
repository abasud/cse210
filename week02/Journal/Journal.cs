using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    List<Entry> _entries = new List<Entry>();

    Entry newEntry = new Entry();
    
    public void AddEntry()
    {
        Entry newEntry = new Entry();
        Console.WriteLine(newEntry._prompt);
        Console.Write("> ");
        newEntry._entry = Console.ReadLine();
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SavetoFile()
    {
        Console.WriteLine("What is the filename?");
        string file = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._entry}");
            }            
        }
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What is the filename?");
        string file = Console.ReadLine();

        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry();
                    entry._date = parts[0];
                    entry._prompt = parts[1];
                    entry._entry = parts[2];

                    _entries.Add(entry);
                }
            }

        Console.WriteLine("Journal loaded successfully.");
        }
        
        else
        {
            Console.WriteLine("File not found.");
        }
    }

}