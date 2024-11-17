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

    }
    public void LoadFromFile(string file)
    {
        
    }
}