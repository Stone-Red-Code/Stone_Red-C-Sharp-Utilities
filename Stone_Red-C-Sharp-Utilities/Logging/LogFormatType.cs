namespace Stone_Red_C_Sharp_Utilities.Logging
{
    /// <summary>
    /// Specifies the info type of the log message format.
    /// </summary>
    public static class LogFormatType
    {
        /// <summary>
        /// The <see cref="System.DateTime"/> of the log message.
        /// </summary>
        public const string DateTime = "<DateTime>";

        /// <summary>
        /// The <see cref="LogSeverity"/> of the log message.
        /// </summary>
        public const string LogSeverity = "<LogSeverity>";

        /// <summary>
        /// The line number of the log message.
        /// </summary>
        public const string LineNumber = "<LineNumber>";

        /// <summary>
        /// The file path of the log message.
        /// </summary>
        public const string FilePath = "<FilePath>";

        /// <summary>
        /// The member name of the log message.
        /// </summary>
        public const string MemberName = "<MemberName>";

        /// <summary>
        /// The source of the log message.
        /// </summary>
        public const string Source = "<Source>";

        /// <summary>
        /// The message of the log message.
        /// </summary>
        public const string Message = "<Message>";
    }
}