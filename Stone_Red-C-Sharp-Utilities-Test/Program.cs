using Stone_Red_C_Sharp_Utilities.Logging;
using Stone_Red_C_Sharp_Utilities.Tasks;

using Stone_Red_Utilities.Logging;

using System;
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
                    ConsoleColor = ConsoleColor.DarkRed,
                    LogTarget = LogTarget.Console | LogTarget.DebugConsole | LogTarget.File
                },
                ErrorConfig = new OutputConfig()
                {
                    ConsoleColor = ConsoleColor.Red,
                    LogTarget = LogTarget.Console | LogTarget.DebugConsole | LogTarget.File
                },
                WarnConfig = new OutputConfig()
                {
                    ConsoleColor = ConsoleColor.Yellow,
                    LogTarget = LogTarget.Console | LogTarget.DebugConsole | LogTarget.File
                },
                InfoConfig = new OutputConfig()
                {
                    ConsoleColor = ConsoleColor.White,
                    LogTarget = LogTarget.Console | LogTarget.DebugConsole | LogTarget.File
                },
                DebugConfig = new OutputConfig()
                {
                    ConsoleColor = ConsoleColor.Gray,
                    LogTarget = LogTarget.Console | LogTarget.DebugConsole
                },
                FormatConfig = new FormatConfig()
                {
                    //ConsoleFormat = $"{{{LogFormatType.DateTime}:HH:mm:ss}} | {{{LogFormatType.LogSeverity},-5}} | {{{LogFormatType.Message}}}"
                    ConsoleFormat = new LogFormatBuilder().DateTime("HH:mm:ss").Text(" | ").LogSeverity(padding: -5).Text(" | ").Message()
                }
            }
        };

        private static void Main()
        {
            TaskQueue taskQueue = new TaskQueue();
            _ = taskQueue.Enqueue(CreateTask(0, 1000)).Subscribe((Task t) => logger.LogInfo("Task 0 completed"));
            _ = taskQueue.Enqueue(CreateTask(1, 100)).Subscribe((Task t) => logger.LogInfo("Task 1 completed"));
            _ = taskQueue.Enqueue(CreateTask(2, 2000)).Subscribe((Task t) => logger.LogInfo("Task 2 completed"));
            _ = taskQueue.Enqueue(CreateTask(3, 500)).Subscribe((Task t) => logger.LogInfo("Task 3 completed"));

            logger.Log("wow", LogSeverity.Info);

            _ = Console.ReadLine();
        }

        private static Task CreateTask(int i, int delay)
        {
            return new Task(async () =>
            {
                logger.LogInfo($"Start task {i}");
                await Task.Delay(delay);
                logger.LogInfo($"End task {i}");
            });
        }
    }
}