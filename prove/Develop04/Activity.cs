using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

class Activity{
    protected string _activityName;
    protected string _activityDescription;
    protected Time _time;
    
    public Activity ()
    {
        _time = new Time();
    }
    
    public void setActivityTime()
    {
        _time.setTimer();
    }
    
    public void showActivityIntro()
    {
        showActivityName();
        showActivityDescription();
    }
    
    public void showActivityName()
    {
        Console.WriteLine("Welcome to the " + _activityName + " Activity!");
    }
    
    public void showDelayAnimation()
    {
        Console.WriteLine("Get Ready! ");
        _time.playAnimation();
    }
    
    public void showActivityDescription()
    {
        Console.WriteLine(_activityDescription);
    }
    
    public void showActivityEndMessage()
    {
        Console.WriteLine("\nWell Done! ");
        _time.playAnimation();
        
        Console.WriteLine("\nYou have completed another " + _time.getTimer() + " seconds of the " + _activityName + " activity! ");
        _time.playAnimation();
    }
}