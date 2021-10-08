using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace Stone_Red_Utilities.StringExtentions
{
    /// <summary>
    /// <see cref="string"/> Extentions
    /// </summary>
    public static class StringExt
    {
        /// <summary>
        /// Determines whether this instance and another specified <see cref="string"/> object have the same value regardless of upper and lower case.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool EqualsIgnoreCase(this string str, string value)
        {
            return str.ToLower().Equals(value.ToLower());
        }

        /// <summary>
        /// Determines whether this instance and another specified <see cref="string"/> object have the same value regardless of spaces.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool EqualsIgnoreSpaces(this string str, string value)
        {
            return str.Replace(" ", string.Empty).Equals(value.Replace(" ", string.Empty));
        }

        /// <summary>
        /// Determines whether this instance and another specified <see cref="string"/> object have the same value regardless of upper and lower case and spaces.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool EqualsIgnoreSpacesAndCase(this string str, string value)
        {
            return str.Replace(" ", string.Empty).ToLower().Equals(value.Replace(" ", string.Empty).ToLower());
        }

        /// <summary>
        /// Removes all invalid chars from the specified <see cref="string"/>
        /// </summary>
        /// <param name="str"></param>
        /// <param name="allowSpaces"></param>
        /// <returns></returns>
        public static string ToFileName(this string str, bool allowSpaces = false)
        {
            char[] invalidChars = Path.GetInvalidFileNameChars();

            if (!allowSpaces)
            {
                str = str.Replace(" ", string.Empty);
            }

            foreach (char item in invalidChars)
            {
                str = str.Replace(item.ToString(), string.Empty);
            }

            string normalizedString = str.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in normalizedString)
            {
                UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        /// <summary>
        /// Removes all invalid chars from the specified <see cref="string"/>
        /// </summary>
        /// <param name="str"></param>
        /// <param name="allowSpaces"></param>
        /// <returns></returns>
        public static string ToPath(this string str, bool allowSpaces = false)
        {
            char[] invalidChars = Path.GetInvalidPathChars();

            if (!allowSpaces)
            {
                str = str.Replace(" ", string.Empty);
            }

            foreach (char item in invalidChars)
            {
                str = str.Replace(item.ToString(), string.Empty);
            }

            string normalizedString = str.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in normalizedString)
            {
                UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        /// <summary>
        /// Truncates a <see cref="string"/> to the specified length.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string Truncate(this string str, int length)
        {
            if (str.Length > length && length > 0)
            {
                return str.Substring(0, length);
            }

            return str;
        }

        /// <summary>
        /// Truncates a <see cref="string"/> to the specified length.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="length"></param>
        /// <param name="ellipsis"></param>
        /// <returns></returns>
        public static string Truncate(this string str, int length, bool ellipsis)
        {
            if (str.Length > length && length > 0)
            {
                if (ellipsis)
                {
                    return $"{str.Substring(0, length - 3)}...";
                }
                else
                {
                    return str.Substring(0, length);
                }
            }

            return str;
        }

        /// <summary>
        /// Uses the correct newline <see cref="string"/> defined for this environment.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string CorrectNewLine(this string str)
        {
            if (Environment.OSVersion.Platform == PlatformID.Unix)
            {
                str = str.Replace("\r\n", "\n");
            }
            else
            {
                str = str.Replace("\n", "\r\n"); //Ik that this can produce wrong results
            }

            return str;
        }

        /// <summary>
        /// Revoves all whitespaces from the specified <see cref="string"/>
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveWhitespaces(this string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in str)
            {
                if (!char.IsWhiteSpace(c))
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }

        /// <summary>
        /// Reverses the specified <see cref="string"/>
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Reverse(this string str)
        {
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}