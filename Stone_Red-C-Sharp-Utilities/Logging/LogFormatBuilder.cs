using System.Text;

namespace Stone_Red_C_Sharp_Utilities.Logging
{
    /// <summary>
    /// A builder for <see cref="FormatConfig"/>
    /// </summary>
    public class LogFormatBuilder
    {
        private readonly StringBuilder stringBuilder = new StringBuilder();

        /// <summary>
        /// Creates a new <see cref="LogFormatBuilder"/> instance.
        /// </summary>
        public LogFormatBuilder()
        {

        }

        /// <summary>
        /// Creates a new <see cref="LogFormatBuilder"/> instance.
        /// </summary>
        /// <param name="value">The inital format.</param>
        public LogFormatBuilder(string value)
        {
            _ = stringBuilder.Append(value);
        }

        /// <summary>
        /// Appends text to the log format.
        /// </summary>
        /// <param name="value">The text to append.</param>
        /// <returns>A reference to this <see cref="LogFormatBuilder"/> instance.</returns>
        public LogFormatBuilder Text(string value)
        {
            _ = stringBuilder.Append(value);
            return this;
        }

        /// <summary>
        /// Appends the log datie time to the log format.
        /// </summary>
        /// <param name="format">The format to apply.</param>
        /// <param name="padding">The padding to apply.</param>
        /// <returns>A reference to this <see cref="LogFormatBuilder"/> instance.</returns>
        public LogFormatBuilder DateTime(string format = "", int padding = 0)
        {
            _ = stringBuilder.Append($"{{{LogFormatType.DateTime},{padding}{GetFormat(format)}}}");
            return this;
        }

        /// <summary>
        /// Appends the log severity to the log format.
        /// </summary>
        /// <param name="format">The format to apply.</param>
        /// <param name="padding">The padding to apply.</param>
        /// <returns>A reference to this <see cref="LogFormatBuilder"/> instance.</returns>
        public LogFormatBuilder LogSeverity(string format = "", int padding = 0)
        {
            _ = stringBuilder.Append($"{{{LogFormatType.LogSeverity},{padding}{GetFormat(format)}}}");
            return this;
        }

        /// <summary>
        /// Appends the line number to the log format.
        /// </summary>
        /// <param name="format">The format to apply.</param>
        /// <param name="padding">The padding to apply.</param>
        /// <returns>A reference to this <see cref="LogFormatBuilder"/> instance.</returns>
        public LogFormatBuilder LineNumber(string format = "", int padding = 0)
        {
            _ = stringBuilder.Append($"{{{LogFormatType.LineNumber},{padding}{GetFormat(format)}}}");
            return this;
        }

        /// <summary>
        /// Appends the file path to the log format.
        /// </summary>
        /// <param name="format">The format to apply.</param>
        /// <param name="padding">The padding to apply.</param>
        /// <returns>A reference to this <see cref="LogFormatBuilder"/> instance.</returns>
        public LogFormatBuilder FilePath(string format = "", int padding = 0)
        {
            _ = stringBuilder.Append($"{{{LogFormatType.FilePath},{padding}{GetFormat(format)}}}");
            return this;
        }

        /// <summary>
        /// Appends the log source to the log format.
        /// </summary>
        /// <param name="format">The format to apply.</param>
        /// <param name="padding">The padding to apply.</param>
        /// <returns>A reference to this <see cref="LogFormatBuilder"/> instance.</returns>
        public LogFormatBuilder MemberName(string format = "", int padding = 0)
        {
            _ = stringBuilder.Append($"{{{LogFormatType.MemberName},{padding}{GetFormat(format)}}}");
            return this;
        }

        /// <summary>
        /// Appends the log source to the log format.
        /// </summary>
        /// <param name="format">The format to apply.</param>
        /// <param name="padding">The padding to apply.</param>
        /// <returns>A reference to this <see cref="LogFormatBuilder"/> instance.</returns>
        public LogFormatBuilder Source(string format = "", int padding = 0)
        {
            _ = stringBuilder.Append($"{{{LogFormatType.Source},{padding}{GetFormat(format)}}}");
            return this;
        }

        /// <summary>
        /// Appends the log message to the log format.
        /// </summary>
        /// <param name="format">The format to apply.</param>
        /// <param name="padding">The padding to apply.</param>
        /// <returns>A reference to this <see cref="LogFormatBuilder"/> instance.</returns>
        public LogFormatBuilder Message(string format = "", int padding = 0)
        {
            _ = stringBuilder.Append($"{{{LogFormatType.Message},{padding}{GetFormat(format)}}}");
            return this;
        }

        private string GetFormat(string format)
        {
            return string.IsNullOrWhiteSpace(format) ? string.Empty : $":{format}";
        }

        /// <summary>
        /// Converts the <see cref="LogFormatBuilder" to <see cref="string"/>/>
        /// </summary>
        /// <param name="value">The <see cref="LogFormatBuilder"/> to convert.</param>
        public static implicit operator string(LogFormatBuilder value)
        {
            return value.stringBuilder.ToString();
        }

        /// <summary>
        /// Converts the <see cref="string" to <see cref="LogFormatBuilder"/>/>
        /// </summary>
        /// <param name="value">The <see cref="stringBuilder"/> to convert.</param>
        public static implicit operator LogFormatBuilder(string value)
        {
            return new LogFormatBuilder(value);
        }
    }
}
