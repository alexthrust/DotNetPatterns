using System;
using System.Collections.Generic;
using Models;

namespace Strategy
{
    //Context
    public class LogProcessor
    {
        public List<string> Logs { get; set; }

        private readonly Func<List<LogEntry>> _logImporter;
        public LogProcessor(Func<List<LogEntry>> logImporter)
        {
            _logImporter = logImporter;
        }

        public void ProcessLogs()
        {
            foreach (var logEntry in _logImporter.Invoke())
            {
                SaveLogs(logEntry);
            }
        }

        private void SaveLogs(LogEntry logEntry)
        {
            Logs = new List<string>
            {
                $"{logEntry.Date} - {logEntry.Type} - {logEntry.Message}"
            };
        }
    }
}