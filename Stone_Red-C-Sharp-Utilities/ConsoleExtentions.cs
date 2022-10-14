using System;
using System.ComponentModel;

#pragma warning disable S3998 // Threads should not lock on objects with weak identity

namespace Stone_Red_C_Sharp_Utilities
{
    /// <summary>
    /// <see cref="Console"/> Extensions
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

        /// <summary>
        /// Reads the next line of characters from the standard input stream and tries to convert it to the specified type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>The input string converted to the specified type.</returns>
        /// <exception cref="NotSupportedException"></exception>
        public static T ReadLine<T>()
        {
            string attemptedValue = Console.ReadLine();
            Type type = typeof(T);
            TypeConverter converter = TypeDescriptor.GetConverter(type);

            return (T)converter.ConvertFromString(attemptedValue);
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream and tries to convert it to the specified type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input">The input string converted to the specified type.</param>
        /// <returns><see langword="true"/> if the conversion was successful. Otherwise <see langword="false"/></returns>
        public static bool TryReadLine<T>(out T input)
        {
            string attemptedValue = Console.ReadLine();
            Type type = typeof(T);
            TypeConverter converter = TypeDescriptor.GetConverter(type);
            if (converter != null && converter.IsValid(attemptedValue))
            {
                input = (T)converter.ConvertFromString(attemptedValue);
                return true;
            }
            else
            {
                input = default;
                return false;
            }
        }

        /// <summary>
        /// Obtains the next character or function key pressed by the user and converts it to the specified type.
        /// The pressed key is displayed in the console window.
        /// </summary>
        /// <typeparam name="T">The type of the </typeparam>
        /// <returns>The input character converted to the specified type.</returns>
        /// <exception cref="NotSupportedException"></exception>
        public static T ReadKey<T>()
        {
            string attemptedValue = Console.ReadKey().KeyChar.ToString();
            Type type = typeof(T);
            TypeConverter converter = TypeDescriptor.GetConverter(type);

            return (T)converter.ConvertFromString(attemptedValue);
        }

        /// <summary>
        /// Obtains the next character or function key pressed by the user and tries to convert it to the specified type.
        /// The pressed key is displayed in the console window.
        /// </summary>
        /// <param name="input">The input character converted to the specified type.</param>
        /// <typeparam name="T">The type of the </typeparam>
        /// <returns><see langword="true"/> if the conversion was successful. Otherwise <see langword="false"/></returns>
        public static bool TryReadKey<T>(out T input)
        {
            string attemptedValue = Console.ReadKey().KeyChar.ToString();
            Type type = typeof(T);
            TypeConverter converter = TypeDescriptor.GetConverter(type);
            if (converter != null && converter.IsValid(attemptedValue))

            {
                input = (T)converter.ConvertFromString(attemptedValue);
                return true;
            }
            else
            {
                input = default;
                return false;
            }
        }

        /// <summary>
        /// Suspends execution of the current method until the user presses a key
        /// </summary>
        /// <param name="key">The key that has to be pressed</param>
        /// <param name="message">The message that will be displayed</param>
        public static void Pause(ConsoleKey key, string message = null)
        {
            Console.WriteLine(message ?? $"Press {key} to continue...");
            ConsoleKey? consoleKey = null;
            while (consoleKey != key)
            {
                consoleKey = Console.ReadKey(true).Key;
            }
        }

        /// <summary>
        /// Suspends execution of the current method until the user presses a key
        /// </summary>
        /// <param name="message">The message that will be displayed</param>
        public static void Pause(string message = "Press any key to continue...")
        {
            Console.WriteLine(message);
            _ = Console.ReadKey(true);
        }
    }
}