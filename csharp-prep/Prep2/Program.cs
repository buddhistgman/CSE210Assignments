using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string rawgrade = Console.ReadLine();
        int grade = int.Parse(rawgrade);
        string letterGrade;
        
        if (grade >= 90) letterGrade = "A";
        else if (grade >=80 && grade <=89) letterGrade = "B";
        else if (grade >=70 && grade <=79) letterGrade = "C";
        else if (grade >=60 && grade <=69) letterGrade = "D";
        else letterGrade = "F";
        
        string sign = "";
        int firstnumber = grade % 10;
        
        if (firstnumber >= 7) sign = "+";
        else if (firstnumber < 3) sign = "-";
        else sign = "";
        
        Console.WriteLine("Your grade is a " + letterGrade + sign + "!");
        
        if (grade >= 70) Console.WriteLine("You passed the course!");
        else Console.WriteLine("You failed the course!");
    }
}