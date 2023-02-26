using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;


class HelloWorld {
    
    static void Main() 
    {
        Scripture scripture; 
        Reference reference = new Reference("Proverbs","3","5","6");
        
        Random random = new Random();
        int randomNumber;
        
        List<int> availableNums = new List<int>();
        int numCount = 0;
        bool cont = true;

        string quitString = "";
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        string []splitScriptureText = scriptureText.Split(" ");
        
        List <Word> wordList = new List<Word>();
        
        foreach (string x in splitScriptureText)
        {
            availableNums.Add(numCount);
            wordList.Add(new Word(x));
            numCount++;
        }
        
        scripture = new Scripture(reference, wordList);
        
        while(quitString != "quit" && cont == true)
        {
            if (availableNums.Count == 0)
            {
                cont = false;
            }
            reference.printFullReference();
            foreach (Word word in scripture.getScriptureText())
            {
                Console.Write(word.showWord() + " ");
            }
            
            for (int i = 0; i<3; i++)
            {
                if (availableNums.Count > 0)
                {
                randomNumber = random.Next(0, availableNums.Count);
                scripture.getScriptureText()[ availableNums[randomNumber] ].setHidden(true);

                availableNums.RemoveAt(randomNumber);
                }
            }
            
            
            Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish:");
            quitString = Console.ReadLine();
            Console.Clear();
            
            
        }
        
    }
    
    
 
    
    
    
}