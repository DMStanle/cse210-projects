using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What is something taht made you smile today?",
            "What was the most meaningful experience that you had today?",
            "What was your most meaningful connection with someone today?",
            "What is the most important thing that you did today?",
            "How could you have done better today? "
        };
    }

    


    public string GetRandomPrompt()
    {
        Random randomSelection = new Random();
        int randomIndexed = randomSelection.Next(_prompts.Count);
        return _prompts[randomIndexed];

    }

}