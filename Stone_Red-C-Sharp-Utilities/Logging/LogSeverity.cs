namespace Stone_Red_Utilities.Logging
{
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
        Warn,

        /// <summary>
        /// Logs that highlight when the flow of execution is stopped due to a failure.
        /// </summary>
        Error,

        /// <summary>
        /// Logs that contain the most severe level of error. This type of error indicate that immediate attention may be required.
        /// </summary>
        Fatal
    }
}