using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        bool isUpper = false;
        char[] temp = identifier.ToCharArray();

        for (int i = 0; i < temp.Length; i++)
        {
            if (isUpper)
            {
                temp[i] = Char.ToUpper(temp[i]);
                isUpper = false;
            }

            if (temp[i] == '-')
                isUpper = true;
        }

        identifier = new(temp);

        return new(identifier
                   .Replace(" ", "_")
                   .Replace("\0", "CTRL")
                   .Where(c => char.IsLetter(c) && !(c >= '\u03B1' && c <= '\u03C9') || c == '_')
                   .ToArray());
    }
}
