using System;

namespace Stone_Red_Utilities.ConsoleExtentions
{
    /// <summary>
    /// <see cref="Console"/> Extentions
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
        /// Suspends execution of the current method until the user presses a key
        /// </summary>
        /// <param name="enterKeyOnly"></param>
        /// <param name="customMessage"></param>
        public static void Pause(bool enterKeyOnly = false, string customMessage = null)
        {
            if (customMessage is null)
            {
                if (enterKeyOnly)
                {
                    Console.WriteLine("Press ENTER to continue.");
                }
                else
                {
                    Console.WriteLine("Press any key to continue.");
                }
            }
            else
            {
                Console.WriteLine(customMessage);
            }

            if (enterKeyOnly)
            {
                Console.ReadLine();
            }
            else
            {
                Console.ReadKey();
            }
        }
    }
}