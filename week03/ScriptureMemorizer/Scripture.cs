using System;
using System.Collections.Generic; 

 public class Scripture  
    {  
        private Reference _reference;  
        private List<Word> _words;  

        public Scripture(Reference reference, string text)  
        {  
            _reference = reference;  
            _words = new List<Word>();  
            foreach (var word in text.Split(' '))  
            {  
                _words.Add(new Word(word));  
            }  
        }  

        public void HideRandomWords(int numberToHide)  
        {  
            Random rand = new Random();  
            for (int i = 0; i < numberToHide; i++)  
            {  
                int index = rand.Next(_words.Count);  
                _words[index].Hide();  
            }  
        }  

        public string GetDisplayText()  
        {  
            List<string> displayWords = new List<string>();  
            foreach (var word in _words)  
            {  
                displayWords.Add(word.GetDisplayText());  
            }  
            return string.Join(" ", displayWords);  
        }  

        public bool IsCompletelyHidden()  
        {  
            foreach (var word in _words)  
            {  
                if (!word.IsHidden())  
                    return false;  
            }  
            return true;  
        }  
    }  