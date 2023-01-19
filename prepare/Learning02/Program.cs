using System;

class Program
{
    static void Main(string[] args)
    {
        //this creates a new job using the class "public class Job" from "Job.cs"
        Job job1 = new Job();
        job1._jobTitle = "Back-end Web Development";
        job1._company = "EA Games";
        job1._startYear = 1999;
        job1._endYear = 2002;
        
        Job job2 = new Job();
        job2._jobTitle = "Back-end Web Development Manager";
        job2._company = "EA Games";
        job2._startYear = 2002;
        job2._endYear = 2002;
        
        Job job3 = new Job();
        job3._jobTitle = "Janitor";
        job3._company = "EA Games";
        job3._startYear = 2002;
        job3._endYear = 2004;
        
        Job job4 = new Job();
        job4._jobTitle = "Vending Machine Stocker";
        job4._company = "Coca-Cola";
        job4._startYear = 2004;
        job4._endYear = 2005;
        
        Job job5 = new Job();
        job5._jobTitle = "Software Engineer";
        job5._company = "Coca-Cola";
        job5._startYear = 2005;
        job5._endYear = 2010;
        
        Job job6 = new Job();
        job6._jobTitle = "Software Engineer Manager";
        job6._company = "Coca-Cola";
        job6._startYear = 2010;
        job6._endYear = 2022;
        
        // makes a new list from the class "public class Resume" in "Resume.cs"
        Resume myResume = new Resume();
        myResume._name = "Bob Bobbert";
        
        //this prints the list of jobs by using the Display from "Resume.cs", and than the display from "Job.cs"
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);
        myResume._jobs.Add(job4);
        myResume._jobs.Add(job5);
        myResume._jobs.Add(job6);
        
        myResume.Display();
    }
}