using System;

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