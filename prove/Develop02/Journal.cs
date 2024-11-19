using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }
    
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);


    }    
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }

    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("What is the file name?");
        string fileName = Console.ReadLine();
        using (StreamWriter dropIn = new StreamWriter(fileName, append: true))
        {
            foreach (var entry in _entries)
            {
                dropIn.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
                dropIn.WriteLine(entry._entryText);
                dropIn.WriteLine();
            }
        }
    }
    public void LoadFromFile(string file)
    {
        
    }
}