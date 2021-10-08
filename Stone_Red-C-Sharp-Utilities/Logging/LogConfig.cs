﻿using System;

namespace Stone_Red_Utilities.Logging
{
    /// <summary>
    /// Logging configuration.
    /// </summary>
    public class LogConfig
    {
        /// <summary>
        /// The configuration for <see cref="LogSeverity.Debug"/> messages.
        /// </summary>
        public OutputConfig DebugConfig { get; set; } = new OutputConfig();

        /// <summary>
        /// The configuration for <see cref="LogSeverity.Info"/> messages.
        /// </summary>
        public OutputConfig InfoConfig { get; set; } = new OutputConfig();

        /// <summary>
        /// The configuration for <see cref="LogSeverity.Warn"/> messages.
        /// </summary>
        public OutputConfig WarnConfig { get; set; } = new OutputConfig();

        /// <summary>
        /// The configuration for <see cref="LogSeverity.Error"/> messages.
        /// </summary>
        public OutputConfig ErrorConfig { get; set; } = new OutputConfig();

        /// <summary>
        /// The configuration for <see cref="LogSeverity.Fatal"/> messages.
        /// </summary>
        public OutputConfig FatalConfig { get; set; } = new OutputConfig();

        /// <summary>
        /// The configuration for the message format.
        /// </summary>
        public FormatConfig FormatConfig { get; set; } = new FormatConfig();
    }

    /// <summary>
    /// Output configuration.
    /// </summary>
    public class OutputConfig
    {
        /// <summary>
        /// The onsole color of the log message.
        /// </summary>
        public ConsoleColor Color { get; set; } = ConsoleColor.White;

        /// <summary>
        /// The target for the log message.
        /// </summary>
        public LogTarget LogTarget { get; set; } = LogTarget.DebugConsole;

        /// <summary>
        /// The log file path.
        /// </summary>
        public string FilePath { get; set; } = "log.log";
    }

    /// <summary>
    /// Foramt configuration.
    /// </summary>
    public class FormatConfig
    {
        /// <summary>
        /// The format for the debug console.
        /// </summary>
        public string DebugConsoleFormat { get; set; } = $"{{{LogFormatType.DateTime}:yyyy-MM-dd HH:mm:ss}} | {{{LogFormatType.LogSeverity},-5}} | {{{LogFormatType.Source},-15}} | {{{LogFormatType.Message}}}";

        /// <summary>
        /// The format for the console.
        /// </summary>
        public string ConsoleFormat { get; set; } = $"{{{LogFormatType.DateTime}:yyyy-MM-dd HH:mm:ss}} | {{{LogFormatType.LogSeverity},-5}} | {{{LogFormatType.Source},-15}} | {{{LogFormatType.Message}}}";

        /// <summary>
        /// The format for the log file.
        /// </summary>
        public string FileFormat { get; set; } = $"{{{LogFormatType.DateTime}:yyyy-MM-dd HH:mm:ss}} | {{{LogFormatType.LogSeverity},-5}} | {{{LogFormatType.Source},-15}} | {{{LogFormatType.Message}}}";
    }
}