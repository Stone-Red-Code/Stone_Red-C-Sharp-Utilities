using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Stone_Red_Utilities.ConsoleExtentions;

namespace Stone_Red_Utilities.Logging
{
    /// <summary>
    /// Specifies the severity of the log target.
    /// </summary>
    public enum LogTarget
    {
        /// <summary>
        /// Writes log to console
        /// </summary>
        Console,

        /// <summary>
        /// Writes log to debug console
        /// </summary>
        DebugConsole,

        /// <summary>
        /// Writes log to file
        /// </summary>
        File,

        /// <summary>
        /// Writes log to console and file
        /// </summary>
        ConsoleAndFile,

        /// <summary>
        /// Writes log to debug console and file
        /// </summary>
        DebugAndFile,

        /// <summary>
        /// Writes log to console debug console and file
        /// </summary>
        All
    }

    /// <summary>
    /// Specifies the severity of the log message.
    /// </summary>
    public enum LogSeverity
    {
        /// <summary>
        /// Logs that contain the most detailed messages.
        /// </summary>
        Debug,

        /// <summary>
        /// Logs that track the general flow of the application.
        /// </summary>
        Info,

        /// <summary>
        /// Logs that highlight an abnormal activity in the flow of execution.
        /// </summary>
        Warning,

        /// <summary>
        /// Logs that highlight when the flow of execution is stopped due to a failure.
        /// </summary>
        Error,

        /// <summary>
        /// Logs that contain the most severe level of error. This type of error indicate that immediate attention may be required.
        /// </summary>
        Fatal
    }

    /// <summary>
    /// Class used for logging
    /// </summary>
    public class Logger
    {
        private readonly string logPath;
        private readonly LogTarget logTarget;

        /// <summary>
        /// Format that is used when logging to the console
        /// </summary>
        public string ConsoleLogFormat { get; set; }

        /// <summary>
        /// Format that is used when logging to the debug console
        /// </summary>
        public string DebugConsoleLogFormat { get; set; }

        /// <summary>
        /// Format that is used when logging to a file
        /// </summary>
        public string FileLogFormat { get; set; }

        /// <summary>
        /// Initializes the logger with the default format and a file path
        /// </summary>
        /// <param name="defaultFormat"></param>
        /// <param name="logTarg"></param>
        /// <param name="file"></param>
        public Logger(LogTarget logTarg = LogTarget.Console, string file = null, string defaultFormat = "{<dateTime>:HH:mm:ss} | {<level>,-7} | {<source>,-15} | {<message>}")
        {
            if (logTarg == LogTarget.ConsoleAndFile || logTarg == LogTarget.DebugAndFile || logTarg == LogTarget.File || logTarg == LogTarget.All)
                logPath = file ?? throw new ArgumentNullException(nameof(file), $"file can't be null!");

            logTarget = logTarg;
            ConsoleLogFormat = defaultFormat;
            DebugConsoleLogFormat = defaultFormat;
            FileLogFormat = defaultFormat;
        }

        /// <summary>
        /// Initializes the logger with the default format
        /// </summary>
        /// <param name="defaultFormat"></param>
        /// <param name="logTarg"></param>
        public Logger(LogTarget logTarg = LogTarget.Console, string defaultFormat = "{<dateTime:HH:mm:ss>} | {<level>,-7} | {<source>,-15} | {<message>}")
        {
            if (logTarg == LogTarget.ConsoleAndFile || logTarg == LogTarget.DebugAndFile || logTarg == LogTarget.File || logTarg == LogTarget.All)
                throw new ArgumentNullException("file", $"file can't be null!");

            logTarget = logTarg;
            ConsoleLogFormat = defaultFormat;
            DebugConsoleLogFormat = defaultFormat;
            FileLogFormat = defaultFormat;
        }

        /// <summary>
        /// Log the message to the specified output
        /// </summary>
        /// <param name="message"></param>
        /// <param name="source"></param>
        /// <param name="logSeverity"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void Log(string message, string source, LogSeverity logSeverity = LogSeverity.Info, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            WriteLog(message, source, logSeverity, memberName, sourceFilePath, sourceLineNumber);
        }

        /// <summary>
        /// Log the message to the specified output if the condition is met
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="message"></param>
        /// <param name="source"></param>
        /// <param name="logSeverity"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void LogIf(bool condition, string message, string source, LogSeverity logSeverity = LogSeverity.Info, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (condition)
                WriteLog(message, source, logSeverity, memberName, sourceFilePath, sourceLineNumber);
        }

        /// <summary>
        /// Clears the log file
        /// </summary>
        public void ClearLogFile()
        {
            if (File.Exists(logPath))
                File.WriteAllText(logPath, string.Empty);
        }

        private void WriteLog(string message, string source, LogSeverity logSeverity, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0)
        {
            string consoleOutput = GetFormattedString(ConsoleLogFormat, logSeverity, source, message, memberName, sourceFilePath, sourceLineNumber);
            string debugOutput = GetFormattedString(DebugConsoleLogFormat, logSeverity, source, message, memberName, sourceFilePath, sourceLineNumber);
            string fileOutput = GetFormattedString(FileLogFormat, logSeverity, source, message, memberName, sourceFilePath, sourceLineNumber);

            switch (logTarget)
            {
                case LogTarget.Console:
                    ConsoleExt.WriteLine(consoleOutput, GetColor(logSeverity));
                    break;

                case LogTarget.DebugConsole:
                    Debug.WriteLine(debugOutput);
                    break;

                case LogTarget.File:
                    File.AppendAllLines(logPath, new[] { fileOutput });
                    break;

                case LogTarget.ConsoleAndFile:
                    ConsoleExt.WriteLine(consoleOutput, GetColor(logSeverity));
                    File.AppendAllLines(logPath, new[] { fileOutput });
                    break;

                case LogTarget.DebugAndFile:
                    Debug.WriteLine(debugOutput);
                    File.AppendAllLines(logPath, new[] { fileOutput });
                    break;

                case LogTarget.All:
                    Debug.WriteLine(debugOutput);
                    ConsoleExt.WriteLine(consoleOutput, GetColor(logSeverity));
                    File.AppendAllLines(logPath, new[] { fileOutput });
                    break;

                default:
                    throw new ArgumentException("Log target type not valid!");
            }
        }

        private ConsoleColor GetColor(LogSeverity logSeverity)
        {
            return logSeverity switch
            {
                LogSeverity.Fatal => ConsoleColor.DarkRed,
                LogSeverity.Error => ConsoleColor.Red,
                LogSeverity.Warning => ConsoleColor.DarkYellow,
                LogSeverity.Info => ConsoleColor.White,
                _ => ConsoleColor.DarkGray,
            };
        }

        private string GetFormattedString(string format, LogSeverity logSeverity, string source, string message, string memberName, string sourceFilePath, int sourceLineNumber)
        {
            format = format
               .Replace("<dateTime>", "0")
               .Replace("<level>", "1")
               .Replace("<lineNumber>", "2")
               .Replace("<filePath>", "3")
               .Replace("<memberName>", "4")
               .Replace("<source>", "5")
               .Replace("<message>", "6");

            return string.Format(format, DateTime.Now, logSeverity, sourceLineNumber, sourceFilePath, memberName, source, message);
        }
    }
}