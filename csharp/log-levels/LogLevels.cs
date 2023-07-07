using System;

static class LogLine
{
	private static string[] LogLevelArray = { "[INFO]:", "[WARNING]:", "[ERROR]:" };

	public static string Message(string logLine) => message(logLine);

	public static string LogLevel(string logLine) => logLevel(logLine);

	public static string Reformat(string logLine) => message(logLine) + " (" + logLevel(logLine) + ")";

	private static string logLevel(string logLine)
	{
		foreach (var item in LogLevelArray)
		{
			if (logLine.Contains(item))
			{
				return item.TrimStart('[').TrimEnd(']', ':').ToLower();
			}
		}

		return logLine;
	}

	private static string message(string logLine) =>
		logLine.Remove(0, logLevel(logLine).Length + 3).Trim(' ', '\r', '\n', '\t');
}
