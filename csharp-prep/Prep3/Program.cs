using System;

class Program
{
    static void Main(string[] args)
    
    {
    Random randomGenerator = new Random();
    int number = randomGenerator.Next(1, 11);
      
    int guess = -1;
    int numGuess = 0;
    string input = "";
    do
    {    
        do //(guess != number)
        {
            Console.Write ("you are at " + numGuess + " guesses.... \n");
            Console.Write ("guess a number, between 1 and 10: ");
            guess = int.Parse(Console.ReadLine());
            
            if (guess > number)
            {
                Console.Write ("Lower,  ");
                numGuess = numGuess + 1;
            }
            
            else if (guess < number)
            {
                Console.Write ("Higher, ");
                numGuess = numGuess + 1;
            }
            
            else
            {
            Console.WriteLine ("Correct!, you got the answer correct after " + numGuess + " guesses!");
            
                
            }
            
        }while (guess != number);
    Console.Write("Do you want to continue? ");
    numGuess = 0;
    number = randomGenerator.Next(1, 11);
    input = Console.ReadLine();    
    }
    while (input == "yes");
}
}