using Stone_Red_Utilities.ConsoleExtentions;

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace Stone_Red_Utilities.Logging
{
    /// <summary>
    /// Class used for logging
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// The logging configuration.
        /// </summary>
        public LogConfig Config { get; set; }

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
        /// Log the message to the specified output
        /// </summary>
        /// <param name="message"></param>
        /// <param name="logSeverity"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void Log(string message, LogSeverity logSeverity = LogSeverity.Info, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            WriteLog(message, string.Empty, logSeverity, memberName, sourceFilePath, sourceLineNumber);
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
            {
                WriteLog(message, source, logSeverity, memberName, sourceFilePath, sourceLineNumber);
            }
        }

        /// <summary>
        /// Log the message to the specified output if the condition is met
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="message"></param>
        /// <param name="logSeverity"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void LogIf(bool condition, string message, LogSeverity logSeverity = LogSeverity.Info, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (condition)
            {
                WriteLog(message, string.Empty, logSeverity, memberName, sourceFilePath, sourceLineNumber);
            }
        }

        /// <summary>
        /// Clears the log file
        /// </summary>
        public void ClearLogFile(LogSeverity logSeverity)
        {
            OutputConfig outputConfig = GetOutputConfig(logSeverity);
            if (File.Exists(outputConfig.FilePath))
            {
                File.WriteAllText(outputConfig.FilePath, string.Empty);
            }
        }

        private void WriteLog(string message, string source, LogSeverity logSeverity, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0)
        {
            Config ??= new LogConfig();

            string consoleOutput = GetFormattedString(Config.FormatConfig.ConsoleFormat, logSeverity, source, message, memberName, sourceFilePath, sourceLineNumber);
            string debugOutput = GetFormattedString(Config.FormatConfig.DebugConsoleFormat, logSeverity, source, message, memberName, sourceFilePath, sourceLineNumber);
            string fileOutput = GetFormattedString(Config.FormatConfig.FileFormat, logSeverity, source, message, memberName, sourceFilePath, sourceLineNumber);

            OutputConfig outputConfig = GetOutputConfig(logSeverity);

            if ((outputConfig.LogTarget & LogTarget.Console) == LogTarget.Console)
            {
                ConsoleExt.WriteLine(consoleOutput, outputConfig.Color);
            }

            if ((outputConfig.LogTarget & LogTarget.DebugConsole) == LogTarget.DebugConsole)
            {
                Trace.WriteLine(debugOutput);
            }

            if ((outputConfig.LogTarget & LogTarget.File) == LogTarget.File)
            {
                if (!File.Exists(outputConfig.FilePath))
                {
                    File.Create(outputConfig.FilePath).Close();
                }

                File.AppendAllLines(outputConfig.FilePath, new[] { fileOutput });
            }
        }

        private OutputConfig GetOutputConfig(LogSeverity logSeverity)
        {
            return logSeverity switch
            {
                LogSeverity.Fatal => Config.FatalConfig,
                LogSeverity.Error => Config.ErrorConfig,
                LogSeverity.Warn => Config.WarnConfig,
                LogSeverity.Info => Config.InfoConfig,
                _ => Config.DebugConfig
            };
        }

        private string GetFormattedString(string format, LogSeverity logSeverity, string source, string message, string memberName, string sourceFilePath, int sourceLineNumber)
        {
            format = format
               .Replace($"{LogFormatType.DateTime}", "0")
               .Replace($"{LogFormatType.LogSeverity}", "1")
               .Replace($"{LogFormatType.LineNumber}", "2")
               .Replace($"{LogFormatType.FilePath}", "3")
               .Replace($"{LogFormatType.MemberName}", "4")
               .Replace($"{LogFormatType.Source}", "5")
               .Replace($"{LogFormatType.Message}", "6");

            return string.Format(format, DateTime.Now, logSeverity.ToString().ToUpper(), sourceLineNumber, sourceFilePath, memberName, source, message);
        }
    }
}