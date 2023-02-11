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
                
                Console.WriteLine(availableNums[randomNumber]);
                availableNums.RemoveAt(randomNumber);
                }
            }
            
            
            Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish:");
            quitString = Console.ReadLine();
            Console.Clear();
            
            
        }
        
    }
    
    
class Reference 
    {
        private string bookName;
        private string chapterNumber;
        private string verseNumber;
        private string endVerseNumber;
        
        public Reference (string bookNameParam, string chapterNumberParam, string verseNumberParam)
        {
            bookName = bookNameParam;
            chapterNumber = chapterNumberParam;
            verseNumber = verseNumberParam;
            endVerseNumber = "X";
        }
        
        public Reference (string bookNameParam, string chapterNumberParam, string verseNumberParam, string endVerseNumberParam)
        {
            bookName = bookNameParam;
            chapterNumber = chapterNumberParam;
            verseNumber = verseNumberParam;
            endVerseNumber = endVerseNumberParam;
            
        }
        public void printFullReference()
        {
            if (endVerseNumber == "X")
            {
                Console.Write(bookName + " " + chapterNumber + ":" + verseNumber + " ");
            }
            else
            {
                Console.Write(bookName + " " + chapterNumber + ":" + verseNumber + "-" + endVerseNumber + " ");
            }
            
        }
    } 
    
    
    class Scripture
    {
        private Reference reference;
        private List <Word> scriptureText;
        public Scripture(Reference referenceParam, List <Word>textParam)
        {
            reference = referenceParam;
            scriptureText = textParam;
        }
        public Reference getReference()
        {
            return reference;
            
        }
        public List<Word> getScriptureText()
        {
            return scriptureText;
        }
    }
    
    
    class Word
    {
        public Word (string wordParam)
        {
            hiddenWord = "";
            wordVal = wordParam;
            foreach (char x in wordVal)
            {
                hiddenWord = hiddenWord + "_";
            }
        }
        public Word (string wordParam, bool isHiddenParam)
        {
            hiddenWord = "";
            wordVal = wordParam;
            isHidden = isHiddenParam;
            
            foreach (char x in wordVal)
            {
                hiddenWord = hiddenWord + "_";
            }
        }

        private string hiddenWord;
        private string wordVal;
        private bool isHidden;
        
        public string showWord()
        {
            if (isHidden == true)
            {
                return hiddenWord;
            }
            else
            {
                return wordVal;
            }
        }
        public void setHidden(bool isHiddenParam)
        {
            isHidden = isHiddenParam;
        }
    }
}