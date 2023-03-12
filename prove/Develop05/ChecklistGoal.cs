using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;

class ChecklistGoal : GoalBase
{
    protected int _finishingTimes;
    protected int _timesCompleted;
    protected int _bonusPoints;
    
    public ChecklistGoal(string goalString)
    {
        _goalType = "ChecklistGoal";
        string[] splitString = goalString.Split(',');
        _goalName = splitString[0];
        _goalDescription = splitString[1];
        _goalPoints = Int32.Parse(splitString[2]);
        _bonusPoints = Int32.Parse(splitString[3]);
        _finishingTimes = Int32.Parse(splitString[4]);
        _timesCompleted = Int32.Parse(splitString[5]);
        if (_timesCompleted == _finishingTimes)
        {
            _completeMark = "X";
        }
        else
        {
            _completeMark = " ";
        }
    }
    
    public ChecklistGoal(string goalName, string goalDescription, string goalPoints, string finishedTimes, string bonusPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = Int32.Parse(goalPoints);
        _finishingTimes = Int32.Parse(finishedTimes);
        _bonusPoints = Int32.Parse(bonusPoints);
        _completeMark = " ";
        _goalType = "ChecklistGoal";
        
        _timesCompleted = 0;
        
    }
    public override void updateGoal()
    {
        _timesCompleted++;
        if (_timesCompleted == _finishingTimes)
        {
            _completeMark = "X";
        }
    }
    public override int getPoints()
    {
        int points = 0;
        if (_timesCompleted == _finishingTimes)
        {
            points = _bonusPoints;
        }
        return points + _goalPoints;
    }
    public override bool isComplete()
    {
        if (_timesCompleted == _finishingTimes)
        {
            return true;
        }
        return false;
    }
    public override string getSaveGoal()
    {
        return _goalType + ":" + _goalName + "," + _goalDescription + "," + _goalPoints + "," + _bonusPoints + "," + _finishingTimes + "," + _timesCompleted;
    }
    public override string displayGoalInfo()
    {
        string returnString;
        returnString =" [" + _completeMark + "] " + _goalName + " (" + _goalDescription + ") " + "-- Currently Completed: " + _timesCompleted + "/" + _finishingTimes;
        return returnString;
    }
}