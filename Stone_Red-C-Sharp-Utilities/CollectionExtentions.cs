using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Stone_Red_Utilities.CollectionExtentions
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
    /// <see cref="IEnumerable{T}"/> and <see cref="Array"/> Extentions
    /// </summary>
    public static class CollectionExt
    {
        /// <summary>
        /// Prints all items of an <see cref="IEnumerable{T}"/>
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="delimiter"></param>
        /// <param name="printToDebugConsole"></param>
        public static void Print<T>(this IEnumerable<T> collection, char delimiter = ',', bool printToDebugConsole = false)
        {
            int i = 0;
            int length = collection.Count() - 1;
            string split = delimiter + (delimiter == '\n' ? string.Empty : " ");
            foreach (var item in collection)
            {
                if (item is IEnumerable<T> ie)
                {
                    ie.Print(delimiter, printToDebugConsole);
                }
                else if (printToDebugConsole)
                {
                    Debug.Write(item.ToString() + (i < length ? split : string.Empty));
                }
                else
                {
                    Console.Write(item.ToString() + (i < length ? split : string.Empty));
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