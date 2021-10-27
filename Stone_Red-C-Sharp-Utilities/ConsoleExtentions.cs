using System;
using System.ComponentModel;

namespace Stone_Red_Utilities.ConsoleExtentions
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

        public static T ReadLine<T>()
        {
            string attemptedValue = Console.ReadLine();
            Type type = typeof(T);
            TypeConverter converter = TypeDescriptor.GetConverter(type);
            if (converter != null && converter.IsValid(attemptedValue))
            {
                return (T)converter.ConvertFromString(attemptedValue);
            }
            else
            {
                return default;
            }
        }

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

        public static T ReadKey<T>()
        {
            string attemptedValue = Console.ReadKey().KeyChar.ToString();
            Type type = typeof(T);
            TypeConverter converter = TypeDescriptor.GetConverter(type);
            if (converter != null && converter.IsValid(attemptedValue))
            {
                return (T)converter.ConvertFromString(attemptedValue);
            }
            else
            {
                return default;
            }
        }

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
            while (Console.ReadKey(true).Key != key)
            {
            }
        }

        /// <summary>
        /// Suspends execution of the current method until the user presses a key
        /// </summary>
        /// <param name="message">The message that will be displayed</param>
        public static void Pause(string message = "Press any key to continue...")
        {
            Console.WriteLine(message);
            Console.ReadKey(true);
        }
    }
}