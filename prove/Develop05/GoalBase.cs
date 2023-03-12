using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

abstract class GoalBase{
    protected int _goalPoints;
    
    protected string _goalDescription;
    protected string _goalName;
    protected string _goalType;
    protected string _completeMark;
    
    public abstract int getLoadedPoints();
    public abstract string getSaveGoal();
    public abstract void updateGoal();
    public abstract string displayGoalInfo();
    public abstract int getPoints();
    
    public string getGoalName()
    {
        return _goalName;
    }

}