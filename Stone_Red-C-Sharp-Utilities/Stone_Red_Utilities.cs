using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;

namespace Stone_Red_Utilities.ArrListExtentions
{
    /// <summary>
    /// Table Style
    /// </summary>
    public enum TableStyle
    {
        /// <summary>
        /// The default representaion of the table
        /// </summary>
        Default,

        /// <summary>
        /// The minimal representation of the table
        /// </summary>
        Minimum,

        /// <summary>
        /// The alternative representaion of the table
        /// </summary>
        Alternative,

        /// <summary>
        /// The list representaion of the table
        /// </summary>
        List
    }

    /// <summary>
    /// <see cref="Array"/> and <see cref="List{T}"/> Extentions
    /// </summary>
    public static class ArrayListExt
    {
        /// <summary>
        /// Prints items of array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="delimiter"></param>
        /// <param name="printToDebugConsole"></param>
        public static void Print(this Array array, char delimiter = ',', bool printToDebugConsole = false)
        {
            int i = 0;
            string split = delimiter + (delimiter == '\n' ? string.Empty : " ");
            foreach (var item in array)
            {
                if (item is Array arr)
                {
                    arr.Print(delimiter, printToDebugConsole);
                }
                else if (printToDebugConsole)
                {
                    Debug.Write(item.ToString() + (i < array.Length - 1 ? split : string.Empty));
                }
                else
                {
                    Console.Write(item.ToString() + (i < array.Length - 1 ? split : string.Empty));
                }
                i++;
            }
        }

        /// <summary>
        /// Prints items of list
        /// </summary>
        /// <param name="list"></param>
        /// <param name="delimiter"></param>
        /// <param name="printToDebugConsole"></param>
        public static void Print<T>(this List<T> list, char delimiter = ',', bool printToDebugConsole = false)
        {
            int i = 0;
            string split = delimiter + (delimiter == '\n' ? string.Empty : " ");
            foreach (var item in list)
            {
                if (item is Array arr)
                {
                    arr.Print(delimiter, printToDebugConsole);
                }
                else if (item is List<T> ls)
                {
                    ls.Print(delimiter, printToDebugConsole);
                }
                else if (printToDebugConsole)
                {
                    Debug.Write(item.ToString() + (i < list.Count - 1 ? split : string.Empty));
                }
                else
                {
                    Console.Write(item.ToString() + (i < list.Count - 1 ? split : string.Empty));
                }
                i++;
            }
        }

        /// <summary>
        /// Creates and prints table from 2D array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="tableStyle"></param>
        public static void PrintTable<T>(this T[,] array, TableStyle tableStyle = TableStyle.Default)
        {
            int[] itemLength = new int[array.GetLength(1)];
            char verticalChar = tableStyle == TableStyle.Minimum ? ' ' : '|';

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    itemLength[j] = Math.Max(array[i, j].ToString().Length + 2, itemLength[j]);
                }
            }

            PrintLine(tableStyle, itemLength, array.GetLength(1), tableStyle == TableStyle.List);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    string item = " " + array[i, j].ToString() + " ";
                    item = verticalChar + item + new string(' ', itemLength[j] - item.Length);
                    Console.Write(tableStyle == TableStyle.Minimum && j == 0 ? item.TrimStart() : item);
                }

                Console.Write(verticalChar);

                PrintLine(tableStyle, itemLength, array.GetLength(1), i == 0);
            }
        }

        private static void PrintLine(TableStyle tableStyle, int[] itemLength, int itemCount, bool forcePrint = false)
        {
            char intersect = tableStyle == TableStyle.Alternative || tableStyle == TableStyle.List ? '+' : '-';

            Console.WriteLine();
            if (tableStyle == TableStyle.Minimum || tableStyle == TableStyle.List)
            {
                if (tableStyle == TableStyle.List && forcePrint)
                    Console.Write(intersect);
                if (!forcePrint)
                    return;
            }
            else
            {
                Console.Write(intersect);
            }

            for (int k = 0; k < itemCount; k++)
            {
                Console.Write(new string('-', itemLength[k] - (tableStyle == TableStyle.Minimum ? 1 : 0)) + intersect);
            }
            Console.WriteLine();
        }
    }
}

namespace Stone_Red_Utilities.BoolExtentions
{
    /// <summary>
    /// <see cref="bool"/> Extentions
    /// </summary>
    public static class BoolExt
    {
        /// <summary>
        /// Sets value to true if input is true. If input is false the value will not change.
        /// </summary>
        /// <param name="bol"></param>
        /// <param name="input"></param>
        public static void OneWayTrue(this ref bool bol, bool input)
        {
            if (bol == false && input)
                bol = true;
        }

        /// <summary>
        /// Sets value to false if input is false. If input is true the value will not change.
        /// </summary>
        /// <param name="bol"></param>
        /// <param name="input"></param>
        public static void OneWayFalse(this ref bool bol, bool input)
        {
            if (bol == true && !input)
                bol = false;
        }
    }
}

namespace Stone_Red_Utilities.ColorConsole
{
    /// <summary>
    /// Console Extentions
    /// </summary>
    public static class ConsoleExt
    {
        /// <summary>
        /// Writes the text representation of the specified object to the standard output stream.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="color"></param>
        public static void Write(object value, ConsoleColor color)
        {
            lock (Console.Out)
            {
                ConsoleColor oldColor = Console.ForegroundColor;
                Console.ForegroundColor = color;
                Console.Write(value);
                Console.ForegroundColor = oldColor;
            }
        }

        /// <summary>
        /// Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="color"></param>
        public static void WriteLine(object value, ConsoleColor color)
        {
            lock (Console.Out)
            {
                ConsoleColor oldColor = Console.ForegroundColor;
                Console.ForegroundColor = color;
                Console.WriteLine(value);
                Console.ForegroundColor = oldColor;
            }
        }
    }
}

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
    }
}