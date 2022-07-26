using System;
using System.Linq;


namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPArome(string word)
        {
            if ( word == null || word.Length == 0)
            {
                return false;
            }

            var wordLowered = word.ToLower();
            var backwards = "";

            if (word == backwards)
            {
                return false;
            }

            else
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    backwards += word[i];
                }
                return backwards == word;
            }

            if (wordLowered == backwards)
            {
                return true;
            }
            else 
            { return false; }
        }
    }
}
