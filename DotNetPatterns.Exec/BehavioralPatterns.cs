using System;
using System.Linq;
using Strategy;
using TemplateMethod;

namespace DotNetPatterns.Exec
{
    public class BehavioralPatterns
    {
        public static void ExecuteStrategy()
        {
            var logFileReader = new Strategy.LogFileReader();
            var fileLogProcessor = new LogProcessor(logFileReader.Read);
            fileLogProcessor.ProcessLogs();
            fileLogProcessor.Logs.ForEach(Console.WriteLine);

            var windowsEventLogReader = new WindowsEventLogReader();
            var windowsEventsLogProcessor = new LogProcessor(windowsEventLogReader.Read);
            windowsEventsLogProcessor.ProcessLogs();
            windowsEventsLogProcessor.Logs.ForEach(Console.WriteLine);
        }

        public static void ExecuteTemplateMethod()
        {
            var logReader = new TemplateMethod.LogFileReader();
            var logEntries = logReader.ReadLogEntry().ToList();

            logEntries.ForEach(logEntry => Console.WriteLine($"{logEntry.Date} - {logEntry.Type} - {logEntry.Message}"));
        }
    }
}