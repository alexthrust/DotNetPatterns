using System;
using Strategy;

namespace DotNetPatterns.Exec
{
    class Program
    {
        static void Main(string[] args)
        {
            var logFileReader = new LogFileReader();
            var fileLogProcessor = new LogProcessor(logFileReader.Read);
            fileLogProcessor.ProcessLogs();
            fileLogProcessor.Logs.ForEach(Console.WriteLine);

            var windowsEventLogReader = new WindowsEventLogReader();
            var windowsEventsLogProcessor = new LogProcessor(windowsEventLogReader.Read);
            windowsEventsLogProcessor.ProcessLogs();
            windowsEventsLogProcessor.Logs.ForEach(Console.WriteLine);
        }
    }
}
