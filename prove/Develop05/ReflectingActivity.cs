public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(int duration) 
        : base("Reflecting Activity", 
               "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 
               duration)
    {

        _prompts = new List<string>
        {
            "Take a deep breath and imagine your ideal day from morning to night. What does it look like?",
            "Reflect on a moment that made you feel truly at peace. What was happening around you?",
            "Think of a place where you feel most relaxed and safe. Describe the sights, sounds, and sensations.",
            "Imagine you’re looking at a calm body of water. What thoughts or feelings does the stillness bring up?",
            "Close your eyes and think about a time when you felt deeply connected to yourself or others. What made that moment special?"
        };

        _questions = new List<string>
        {
            "Why do you think this moment or experience stands out to you?",
            "How can you bring a bit of this peace or connection into your daily life?",
            "What emotions or insights did this reflection bring to the surface for you?",
            "If you could share this experience with someone, who would it be and why?",
            "What do you think this says about what’s important to you?"
        };
    }

    private string GetRandomPrompt()
    {
        Random randomSelected = new Random();
        return _prompts[randomSelected.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        Random randomSelected = new Random();
        return _questions[randomSelected.Next(_questions.Count)];
    }

    private void DisplayRandomPrompt()
    {
        Console.WriteLine();
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

    }

private void DisplayQuestions()
{
    int endTime = Environment.TickCount + _duration * 1000;

    while (Environment.TickCount < endTime)
    {
        Console.WriteLine($"> {GetRandomQuestion()}");
        ShowSpinner(10);
        Console.WriteLine();
        if (Environment.TickCount >= endTime)
        {
            break;
        }
    }
}




public void Run()
{
    DisplayStartingMessage();
    DisplayRandomPrompt();
    DisplayQuestions();
    DisplayEndingMessage();
}

}
