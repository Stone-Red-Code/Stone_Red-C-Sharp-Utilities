namespace Stone_Red_Utilities.Logging
{
    /// <summary>
    /// Specifies the target of the log message.
    /// </summary>
    public enum LogTarget
    {
        /// <summary>
        /// Writes log to console
        /// </summary>
        Console = 1,

        /// <summary>
        /// Writes log to debug console
        /// </summary>
        DebugConsole = 2,

        /// <summary>
        /// Writes log to file
        /// </summary>
        File = 3
    }
}