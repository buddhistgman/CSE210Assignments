using System;
using System.Threading;
using System.Collections.Generic;

class Time {
    private int _timeInput;
    
    public Time()
    {
        
    }
    
    public int getTimer()
    {
        return _timeInput;
    }
    
    public void setTimer()
    {
        Console.WriteLine("How long would you like to wait, in seconds? ");
        _timeInput = Int32.Parse(Console.ReadLine());
    }
    
    public void playAnimation()
    {
        
        List<string> animationStrings = new List <string> ();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        
        
        foreach (string L in animationStrings)
        {
            Console.Write(L);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
    
    public void dotAnimation()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_timeInput);
        
        while (DateTime.Now < endTime)
        {
            Console.Write(".");
            Thread.Sleep (500);
            Console.Write(".");
            Thread.Sleep (500);
            Console.Write(".");
            Thread.Sleep (500);
            Console.Write("\b \b \b");
        }
    }
}