using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine ("Welcome to the program!");
    }
    
    static string PromptUserName()
    {
        Console.Write ("what is your username? ");
        string name = Console.ReadLine();
        
        return name;
    }
    
    static int PromptUserNumber()
    {
        Console.Write ("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        
        return number;
    }
    
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine (userName + ", the square of your number is " + squaredNumber);
    }
}