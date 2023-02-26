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