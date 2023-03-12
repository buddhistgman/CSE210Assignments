using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;

class SimpleGoal : GoalBase
{
    private bool _completed;
    
    public SimpleGoal(string goalString)
    {
        _goalType = "SimpleGoal";
        string[] splitString = goalString.Split(',');
        _goalName = splitString[0];
        _goalDescription = splitString[1];
        _goalPoints = Int32.Parse(splitString[2]);
        _completed = bool.Parse(splitString[3]);
        if (_completed == true)
        {
            _completeMark = "X";
        }
        else
        {
            _completeMark = " ";
        }
    }
    
    public SimpleGoal(string goalName,string goalDescription,string goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = Int32.Parse(goalPoints);
        _completed = false;
        _completeMark = " ";
        _goalType = "SimpleGoal";
        
    }
    public override void updateGoal()
    {
        _completed = true;
        _completeMark = "X";
    }
    public override string getSaveGoal()
    {
        return _goalType + ":" + _goalName + "," + _goalDescription + "," + _goalPoints + "," +_completed;
    }
    public override int getPoints()
    {
        int points = 0;
        if (_completed == true)
        {
            points = _goalPoints;
        }
        return points;
    }
    
    public override bool isComplete()
    {
        return _completed;
    }
    public override string displayGoalInfo()
    {
        string returnString;
        returnString =" [" + _completeMark + "] " + _goalName + " (" + _goalDescription + ")";
        return returnString;
    }
}