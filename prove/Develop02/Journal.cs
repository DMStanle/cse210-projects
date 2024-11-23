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
    Console.WriteLine("What is the file name?");
    string fileName = Console.ReadLine();

    if (File.Exists(fileName))
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(fileName);
        for (int i = 0; i < lines.Length; i += 3)
        {
            if (i + 2 < lines.Length)
            {
                
                string dateLine = lines[i].Replace("Date: ", "").Split(" - Prompt: ")[0];
                string promptLine = lines[i].Split(" - Prompt: ")[1];
                string entryText = lines[i + 1];

                
                Entry entry = new Entry(promptLine, entryText) { _date = dateLine };
                _entries.Add(entry);
            }
        }
    }
    else
    {
        Console.WriteLine("File not found.");
    }
}
}