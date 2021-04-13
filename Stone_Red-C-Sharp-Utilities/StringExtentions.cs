using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Stone_Red_Utilities.StringExtentions
{
    /// <summary>
    /// <see cref="string"/> Extentions
    /// </summary>
    public static class StringExt
    {
        /// <summary>
        /// Determines whether this instance and another specified <see cref="String"/> object have the same value regardless of upper and lower case.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool EqualsIgnoreCase(this string str, string value)
        {
            return str.ToLower().Equals(value.ToLower());
        }

        /// <summary>
        /// Determines whether this instance and another specified <see cref="String"/> object have the same value regardless of spaces.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool EqualsIgnoreSpaces(this string str, string value)
        {
            return str.Replace(" ", string.Empty).Equals(value.Replace(" ", string.Empty));
        }

        /// <summary>
        /// Determines whether this instance and another specified <see cref="String"/> object have the same value regardless of upper and lower case and spaces.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool EqualsIgnoreSpacesAndCase(this string str, string value)
        {
            return str.Replace(" ", string.Empty).ToLower().Equals(value.Replace(" ", string.Empty).ToLower());
        }

        /// <summary>
        /// Removes all invalid chars from file name
        /// </summary>
        /// <param name="str"></param>
        /// <param name="allowSpaces"></param>
        /// <returns></returns>
        public static string ToFileName(this string str, bool allowSpaces = false)
        {
            char[] invalidChars = Path.GetInvalidFileNameChars();

            if (!allowSpaces)
                str = str.Replace(" ", string.Empty);

            foreach (var item in invalidChars)
            {
                str = str.Replace(item.ToString(), string.Empty);
            }

            var normalizedString = str.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        /// <summary>
        /// Truncates a string to the specified length.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string Truncate(this string str, int length)
        {
            if (str.Length > length && length > 0)
                return str.Substring(0, length);

            return str;
        }

        /// <summary>
        /// Truncates a string to the specified length.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="length"></param>
        /// <param name="ellipsis"></param>
        /// <returns></returns>
        public static string Truncate(this string str, int length, bool ellipsis)
        {
            if (str.Length > length && length > 0)
                if (ellipsis)
                {
                    return $"{str.Substring(0, length - 3)}...";
                }
                else
                {
                    return str.Substring(0, length);
                }

            return str;
        }
    }
}