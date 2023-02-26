using System;
using System.Collections.Generic;

class ListingActivity : Activity {

    private List<string> prompts;
    
    public ListingActivity ()
    {
        prompts = new List<string>() {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _activityName = "Listing";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        
    }
    
    public void runListing()
    {
        Random random = new Random();
        int randomPrompt;
        
        int numOfItems = 0;
        
        showDelayAnimation();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time.getTimer());
        randomPrompt = random.Next(0, prompts.Count);
        Console.WriteLine(prompts[randomPrompt]);
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            numOfItems++;

        }
        Console.WriteLine("You listed " + numOfItems + " Items!");
    }
}