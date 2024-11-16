using System;
using System.Data.Common;
using System.Net.Mail;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string promptText, string entryText)
    {
        _date = DateTime.Now.ToString("MM/dd/yyyy");
        _promptText = promptText;
        _entryText = entryText;

    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        

    }
}