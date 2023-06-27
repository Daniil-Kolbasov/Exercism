using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        foreach(char c in alphabet)
        {
            if (!input.Contains(c, StringComparison.CurrentCultureIgnoreCase)) return false;
        }

        return true;
    }
}
