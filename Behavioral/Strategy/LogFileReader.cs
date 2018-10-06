using System;
using System.Collections.Generic;

namespace Strategy
{
    //ConcreteStrategy
    public class LogFileReader : ILogReader
    {
        public List<LogEntry> Read()
        {
            return new List<LogEntry>
            {
                new LogEntry
                {
                    Date = DateTime.Now.AddDays(1),
                    Message = "Log from file",
                    Type = "FileLog"
                }
            };
        }
    }
}