using Stone_Red_Utilities.Http;
using Stone_Red_Utilities.Logging;
using Stone_Red_Utilities.Reflection;

using System;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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

        private static async Task Main()
        {
            HttpClient httpClient = new HttpClient();
            Quote quote = await httpClient.GetJsonObjectAsync<Quote>("https://api.quotable.io/random");
            Console.WriteLine(quote.Id);
            Console.WriteLine(quote.Content);
            Console.WriteLine(quote.Author);

            Quote q = quote.CopyProperties<Quote>();

            Console.WriteLine(q.Id);
            Console.WriteLine(q.Content);
            Console.WriteLine(q.Author);
        }

        private class Quote
        {
            [JsonPropertyName("_id")]
            public string Id { get; set; }

            [JsonPropertyName("content")]
            public string Content { get; set; }

            [JsonPropertyName("author")]
            public string Author { get; set; }
        }
    }
}