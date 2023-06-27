using System;
using System.Linq;

public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        string result = string.Empty;

        for (int i = 0; i < input.Length; i++)
        {
            int count = 1;
            for (int j = i + 1; j < input.Length; j++)
            {
                if (input[i] == input[j])
                {
                    count++;
                    i = j;
                }
                else break;
            }

            if (count == 1)
                result += input[i];
            else
                result += string.Format($"{count}{input[i]}");
        }

        return result;
    }

    public static string Decode(string input)
    {
        string result = string.Empty;

        for (int i = 0; i < input.Length; i++)
        {
            string repeatNumber = string.Empty;
            for (int j = i; j < input.Length - 1; j++)
                if (char.IsDigit(input[j]))
                {
                    repeatNumber += input[j];
                    i = j;
                }
                else break;

            if (!string.IsNullOrEmpty(repeatNumber))
            {
                result += string.Concat(Enumerable.Repeat(input[i + 1],
                        int.Parse(repeatNumber)));
                i++;
            }
            else
                result += input[i];
        }

        return result;
    }
}
