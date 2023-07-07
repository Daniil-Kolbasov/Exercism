using System;

public static class LogAnalysis
{
	public static string SubstringAfter(this string str, string s) => str.Substring(str.IndexOf(s) + s.Length);

	public static string SubstringBetween(this string str, string firstDel, string secondDel)
	{
		str = str.Remove(0, str.IndexOf(firstDel) + firstDel.Length); ;
		str = str.Remove(str.IndexOf(secondDel));
		return str;
	}

	static string[] logLevel = { "INFO", "WARNING", "ERROR" };
	public static string Message(this string str)
	{
		foreach (var item in logLevel)
		{
			if (str.Contains(item))
			{
				str = str.Remove(0, item.Length + 3);
				break;
			}
		}
		return str.Trim(' ', '\r', '\n', '\t');
	}

	public static string LogLevel(this string str)
	{
		foreach (var item in logLevel)
		{
			if (str.Contains(item))
			{
				str = item;
				break;
			}
		}
		return str;
	}
}