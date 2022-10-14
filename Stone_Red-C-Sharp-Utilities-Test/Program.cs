using Stone_Red_C_Sharp_Utilities;
using Stone_Red_C_Sharp_Utilities.Logging;

using Stone_Red_Utilities.Logging;

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Stone_Red_C_Sharp_Utilities_Test
{
    internal static class Program
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
                    ConsoleFormat = $"{{{LogFormatType.DateTime}:HH:mm:ss}} | {{{LogFormatType.LogSeverity},-5}} | {{{LogFormatType.Message}}}"
                }
            }
        };

        private static async Task Main()
        {
            TaskQueue taskQueue = new TaskQueue();
            await taskQueue.Enqueue(() => Console.WriteLine("YES1"));
            await taskQueue.Enqueue(() => Console.WriteLine("YES2"));
            await taskQueue.Enqueue(() => Thread.Sleep(2000));
            await taskQueue.Enqueue(() => Console.WriteLine("YES3"));

            logger.Log("wow", LogSeverity.Info);
        }
    }
}