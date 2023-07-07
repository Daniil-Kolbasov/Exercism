using System;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string result = string.Empty;

        foreach (Match match in Regex.Matches(phrase, @"[A-Za-z']+"))
            result += Char.ToUpper(match.Value[0]);

        return result;
    }
}