using Stone_Red_Utilities.Logging;

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace Stone_Red_C_Sharp_Utilities.Logging
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
        public void Log(string message, string source, LogSeverity logSeverity, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
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
        public void Log(string message, LogSeverity logSeverity, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            WriteLog(message, string.Empty, logSeverity, memberName, sourceFilePath, sourceLineNumber);
        }

        /// <summary>
        /// Log the message to the specified output
        /// </summary>
        /// <param name="message"></param>
        /// <param name="source"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void LogInfo(string message, string source, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            WriteLog(message, source, LogSeverity.Info, memberName, sourceFilePath, sourceLineNumber);
        }

        /// <summary>
        /// Log the message to the specified output
        /// </summary>
        /// <param name="message"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void LogInfo(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            WriteLog(message, string.Empty, LogSeverity.Info, memberName, sourceFilePath, sourceLineNumber);
        }

        /// <summary>
        /// Log the message to the specified output
        /// </summary>
        /// <param name="message"></param>
        /// <param name="source"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void LogWarn(string message, string source, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            WriteLog(message, source, LogSeverity.Warn, memberName, sourceFilePath, sourceLineNumber);
        }

        /// <summary>
        /// Log the message to the specified output
        /// </summary>
        /// <param name="message"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void LogWarn(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            WriteLog(message, string.Empty, LogSeverity.Warn, memberName, sourceFilePath, sourceLineNumber);
        }

        /// <summary>
        /// Log the message to the specified output
        /// </summary>
        /// <param name="message"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void LogError(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            WriteLog(message, string.Empty, LogSeverity.Error, memberName, sourceFilePath, sourceLineNumber);
        }

        /// <summary>
        /// Log the message to the specified output
        /// </summary>
        /// <param name="message"></param>
        /// <param name="source"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void LogError(string message, string source, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            WriteLog(message, source, LogSeverity.Error, memberName, sourceFilePath, sourceLineNumber);
        }

        /// <summary>
        /// Log the message to the specified output
        /// </summary>
        /// <param name="message"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void LogFatal(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            WriteLog(message, string.Empty, LogSeverity.Fatal, memberName, sourceFilePath, sourceLineNumber);
        }

        /// <summary>
        /// Log the message to the specified output
        /// </summary>
        /// <param name="message"></param>
        /// <param name="source"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void LogFatal(string message, string source, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            WriteLog(message, source, LogSeverity.Fatal, memberName, sourceFilePath, sourceLineNumber);
        }

        /// <summary>
        /// Log the message to the specified output
        /// </summary>
        /// <param name="message"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void LogDebug(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            WriteLog(message, string.Empty, LogSeverity.Debug, memberName, sourceFilePath, sourceLineNumber);
        }

        /// <summary>
        /// Log the message to the specified output
        /// </summary>
        /// <param name="message"></param>
        /// <param name="source"></param>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="sourceLineNumber"></param>
        public void LogDebug(string message, string source, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            WriteLog(message, source, LogSeverity.Debug, memberName, sourceFilePath, sourceLineNumber);
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
        public void LogIf(bool condition, string message, string source, LogSeverity logSeverity, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
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
        public void LogIf(bool condition, string message, LogSeverity logSeverity, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
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

            lock (outputConfig)
            {
                if (File.Exists(outputConfig.FilePath))
                {
                    File.WriteAllText(outputConfig.FilePath, string.Empty);
                }
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
                ConsoleExt.WriteLine(consoleOutput, outputConfig.ConsoleColor);
            }

            if ((outputConfig.LogTarget & LogTarget.DebugConsole) == LogTarget.DebugConsole)
            {
                Trace.WriteLine(debugOutput);
            }

            lock (outputConfig)
            {
                if ((outputConfig.LogTarget & LogTarget.File) == LogTarget.File)
                {
                    if (!File.Exists(outputConfig.FilePath))
                    {
                        File.Create(outputConfig.FilePath).Close();
                    }

                    File.AppendAllLines(outputConfig.FilePath, new[] { fileOutput });
                }
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
               .Replace(LogFormatType.DateTime, "0")
               .Replace(LogFormatType.LogSeverity, "1")
               .Replace(LogFormatType.LineNumber, "2")
               .Replace(LogFormatType.FilePath, "3")
               .Replace(LogFormatType.MemberName, "4")
               .Replace(LogFormatType.Source, "5")
               .Replace(LogFormatType.Message, "6");

            return string.Format(format, DateTime.Now, logSeverity.ToString().ToUpper(), sourceLineNumber, sourceFilePath, memberName, source, message);
        }
    }
}