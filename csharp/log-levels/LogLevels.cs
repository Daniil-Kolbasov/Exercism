using System;

static class LogLine
{
    private static string[] LogLevelArray = { "[INFO]:", "[WARNING]:", "[ERROR]:" };

        public static string Message(string logLine)
        {
            return message(logLine);
        }

        public static string LogLevel(string logLine)
        {
            
            return logLevel(logLine);
        }

        public static string Reformat(string logLine)
        {
            return message(logLine) + " (" + logLevel(logLine) + ")";
        }

        private static string logLevel(string logLine)
        {
            foreach (var item in LogLevelArray)
            {
                if (logLine.Contains(item))
                {
                    return item.TrimStart('[').TrimEnd(']',':').ToLower();
                }
            }

            // TODO: throw exception
            return logLine;
        }

        private static string message(string logLine)
        {
            return logLine.Remove(0, logLevel(logLine).Length + 3).Trim(' ', '\r', '\n', '\t');
        }
}
