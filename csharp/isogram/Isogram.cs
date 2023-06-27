using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        List<char> letters = new();
        foreach (char c in word)
        {
            if (Char.IsLetter(c))
            {
                if (letters.Contains(Char.ToLower(c)))
                    return false;
                else
                    letters.Add(Char.ToLower(c));
            }
        }

        return true;
    }
}
