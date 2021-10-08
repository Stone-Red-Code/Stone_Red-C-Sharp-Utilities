using Stone_Red_Utilities.BoolExtentions;
using Stone_Red_Utilities.ConsoleExtentions;
using Stone_Red_Utilities.FluentMath;
using Stone_Red_Utilities.Logging;

using System;
using System.Diagnostics;

namespace Stone_Red_C_Sharp_Utilities_Test
{
    internal class Program
    {
        private static readonly Logger logger = new Logger()
        {
            Config = new LogConfig()
            {
                FatalConfig = new OutputConfig()
                {
                    Color = ConsoleColor.DarkRed,
                    LogTarget = LogTarget.Console | LogTarget.DebugConsole | LogTarget.File
                },
                ErrorConfig = new OutputConfig()
                {
                    Color = ConsoleColor.Red,
                    LogTarget = LogTarget.Console | LogTarget.DebugConsole | LogTarget.File
                },
                WarnConfig = new OutputConfig()
                {
                    Color = ConsoleColor.Yellow,
                    LogTarget = LogTarget.Console | LogTarget.DebugConsole | LogTarget.File
                },
                InfoConfig = new OutputConfig()
                {
                    Color = ConsoleColor.White,
                    LogTarget = LogTarget.Console | LogTarget.DebugConsole | LogTarget.File
                },
                DebugConfig = new OutputConfig()
                {
                    Color = ConsoleColor.Gray,
                    LogTarget = LogTarget.Console | LogTarget.DebugConsole
                },
                FormatConfig = new FormatConfig()
                {
                    ConsoleFormat = $"{{{LogFormatType.DateTime}:hh:mm:ss}} | {{{LogFormatType.LogSeverity},-5}} | {{{LogFormatType.Message}}}"
                }
            }
        };

        private static void Main()
        {
            Trace.WriteLine("kek1");
            Debug.WriteLine("kek2");
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            while (true)
            {
                ConsoleExt.Write("Enter the first  number: ", ConsoleColor.Green);
                bool success = int.TryParse(Console.ReadLine(), out int num1);

                ConsoleExt.Write("Enter the second number: ", ConsoleColor.Green);
                success.OneWayFalse(int.TryParse(Console.ReadLine(), out int num2));

                logger.LogIf(success, "Valid input!", LogSeverity.Debug);

                if (success)
                {
                    Console.WriteLine($"{num1}/{num2} = {num1.Divide(num2)}");
                }
                else
                {
                    logger.Log("Invalid input!", "Calculator", LogSeverity.Warn);
                }
            }
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception exception = (Exception)e.ExceptionObject;

            logger.Log(exception + (e.IsTerminating ? "\t Process terminating!" : ""), exception.Source, LogSeverity.Fatal);
        }
    }
}