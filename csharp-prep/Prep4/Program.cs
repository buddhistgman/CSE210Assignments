using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       List<int> numbers = new List<int>();
       
    int userNumber = -1;
    while (userNumber != 0)
    {
        Console.Write ("Enter a number (Enter 0 to end the list): ");
        
        string userResponse = Console.ReadLine();
        userNumber = int.Parse(userResponse);
        
        if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        
    }
    //sum calculation
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }

        Console.WriteLine("The sum of the numbers is: " + sum);
        
    //average calculation
    float average = ((float)sum) / numbers.Count;
    Console.WriteLine ("The average of the numbers is " + average);
    
    //max calculation
    int max = numbers[0];
    
    foreach (int number in numbers)
    {
        if (number > max)
        {
            max = number;
        }
    }
    Console.WriteLine ("The max of the numbers is " + max);
    
    //smallest positive number calculation
    int min = numbers[1];
    
    foreach (int number in numbers)
    {
        if (number < min) 
        {
            if (number > 0)
            {
                min = number;
            }
            
        }
    }
    Console.WriteLine ("The minimum of the numbers is " + min);
    
    //from least to greatest list
    numbers.Sort();
    Console.WriteLine ("the numbers from least to greatest are: ");
    foreach (int number in numbers)
    {
        Console.WriteLine (number);
    }
    
    }
    
}