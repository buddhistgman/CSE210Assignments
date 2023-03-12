using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;

class EternalGoal : GoalBase
{
    protected int _timesCompleted;
    
    public EternalGoal(string goalString)
    {
        string[] splitString = goalString.Split(',');
        _goalName = splitString[0];
        _goalDescription = splitString[1];
        _goalPoints = Int32.Parse(splitString[2]);
    }
    
    public EternalGoal(string goalName,string goalDescription,string goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = Int32.Parse(goalPoints);
        _completeMark = " ";
        _goalType = "EternalGoal";
        
        _timesCompleted = 0;
    }
    
    public override void updateGoal()
    {
        _timesCompleted++;
    }
    public override int getPoints()
    {
        return _goalPoints;
    }
    public override int getLoadedPoints()
    {
        return _goalPoints * _timesCompleted;
    }
    public override string getSaveGoal()
    {
        return _goalType + ":" + _goalName + "," + _goalDescription + "," + _goalPoints;
    }
    public override string displayGoalInfo()
    {
        string returnString;
        returnString =" [" + _completeMark + "] " + _goalName + " (" + _goalDescription + ")";
        return returnString;
    }
}