using System;
using System.Collections.Generic;
using System.Linq;

public class Anagram
{
    private readonly string _baseWord;
    
    public Anagram(string baseWord)
    {
        _baseWord = baseWord;
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<string> anagramList = new List<string>();
        string baseSet = string.Concat(_baseWord.ToLower().OrderBy(c => c));

        foreach (string word in potentialMatches)
        {
            if (_baseWord.ToLower() != word.ToLower())
            {
                string wordSet = string.Concat(word.ToLower().OrderBy(c => c));

                if (baseSet == wordSet)
                    anagramList.Add(word);
            }
        }

        return anagramList.ToArray();
    }
}