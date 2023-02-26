using System.Collections.Generic;

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