using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;

class Program
{
    public static void Main()
    {
        goals = new List<GoalBase>();
        totalPoints = 0;
        ShowMenu();
    }
    private static List<GoalBase> goals;
    private static int totalPoints;
    
    public static void CreateNewGoal()
        {
            Console.WriteLine("The types of goals are: ");
            Console.WriteLine("1. Simple Goal: ");
            Console.WriteLine("2. Eternal Goal: ");
            Console.WriteLine("3. Checklist Goal: ");
            
            string response = Console.ReadLine();
            string goalName;
            string goalDescription;
            string goalPoints;
            
            if (response == "1")
            {
                Console.WriteLine ("What is the name of the goal? ");
                goalName = Console.ReadLine();
                Console.WriteLine ("What is a short description of the goal? ");
                goalDescription = Console.ReadLine();
                Console.WriteLine ("How many points do you want associated with the goal?");
                goalPoints = Console.ReadLine();
                if (Int32.Parse(goalPoints) < 0)
                {
                    Console.WriteLine("Try to only write positive goals!");
                }
                else
                {
                    goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
                }
            }
            
            else if (response == "2")
            {
                Console.WriteLine ("What is the name of the goal? ");
                goalName = Console.ReadLine();
                Console.WriteLine ("What is a short description of the goal? ");
                goalDescription = Console.ReadLine();
                Console.WriteLine ("How many points do you want associated with the goal?");
                goalPoints = Console.ReadLine();
                if (Int32.Parse(goalPoints) < 0)
                {
                    Console.WriteLine("Try to only write positive goals!");
                }
                else
                {
                    goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
                }
            }
            
            else if (response == "3")
            {
                string finishedTimes;
                string bonusPoints;
                
                Console.WriteLine ("What is the name of the goal? ");
                goalName = Console.ReadLine();
                Console.WriteLine ("What is a short description of the goal? ");
                goalDescription = Console.ReadLine();
                Console.WriteLine ("How many points do you want associated with the goal?");
                goalPoints = Console.ReadLine();
                Console.WriteLine ("How many times does this goal need to be accomplished for a bonus?");
                finishedTimes = Console.ReadLine();
                Console.WriteLine ("What is the bonus for accomplishing it that many times?");
                bonusPoints = Console.ReadLine();
                if (Int32.Parse(goalPoints) < 0 || Int32.Parse(bonusPoints) < 0)
                {
                    Console.WriteLine("Try to only write positive goals!");
                }
                else
                {
                    goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, finishedTimes, bonusPoints));
                }
            }
            
            else
            {
                Console.WriteLine("That is not a valid Option, please insert a valid option");
            }
        }
        
    public static void ListGoals()
        {
            int goalNum = 1;
            Console.WriteLine("The goals are: ");
            foreach (GoalBase goal in goals)
            {
                Console.Write(goalNum + ". ");
                Console.WriteLine(goal.displayGoalInfo());
                goalNum++;
            }
        }
        
    public static void SaveGoalToFile()
        {
        Console.WriteLine("Enter a filename to save the goals to:");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(totalPoints);
            foreach (GoalBase goal in goals)
            {
                outputFile.WriteLine(goal.getSaveGoal());
            }
        }
        }
        
    public static void LoadGoalFromFile()
    {
        Console.WriteLine("Enter a filename to load the goals from:");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        goals.Clear();
        
        totalPoints = Int32.Parse(lines[0]);
        for (int iter = 1; iter < lines.Length; iter++)
        {
            string[] typeSplit = lines[iter].Split(':');
            
            if (typeSplit[0] == "SimpleGoal")
            {
                goals.Add(new SimpleGoal(typeSplit[1]));
            }
            else if (typeSplit[0] == "EternalGoal")
            {
                goals.Add(new EternalGoal(typeSplit[1]));
            }
            else if (typeSplit[0] == "ChecklistGoal")
            {
                goals.Add(new ChecklistGoal(typeSplit[1]));
            }

        }
    }    
    
    public static void RecordEvent()
    {
        int goalNum = 1;
        int goalSelection = 0;
        Console.WriteLine("The goals are: ");
        foreach (GoalBase goal in goals)
        {
            Console.Write(goalNum + ". ");
            Console.WriteLine(goal.getGoalName());
            goalNum++;
        }
        Console.WriteLine("Which goal did you accomplish?");
        goalSelection = Int32.Parse(Console.ReadLine());
        goalSelection--;
        
        if (goalSelection >= 0 && goalSelection <= goals.Count)
        {
            if (goals[goalSelection].isComplete() == true)
            {
                Console.WriteLine ("You have already done this goal!");
            }
            else
            {
                goals[goalSelection].updateGoal();
                totalPoints = totalPoints + goals[goalSelection].getPoints();
            }
            
        }
    }
        
    public static void ShowMenu()
        {
            string input = "";
            while (input != "6")
            {
                //_completedPoints = points;
                Console.WriteLine("You have " + totalPoints + " points.\n");
                Console.WriteLine("Menu options:");
                Console.WriteLine(" 1. Create a new goal");
                Console.WriteLine(" 2. List Goals");
                Console.WriteLine(" 3. Save Goals");
                Console.WriteLine(" 4. Load Goals");
                Console.WriteLine(" 5. Record Event");
                Console.WriteLine(" 6. Quit");
                Console.WriteLine();
    
                Console.WriteLine("Please select an option:");
                input = Console.ReadLine();
    
                if (input == "1")
                {
                    CreateNewGoal();
                }
                else if (input == "2")
                {
                    ListGoals();
                }
                else if (input == "3")
                {
                    SaveGoalToFile();
                }
                else if (input == "4")
                {
                    LoadGoalFromFile();
                }
                else if (input == "5")
                {
                    RecordEvent();
                }
                else if (input == "6")
                {
                    Console.WriteLine("Goodbye.");
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }
            }
        }
        
}