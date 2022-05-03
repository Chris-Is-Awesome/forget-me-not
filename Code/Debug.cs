using System;
using System.Diagnostics;

namespace ForgetMeNot
{
    static class Debug
    {
        private static string Timestamp
        {
            get
            {
                return $"[{DateTime.Now.ToString("hh:mm:ss.fff")}]";
            }
        }

        public static void Log(object message, bool includeTimestamp = true)
        {
            if (includeTimestamp)
                Console.WriteLine($"\n{Timestamp} LOG: {message}\n");
            else
                Console.WriteLine($"\nLOG: {message}\n");
        }

        public static void LogWarning(object message)
        {
            Console.WriteLine($"\n{Timestamp} WARN: {message}\n");
        }

        public static void LogError(object message, bool includeStacktrace = true)
        {
            Console.WriteLine($"\n{Timestamp} ERROR: {message}\n{new StackTrace()}\n");
        }
    }
}