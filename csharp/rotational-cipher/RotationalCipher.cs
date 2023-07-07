using System;
using System.Text.RegularExpressions;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        return Regex.Replace(text, @"[a-zA-Z]", c =>
        {
            char[] charArray = c.ToString().ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                char d = Char.IsUpper(charArray[i]) ? 'A' : 'a';
                charArray[i] = (char)((((charArray[i] + shiftKey) - d) % 26) + d);
            }
            return new(charArray);
        });
    }
}