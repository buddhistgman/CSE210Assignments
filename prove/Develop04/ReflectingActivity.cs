using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;

class ReflectingActivity : Activity {
    
    private List<string> prompts;
    private List<string> followUpPrompts;
    
    public ReflectingActivity ()
    {
        _activityName = "Reflecting";
        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        prompts = new List<string>() {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        };    
        followUpPrompts = new List<string>(){
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }
    public void runReflecting()
    {
        Random random = new Random();
        int randomPrompt;
        int randomFollowUpPrompt;
        
        showDelayAnimation();

        
        randomPrompt = random.Next(0, prompts.Count);
        Console.WriteLine("\n" + prompts[randomPrompt]);
        Console.WriteLine("When you have something in mind, press enter to continue: ");
        Console.ReadLine();
        Thread.Sleep(2000);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time.getTimer());
        while (DateTime.Now < endTime)
        {
            randomFollowUpPrompt = random.Next(0, followUpPrompts.Count);
            Console.WriteLine(followUpPrompts[randomFollowUpPrompt]);
            Thread.Sleep(5000);
        }
    }
}