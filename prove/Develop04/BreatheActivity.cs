using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;

class BreatheActivity : Activity {
    
    public BreatheActivity ()
    {
        _activityName = "Breathing";
        _activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        
        
    }
    public void runBreathing()
    {
        
        showDelayAnimation();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time.getTimer());
        
        while (DateTime.Now < endTime)
        {
            breatheLoop(endTime, 4, "in... ");
            breatheLoop(endTime, 6, "out... ");
        }
    }
    
    public void breatheLoop (DateTime endTime, int duration, string prompt)
    {
       
        int breatheTime = 1;
        
        
        do {
            Console.Clear();
            Console.Write("Breathe " + prompt + " ");
            Console.Write(breatheTime);
            Thread.Sleep(1000);
            Console.Write("\b");
            breatheTime++;
        }
        while (breatheTime <= duration && DateTime.Now < endTime);
    }
}