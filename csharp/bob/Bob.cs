using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        if (IsNoAppeal(statement))
            return "Fine. Be that way!";

        if (IsShout(statement))
            if (IsQuestion(statement))
                return "Calm down, I know what I'm doing!";
            else
                return "Whoa, chill out!";

        if (IsQuestion(statement))
            return "Sure.";

        return "Whatever.";
    }

    private static bool IsShout(string statement)
    {
        if (statement.Any(Char.IsLetter))
        {
            if (statement.Any(Char.IsLower))
                return false;
        }
        else
            return false;

        return true;
    }

    private static bool IsQuestion(string statement)
    {
        if (statement.TrimEnd(' ', '\r', '\n', '\t').EndsWith('?'))
            return true;
        else
            return false;
    }

    private static bool IsNoAppeal(string statement)
    {
        foreach (var c in statement)
            if (Char.IsLetter(c) || Char.IsDigit(c) || c == '?')
                return false;

        return true;
    }
}